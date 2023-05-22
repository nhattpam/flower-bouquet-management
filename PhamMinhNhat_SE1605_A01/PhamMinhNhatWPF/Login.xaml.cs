using BusinessObjects.Models;
using Repository.CustomerRepo;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace PhamMinhNhatWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        ICustomerRepository customerRepository { get; set; }
        public Login()
        {
            customerRepository= new CustomerRepository();
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            var customer = customerRepository.Login(txtEmail.Text, txtPassword.Text);

            if (customer != null)
            {
                var dto = new LoginViewModel()
                {
                    CustomerName = customer.CustomerName,
                    Email = customer.Email,
                    Password = customer.Password
                };

                if (dto.CustomerName.Equals("Admin"))
                {
                    AdminScreen adminScreen = new AdminScreen() 
                    {
                        LoginMember = dto
                    };
                    adminScreen.ShowDialog();
                }
                else
                {
                    MessageBox.Show(dto.CustomerName);
                }
            }
            else
            {
                MessageBox.Show("KHONG TIM THAY");
            }

        }

    }
}
