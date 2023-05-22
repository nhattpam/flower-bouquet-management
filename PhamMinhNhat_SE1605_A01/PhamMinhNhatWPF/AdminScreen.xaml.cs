using BusinessObjects.Models;
using PhamMinhNhatWPF.CustomerLayout;
using PhamMinhNhatWPF.FlowerBouquetWPF;
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
    /// Interaction logic for AdminScreen.xaml
    /// </summary>
    public partial class AdminScreen : Window
    {
        public LoginViewModel LoginMember { get; set; }
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlowerBouquetManagement flowerBouquetManagement = new FlowerBouquetManagement() 
            {
                LoginMember = LoginMember
            };
            flowerBouquetManagement.ShowDialog();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomerManagement flowerBouquetManagement = new CustomerManagement()
            {
                LoginMember = LoginMember
            };
            flowerBouquetManagement.ShowDialog();
        }
    }
}
