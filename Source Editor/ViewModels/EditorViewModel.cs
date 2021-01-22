using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Source_Editor.Model;

namespace Source_Editor.ViewModels
{
    class EditorViewModel : ViewModelBase
    {
        private string _currentText;
        public string CurrentText 
        {
            get
            {
                return _currentText;
            }
            set
            {
                _currentText = value;
                LineNumbers = "";
                int lines = _currentText.Count(letter => letter == '\n') + 1;
                for (int i = 0; i < lines; ++i)
                {
                    LineNumbers += $"{i + 1}\n";
                }
                IsDirty = true;
                OnPropertyChanged();
            }
        }
        private string _lineNumbers;
        public string LineNumbers 
        {
            get
            { 
                return _lineNumbers;
            }
            set 
            {
                _lineNumbers = value;
                OnPropertyChanged();
            } 
        }
        private double _fontSize = 12;
        public double FontSize 
        {
            get
            {
                return _fontSize;
            }
            set
            {
                _fontSize = value;
                OnPropertyChanged();
            }
        }
        public bool IsDirty { get; set; }
        public DelegateCommand IncreaseText { get; set; }
        public DelegateCommand DecreaseText { get; set; }
        public DelegateCommand New { get; set; }
        public DelegateCommand Save { get; set; }
        public DelegateCommand Open { get; set; }
        public event EventHandler<FileOperationEventArgs> OpenFile;
        public event EventHandler<FileOperationEventArgs> SaveFile;
        public event EventHandler<FileOperationEventArgs> NewFile;
        public EditorViewModel()
        {
            IncreaseText = new DelegateCommand(_ => 
            { 
                ++FontSize; 
                OnPropertyChanged(); 
            });
            DecreaseText = new DelegateCommand(_ => 
            {
                if (FontSize > 1)
                {
                    --FontSize;
                    OnPropertyChanged();
                }
            });
            New = new DelegateCommand(_ => {
                if (IsDirty)
                {
                    string messageBoxText = "You have unsaved changes. Do you want to save?";
                    string caption = "Unsaved changes";
                    System.Windows.MessageBoxButton button = System.Windows.MessageBoxButton.YesNoCancel;
                    System.Windows.MessageBoxImage icon = System.Windows.MessageBoxImage.Warning;
                    System.Windows.MessageBoxResult result = System.Windows.MessageBox.Show(messageBoxText, caption, button, icon);
                    if (result == System.Windows.MessageBoxResult.Yes)
                    {
                        SaveFile?.Invoke(this, new FileOperationEventArgs(null, CurrentText, IsDirty));
                        IsDirty = false;
                        CurrentText = "";
                        LineNumbers = "";
                    }
                    else if (result == System.Windows.MessageBoxResult.No)
                    {
                        NewFile?.Invoke(this, null);
                    }
                }
            });
            Save = new DelegateCommand( _ => {
                if (IsDirty)
                {
                    SaveFile?.Invoke(this, new FileOperationEventArgs(null, CurrentText, IsDirty));
                    IsDirty = false;
                }

            });
            Open = new DelegateCommand( _ => {
                OpenFile?.Invoke(this, new FileOperationEventArgs(null, null, IsDirty));
            });
            
        }
        public void model_FileSaved(object sender, FileOperationEventArgs e)
        {
            IsDirty = false;
        }

        public void model_FileOpened(object sender, FileOperationEventArgs e)
        {
            IsDirty = false;
            CurrentText = e.fileContents;
        }
    }
}
