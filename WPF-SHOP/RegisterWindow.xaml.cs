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
using System.Windows.Shapes;
using WPF_SHOP.Models;

namespace WPF_SHOP
{
    /// <summary>
    /// Logika interakcji dla klasy RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void BT_Click_SigIn(object sender, RoutedEventArgs e)
        {
            MainWindow z = new MainWindow()
            {
                WindowStartupLocation = WindowStartupLocation.CenterOwner,
            };
            z.Show();
            Close();
        }

        private async void BT_CLick_SignUp(object sender, RoutedEventArgs e)
        {
            var userDto = new UserRegister()
            {
                UserName=TB_Name.Text,
                LastName=TB_LastName.Text,
                Email=TB_Email.Text,
                Password=PB_Password.Password,
                ConfirmPassword=PB_ConfirmPassword.Password,
                RoleId=2
            };
            try
            {
                var result=await "https://localhost:7221/api/Account/register".AllowAnyHttpStatus().PostJsonAsync(userDto);
                if (result.StatusCode == 200)
                {
                    MessageBox.Show("Account registered");
                }
                else
                {
                    MessageBox.Show("Sorry :( something went wrong");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error connection");
            }

        }
    }
}
