using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit.Service
{
    public class Manage : ViewModelBase
    {
        private string inheritText;
        public string InheritText 
        {
            get => inheritText;
            set
            {
                if (inheritText != value)
                {
                    inheritText = value;
                    RaisePropertyChanged(nameof(InheritText));
                }
            }
        }
        public ObservableCollection<string> List { get; private set; } = new ObservableCollection<string>();
        public Manage() { }
    }
}
