using PhamMinhNhatWPF.CustomerLayout;
using PhamMinhNhatWPF.OrderLayout;
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

namespace PhamMinhNhatWPF
{
    /// <summary>
    /// Interaction logic for CustomerScreen.xaml
    /// </summary>
    public partial class CustomerScreen : Window
    {
        public LoginViewModel LoginMember { get; set; }
        public CustomerScreen()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MyCustomer mv = new MyCustomer() 
            {
                LoginMember = LoginMember
            };
            mv.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyOrder mo = new MyOrder() 
            {
                LoginMember = LoginMember
            };
            mo.ShowDialog();
        }
    }
}
