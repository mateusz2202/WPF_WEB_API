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
using WPF_SHOP.ViewAdmin;

namespace WPF_SHOP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BT_Click_SigIn(object sender, RoutedEventArgs e)
        {
            var user = new User()
            {
                Login = TB_Login.Text,
                Password = PB_Password.Password
            };
            try
            {
                var loginResult = await "https://localhost:7221/api/account/login".AllowAnyHttpStatus().PostJsonAsync(user);
                if (loginResult.StatusCode == 200)
                {
                    var token = await loginResult.ResponseMessage.Content.ReadAsStringAsync();
                    
                    MessageBox.Show(token);
                }
                else
                {
                    MessageBox.Show("Invalid login or password");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error connection");
            }
            
            
            IndexAdmin z = new IndexAdmin
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
                WindowState = WindowState.Maximized
            };
            z.Show();           
            this.Close();
        }

        private void BT_CLick_SignUp(object sender, RoutedEventArgs e)
        {
            RegisterWindow z = new RegisterWindow()
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner
            };
            z.Show();
            this.Close();
        }
    }
}
