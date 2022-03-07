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
            var productInfo = DG_Products.SelectedItem as Product;          
            
            TB_Name.Text = productInfo.Name;
            TB_Description.Text= productInfo.Description;
            TB_Price.Text = productInfo.Price.ToString();
            CB_Avaibility.IsChecked = productInfo.IsAvailable;
            TB_Count.Text=productInfo.Count.ToString();            
            var item = CB_Warehouse.Items.OfType<ComboBoxItem>().FirstOrDefault(x => x.Content.ToString() == productInfo.Warehouse);
            CB_Warehouse.SelectedIndex = CB_Warehouse.Items.IndexOf(item);
            TB_Name.IsReadOnly = true;
            TB_Description.IsReadOnly = true;
            TB_Price.IsReadOnly = true;     
            CB_Avaibility.IsHitTestVisible = false;
            L_NameAction.Content = "Edit";
            BT_NameAction.Content = "Update";
            BT_NameAction.Click -= BT_Click_Add;
            BT_NameAction.Click += EditProductInfoAsync;   
            _updateId=productInfo.Id;
        }
        private int _updateId;

        private async void EditProductInfoAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                var product = new ProductUpdate()
                {
                    Warehouse = CB_Warehouse.Text,
                    Count = int.Parse(TB_Count.Text)
                };
                await $"https://localhost:7221/api/Product/info/{_updateId}".PutJsonAsync(product);
            }
            catch (Exception)
            {

                MessageBox.Show("Invalid data or error connection");
            }
            Refresh();
            TB_Name.Text = string.Empty;
            TB_Description.Text = string.Empty;
            TB_Price.Text = string.Empty;
            CB_Avaibility.IsChecked = true;
            TB_Count.Text = string.Empty;
            CB_Avaibility.IsHitTestVisible = true;
            CB_Warehouse.SelectedItem = CB_Warehouse.Items[0];
            BT_NameAction.Content = "Add";
            L_NameAction.Content="Add";
            BT_NameAction.Click -= EditProductInfoAsync;
            BT_NameAction.Click += BT_Click_Add;
        }

        private async void BT_Click_Delete(object sender, RoutedEventArgs e)
        {
            var productInfo = DG_Products.SelectedItem as Product;
            var result = await $"https://localhost:7221/api/Product/info/{productInfo?.Id}".DeleteAsync();
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
