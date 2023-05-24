using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public  class OrderDAO
    {
        // Singleton
        private static OrderDAO instance;
        private static object instanceLock = new object();

        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrdersList()
        {
            IEnumerable<Order> orders = null;

            try
            {
                var context = new FUFlowerBouquetManagementContext();
                // Get From Database

                orders = context.Orders.Include(pro => pro.Customer);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return orders;
        }
    }
}
