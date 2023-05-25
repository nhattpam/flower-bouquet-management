using BusinessObjects.Models;
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
    /// Interaction logic for MyOrder.xaml
    /// </summary>
    public partial class MyOrder : Window
    {
        public LoginViewModel LoginMember { get; set; }
        IOrderRepository orderRepository { get; set; }
        public MyOrder()
        {
            orderRepository = new OrderRepository();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        public IEnumerable<OrderViewModel> List()
        {
            var ordersByCus = orderRepository.GetOrders(LoginMember.CustomerId);

            var dtos = ordersByCus.Select(oo => new OrderViewModel()
            {
                OrderId = oo.OrderId,
                CustomerId = oo.CustomerId,
                OrderDate = oo.OrderDate,
                ShippedDate = oo.ShippedDate,
                Total = oo.Total,
                OrderStatus = oo.OrderStatus,
                Customer = oo.Customer
            });
            return dtos;
        }

        public void LoadData()
        {
            lvOrders.ItemsSource = List();
        }
        
    }
}
