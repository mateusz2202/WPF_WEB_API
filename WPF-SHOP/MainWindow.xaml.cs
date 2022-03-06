﻿using System;
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

        private void BT_Click_SigIn(object sender, RoutedEventArgs e)
        {
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
