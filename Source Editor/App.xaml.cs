using Source_Editor.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Source_Editor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        EditorViewModel _viewModel;
        MainWindow _window;

        void App_Startup(object sender, StartupEventArgs eventArgs)
        {
            _window = new MainWindow();
            _viewModel = new EditorViewModel();
            _window.DataContext = _viewModel;
            _window.Show();
        }
        public App()
        {
            Startup += App_Startup;
        }
    }
}
