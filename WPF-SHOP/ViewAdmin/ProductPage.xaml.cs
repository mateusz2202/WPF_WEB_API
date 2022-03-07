using Flurl.Http;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_SHOP.Models;

namespace WPF_SHOP.ViewAdmin
{
    /// <summary>
    /// Logika interakcji dla klasy ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void BT_Click_Edit(object sender, RoutedEventArgs e)
        {

        }

        private async void BT_Click_Delete(object sender, RoutedEventArgs e)
        {
            var productInfo = DG_Products.SelectedItem as Product;
            var result = await $"https://localhost:7221/api/Product/info/{productInfo.Id}".DeleteAsync();
            if (result.StatusCode!=204) MessageBox.Show("Error delete");
            Refresh();
        }

        private void BT_Click_Refresh(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        private async void BT_Click_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                var product = new Product()
                {
                    Name = TB_Name.Text,
                    Description = TB_Description.Text,
                    Price = decimal.Parse(TB_Price.Text),
                    IsAvailable = CB_Avaibility.IsChecked.Value,
                    Warehouse = CB_Warehouse.Text,
                    Count = int.Parse(TB_Count.Text)
                };
                await "https://localhost:7221/api/Product/info".PostJsonAsync(product);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid data or error connection");
            }
            Refresh();
           
        }
        private async void Refresh()
        {
            var products=await "https://localhost:7221/api/Product/info".GetAsync().ReceiveJson<List<Product>>();
            DG_Products.ItemsSource = products;
        }
    }
}
