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
    /// Interaction logic for MyCustomer.xaml
    /// </summary>
    public partial class MyCustomer : Window
    {
        public LoginViewModel LoginMember { get; set; }
        ICustomerRepository customerRepository { get; set; }
        public MyCustomer()
        {
            customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(LoginMember.CustomerId.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            var customer = customerRepository.GetCustomerById(LoginMember.CustomerId);

            //gan gia tri vo tung vo textbox
            txtCustomerID.Text = customer.CustomerId.ToString();
            txtCustomerName.Text = customer.CustomerName;
            txtCountry.Text = customer.Country;
            txtCity.Text = customer.City;
            txtEmail.Text = customer.Email;
            txtBirthday.Text = customer.Birthday.ToString();
        }
    }
}
