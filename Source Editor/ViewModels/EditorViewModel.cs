using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
                // A begépelt szöveget reprezentáló mezo setterében számítsuk ki és frissítsük a sorszámokat tartalmazó mezot!
                LineNumbers = "";
                int lines = _currentText.Count(letter => letter == '\n');
                for (int i = 0; i < lines; ++i)
                {
                    LineNumbers += $"{i + 1}\n";
                }
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
        private double _fontSize;
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
    }
}
