using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Moksliukas.Core.Models;
using Moksliukas.Core.ViewModels;
using Moksliukas.WPF.Views;

namespace Moksliukas.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            _ = new Core.App();
            base.OnStartup(e);

            MainWindowView window = new MainWindowView();
            MainViewModel MainVM = new MainViewModel();
            window.DataContext = MainVM;
            window.Show();
        }

    }

}
