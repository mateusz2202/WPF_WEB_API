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

namespace WPF_SHOP.ViewUser
{
    /// <summary>
    /// Logika interakcji dla klasy IndexUser.xaml
    /// </summary>
    public partial class IndexUser : Window
    {
        public IndexUser()
        {
            InitializeComponent();
        }

        private void BT_Click_LogOut(object sender, RoutedEventArgs e)
        {
            MainWindow z=new MainWindow() { WindowStartupLocation = WindowStartupLocation.CenterOwner };
            z.Show();
            this.Close();
        }
    }
}
