using BusinessObjects.Models;
using DataAccess.Repository.FlowerBouquetRepo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FlowerBouquetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public IFlowerBouquetRepository flowerBouquetRepository { get; set; }

        public FlowerBouquetViewModel()
        {
            flowerBouquetRepository = new FlowerBouquetRepository();
            //display list Customers
            LoadData();
        }


        private IEnumerable<FlowerBouquet> flowerBouquetList;

        public IEnumerable<FlowerBouquet> FlowerBouquetList
        {
            get { return flowerBouquetList; }
            set { flowerBouquetList = value; OnPropertyChanged("FlowerBouquetList"); }
        }

        private void LoadData()
        {
            FlowerBouquetList = flowerBouquetRepository.GetFlowerBouquetsList();
        }
    }
}
