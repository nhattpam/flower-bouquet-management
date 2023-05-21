using BusinessObjects.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CustomerRepo
{
    public class CustomerRepository : ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomersList()
        {
            return CustomerDAO.Instance.GetCustomersList();
        }

        public Customer Login(string email, string password)
        {
            return CustomerDAO.Instance.Login(email, password);
        }
    }
}
