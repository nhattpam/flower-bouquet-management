using DataAccess.Repository.FlowerBouquetRepo;
using Repository.CustomerRepo;
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

namespace PhamMinhNhatWPF.CustomerLayout
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : Window
    {
        public LoginViewModel LoginMember { get; set; }
        ICustomerRepository customerRepository { get; set; }
        public CustomerManagement()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        void LoadData()
        {
            lvCustomers.ItemsSource = List();
        }

        public IEnumerable<CustomerViewModel> List()
        {
            var cuses = customerRepository.GetCustomersList();

            var dtos = cuses.Select(c => new CustomerViewModel()
            {
                CustomerId = c.CustomerId,
                CustomerName = c.CustomerName,
                Email = c.Email,
                City = c.City,
                Birthday = c.Birthday,
                Country = c.Country
            });

            return dtos;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int customId = Int32.Parse(txtCustomerID.Text);
            if (customId != null)
            {
                var cus = customerRepository.GetCustomerById(customId);

                var dto = new CustomerViewModel()
                {
                    CustomerId = cus.CustomerId
                };


                customerRepository.DeleteCustomer(dto.CustomerId);
                MessageBox.Show("Thanh cong");
                LoadData();
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
    }
}
