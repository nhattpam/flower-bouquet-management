using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class FlowerBouquetDAO
    {
        // Singleton
        private static FlowerBouquetDAO instance;
        private static object instanceLock = new object();

        public static FlowerBouquetDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new FlowerBouquetDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<FlowerBouquet> GetFlowerBouquetsList()
        {
            IEnumerable<FlowerBouquet> flowerBouquets = null;

            try
            {
                var context = new FUFlowerBouquetManagementContext();
                // Get From Database

                flowerBouquets = context.FlowerBouquets
                            .Include(pro => pro.Category)
                            .Include(pro => pro.Supplier);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return flowerBouquets;
        }
    }
}
