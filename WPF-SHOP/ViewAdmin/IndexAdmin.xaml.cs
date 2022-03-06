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

namespace WPF_SHOP.ViewAdmin
{
    /// <summary>
    /// Logika interakcji dla klasy IndexAdmin.xaml
    /// </summary>
    public partial class IndexAdmin : Window
    {
        private readonly string _token;
        public IndexAdmin(string token)
        {
            InitializeComponent();
            _token = token;
        }

        private void BT_Click_LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow z = new MainWindow() { WindowStartupLocation = WindowStartupLocation.CenterOwner };
            z.Show();
            Close();
        }

        private void BT_Click_Products(object sender, RoutedEventArgs e)
        {
            AdminMain.Content = new ProductPage().Content;
        }
    }
}
