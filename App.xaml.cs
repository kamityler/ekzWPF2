using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ekz2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var contex = new ViewModel.CodeViewModel();
            var window = new Window1() { DataContext = contex };
            window.Show();
        }
    }
}
