using BusinessObjects.Models;
using DataAccess;
using DataAccess.Repository.FlowerBouquetRepo;
using Repository.OrderDetailRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModel;

namespace PhamMinhNhatWPF.FlowerBouquetWPF
{
    /// <summary>
    /// Interaction logic for FlowerBouquetManagement.xaml
    /// </summary>
    public partial class FlowerBouquetManagement : Window
    {
       IFlowerBouquetRepository flowerBouquetRepository { get; set; }
       IOrderDetailRepository orderDetailRepository { get; set; }
       public LoginViewModel LoginMember { get; set; }
        public FlowerBouquetManagement()
        {
            flowerBouquetRepository = new FlowerBouquetRepository();
            orderDetailRepository = new OrderDetailRepository();
            InitializeComponent();
        }

        void LoadData()
        {
            lvFlowerBoutiques.ItemsSource = List();
        }

        public IEnumerable<FlowerBouquetViewModel> List()
        {
            var flowers = flowerBouquetRepository.GetFlowerBouquetsList();

            var dtos = flowers.Select(flower => new FlowerBouquetViewModel() 
            {
                FlowerBouquetId = flower.FlowerBouquetId,
                FlowerBouquetName = flower.FlowerBouquetName,
                CategoryId = flower.CategoryId,
                Description = flower.Description,
                UnitPrice = flower.UnitPrice,
                UnitsInStock = flower.UnitsInStock,
                FlowerBouquetStatus = flower.FlowerBouquetStatus,
                SupplierId = flower.SupplierId,
                Category = flower.Category,
                Supplier = flower.Supplier,
                OrderDetails = flower.OrderDetails

            });

            return dtos;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int flowerBouquetId = Int32.Parse(txtFlowerBouquetID.Text);
            if (flowerBouquetId != null)
            {
                var flowerBouquet = flowerBouquetRepository.GetFlowerBouquetsById(flowerBouquetId);

                var dto = new FlowerBouquetViewModel()
                {
                    FlowerBouquetId = flowerBouquet.FlowerBouquetId,
                    FlowerBouquetName = flowerBouquet.FlowerBouquetName
                };
                if (MessageBox.Show($"Do u want to delete FlowerBouquet: {dto.FlowerBouquetName}", "Delete FlowerBouquet",
                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    // if yes->Delete
                    IEnumerable<OrderDetail> list = orderDetailRepository.GetFlowerBouquetById(dto.FlowerBouquetId);
                    if(list.Where(l => l.FlowerBouquetId == dto.FlowerBouquetId).Any())
                    {
                        //MessageBox.Show("Ton tai trong order" + dto.FlowerBouquetName);
                        flowerBouquetRepository.DeleteInOrder(dto.FlowerBouquetId);
                        LoadData();
                    }
                    else
                    {
                        //MessageBox.Show("khong Ton tai trong order" + dto.FlowerBouquetName);
                        flowerBouquetRepository.DeleteFlowerBouquet(dto.FlowerBouquetId);
                        LoadData();
                    }


                }

            }
            
        }
    }
}
