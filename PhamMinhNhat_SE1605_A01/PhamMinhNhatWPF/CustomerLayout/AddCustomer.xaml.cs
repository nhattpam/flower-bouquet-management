using BusinessObjects.Models;
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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        public LoginViewModel LoginMember { get; set; }
        ICustomerRepository customerRepository { get; set; }
        public AddCustomer()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        public void Add()
        {
            var cus = new Customer();

            cus.CustomerId = Int32.Parse(txtCustomerID.Text);
            cus.CustomerName = txtCustomerName.Text;
            cus.Email = txtEmail.Text;
            cus.Birthday = DateTime.Parse(txtBirthday.Text);
            cus.Password = txtPassword.Text;
            cus.City = txtCity.Text;
            cus.Country = txtCountry.Text;

           

            customerRepository.AddCustomer(cus);
            MessageBox.Show("Add thanh cong");
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Add();
        }
    }
}
