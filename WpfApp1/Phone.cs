using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Phone : INotifyPropertyChanged
    {
        private string _title;
        private string _model;
        private int _price;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged("Title");
            }
        }

        public string Model { 
            get 
            { 
                return _model;
            }
            set 
            { 
                _model = value;
                OnPropertyChanged("Model");
            } 
        }

        public int Price {
            get { return _price; }
            set
            { 
                _price = value;
                OnPropertyChanged("Price");
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null) 
                PropertyChanged(this, new PropertyChangedEventArgs(prop)); 
        }
    }
}
