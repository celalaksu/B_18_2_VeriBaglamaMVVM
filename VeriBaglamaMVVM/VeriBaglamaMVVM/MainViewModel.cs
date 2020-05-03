using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VeriBaglamaMVVM
{
    public class MainViewModel : INotifyPropertyChanged
    {
        string isim = string.Empty;
        public string Isim
        {
            get => isim;
            set
            {
                if (isim == value)
                {
                    return;
                }

                isim = value;
                OnPropertyChanged(nameof(isim));
                OnPropertyChanged(nameof(IsmiGoster));
            }
        }

        public string IsmiGoster => $"Name Entered: {Isim}";

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
