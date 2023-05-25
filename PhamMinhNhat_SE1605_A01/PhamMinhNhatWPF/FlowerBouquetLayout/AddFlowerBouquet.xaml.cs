using BusinessObjects.Models;
using DataAccess.Repository.FlowerBouquetRepo;
using Repository.CategoryRepo;
using Repository.SupplierRepo;
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

namespace PhamMinhNhatWPF.FlowerBouquetLayout
{
    /// <summary>
    /// Interaction logic for AddFlowerBouquet.xaml
    /// </summary>
    public partial class AddFlowerBouquet : Window
    {
        public LoginViewModel LoginMember { get; set; }
        ICategoryRepository categoryRepository { get; set; }
        ISupplierRepository supplierRepository { get; set; }
        IFlowerBouquetRepository flowerBouquetRepository { get; set; }
        public AddFlowerBouquet()
        {
            supplierRepository = new SupplierRepository();
            categoryRepository= new CategoryRepository();
            flowerBouquetRepository = new FlowerBouquetRepository();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            IEnumerable<Category> categories;
            try
            {
                categories = categoryRepository.GetCategoryList();
                foreach (var item in categories)
                {
                    cbCategoryID.Items.Add(item.CategoryName);

                }
                //cbCategoryID.ItemsSource = categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            //load supplier name
            IEnumerable<Supplier> suppliers;
            try
            {
                suppliers = supplierRepository.GetSupplierList();
                foreach (var item in suppliers)
                {
                    cbSupplierId.Items.Add(item.SupplierName);

                }
                //cbCategoryID.ItemsSource = categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Category category = categoryRepository.GetCategory(cbCategoryID.Text);
            Supplier supplier = supplierRepository.GetSupplier(cbSupplierId.Text);
            FlowerBouquet flowerBouquet = new FlowerBouquet()
            {
                FlowerBouquetId = Int32.Parse(txtFlowerBouquetID.Text),
                FlowerBouquetName = txtFlowerBouquetName.Text,
                Description = txtDescription.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                UnitsInStock = int.Parse(txtUnitsInStock.Text),
                FlowerBouquetStatus = byte.Parse(txtStatus.Text),
                CategoryId = category.CategoryId,
                SupplierId = supplier.SupplierId
            };

            flowerBouquetRepository.AddFlowerBouquet(flowerBouquet);
            MessageBox.Show("Add successfully!!", "Add new Product", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
