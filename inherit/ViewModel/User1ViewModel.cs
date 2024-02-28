using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using inherit.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace inherit.ViewModel
{
    public class User1ViewModel : ViewModelBase, IViewModel
    {
        private string inheritText;
        public  string InheritText
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
        public ICommand ButtonCmd => new RelayCommand(ButtonFunc);
        public ObservableCollection<string> List { get; set; }
        private void ButtonFunc()
        {
            inheritText = "Button Click";
            List = new ObservableCollection<string>()
            {
                "CCCC","BBBBB","AAAA",
            };
        }
        public User1ViewModel() 
        {
            List = new ObservableCollection<string>()
            {
                "AAAAAA","BBBBB","CCCC",
            };

            inheritText = "Hello World";
        }
    }
}
