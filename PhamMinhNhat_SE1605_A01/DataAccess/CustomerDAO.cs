﻿using BusinessObjects.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerDAO
    {
        // Using Singleton Pattern
        private static CustomerDAO instance = null;
        private static object instanceLook = new object();

        public static CustomerDAO Instance
        {
            get
            {
                lock (instanceLook)
                {
                    if (instance == null)
                    {
                        instance = new CustomerDAO();
                    }
                    return instance;
                }
            }
        }

        // Get default user from appsettings (admin)
        private Customer GetDefaultMember()
        {
            Customer Default = null;
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
                string email = config["account:defaultAccount:email"];
                string password = config["account:defaultAccount:password"];
                Default = new Customer
                {
                    CustomerId = 0,
                    Email = email,
                    Password = password,
                    City = "hello",
                    Country = "sdfsdfsdf",
                    CustomerName = "Admin",
                    Birthday = null
                };
            }
            return Default;
        }

        public IEnumerable<Customer> GetCustomersList()
        {
            IEnumerable<Customer> customers = null;

            try
            {
                var context = new FUFlowerBouquetManagementContext();
                // Get From Database
                customers = context.Customers;
                // Add Default User
                customers = customers.Append(GetDefaultMember());

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return customers;
        }

        public Customer Login(string email, string password)
        {
            IEnumerable<Customer> customers = GetCustomersList();
            Customer customer = customers.SingleOrDefault(mb => mb.Email.Equals(email) && mb.Password.Equals(password));
            return customer;
        }

    }
}