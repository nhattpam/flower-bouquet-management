using DataAccess;
using DataAccess.Repository.FlowerBouquetRepo;
using Repository.OrderRepo;
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

namespace PhamMinhNhatWPF.OrderLayout
{
    /// <summary>
    /// Interaction logic for OrderManagement.xaml
    /// </summary>
    public partial class OrderManagement : Window
    {
        IOrderRepository orderRepository { get; set; }
        public LoginViewModel LoginMember { get; set; }
        public OrderManagement()
        {
            orderRepository = new OrderRepository();
            InitializeComponent();
        }

        void LoadData()
        {
            lvOrders.ItemsSource = List();
        }

        public IEnumerable<OrderViewModel> List()
        {
            var orders = orderRepository.GetOrdersList();

            var dtos = orders.Select(oo => new OrderViewModel()
            {
                OrderId = oo.OrderId,
                CustomerId = oo.CustomerId,
                OrderDate = oo.OrderDate,
                ShippedDate = oo.ShippedDate,
                Total = oo.Total,
                OrderStatus = oo.OrderStatus,
                Customer = oo.Customer
            }); ;

            return dtos;
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(LoginMember.CustomerName);
        }
    }
}
