using Source_Editor.Model;
using Source_Editor.Persistance;
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
        EditorModel _model;
        void App_Startup(object sender, StartupEventArgs eventArgs)
        {
            _window = new MainWindow();
            _viewModel = new EditorViewModel();
            // **TODO** initialize persistence (or create new instance in ctor call)
            _model = new EditorModel(new FilePersistence());
            _model.FileOpened += _viewModel.model_FileOpened;
            _model.FileSaved += _viewModel.model_FileSaved;

            _viewModel.OpenFile += viewModel_OpenFile;
            _viewModel.SaveFile += viewModel_SaveFile;
            _viewModel.NewFile += _viewModel_NewFile;

            _window.DataContext = _viewModel;
            _window.Show();
        }
        private void _viewModel_NewFile(object sender, FileOperationEventArgs e)
        {
            _model.NewFile();
        }
        private async void viewModel_SaveFile(object sender, FileOperationEventArgs e)
        {
            if (e.IsDirty)
            {
                string path = null;
                if(_model.pathAvailable())
                {
                    path = e.path;
                }
                else
                {
                    System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
                    saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    saveFileDialog.RestoreDirectory = true;
                    if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        path = saveFileDialog.FileName;
                    }
                }
                await _model.SaveFileAsync(e.fileContents, e.IsDirty, path);
                _viewModel.IsDirty = false;
            }
        }
        private async void viewModel_OpenFile(object sender, FileOperationEventArgs e)
        {
            string path = null;
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            if(openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog.FileName;
                await _model.LoadFileAsync(path, e.IsDirty);
            }
        }
        public App()
        {
            Startup += App_Startup;
        }
    }
}
