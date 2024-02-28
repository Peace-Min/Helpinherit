using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using inherit.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace inherit.ViewModel
{
    public class User1ViewModel : ViewModelBase, IViewModel
    {
        public ICommand ButtonCmd => new RelayCommand(ButtonFunc);
        public Manage Manage {  get; set; }

        private void ButtonFunc()
        {
            Manage.InheritText = "Button Click";
            Manage.List.Clear();
            Manage.List.Add("AAA");
        }
        public User1ViewModel() 
        {
            Manage  = SimpleIoc.Default.GetInstance<Manage>();
            Manage.InheritText = "Hello World";
            Manage.List.Clear();
            Manage.List.Add("BBB");
        }
    }
}
