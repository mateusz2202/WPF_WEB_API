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
using System.IO;
using Microsoft.Web.WebView2.Core;
using Flurl.Http;
using WPF_SHOP.Models;

namespace WPF_SHOP.ViewUser
{
    /// <summary>
    /// Logika interakcji dla klasy ProducsView.xaml
    /// </summary>
    public partial class ProducsView : Page
    {
        public ProducsView()
        {
            InitializeComponent();
            InitWebView();
        }

        private async void InitWebView()
        {
            await webView.EnsureCoreWebView2Async();
           
           
        }       


    }
}
