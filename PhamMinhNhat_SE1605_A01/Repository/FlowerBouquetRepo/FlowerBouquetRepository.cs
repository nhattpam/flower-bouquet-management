using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.FlowerBouquetRepo
{
    public class FlowerBouquetRepository : IFlowerBouquetRepository
    {
       
        public IEnumerable<FlowerBouquet> GetFlowerBouquetsList()
        {
            return FlowerBouquetDAO.Instance.GetFlowerBouquetsList();
        }
    }
}
