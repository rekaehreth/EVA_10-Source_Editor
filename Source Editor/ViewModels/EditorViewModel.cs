using System;
using System.Collections.Generic;
using System.Text;

namespace Source_Editor.ViewModels
{
    class EditorViewModel : ViewModelBase
    {
        // 
        public string CurrentText 
        {
            get
            {
                return CurrentText;
            }
            set
            {
                CurrentText = value;
                // A begépelt szöveget reprezentáló mezo setterében számítsuk ki és frissítsük a sorszámokat tartalmazó mezot!

                OnPropertyChanged();
            }
        }
        public string LineNumbers 
        {
            get
            { 
                return LineNumbers;
            }
            set 
            {
                LineNumbers = value;
                OnPropertyChanged();
            } 
        }
        public double FontSize 
        {
            get
            {
                return FontSize;
            }
            set
            {
                FontSize = value;
                OnPropertyChanged();
            }
        }
    }
}
