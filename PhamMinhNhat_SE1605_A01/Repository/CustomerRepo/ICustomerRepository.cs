using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.CustomerRepo
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customer> GetCustomersList();
        public Customer Login(string email, string password);
    }
}
