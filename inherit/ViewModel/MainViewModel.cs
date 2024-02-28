using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using inherit.Model;
using inherit.Service;
using System.Collections.ObjectModel;

namespace inherit.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ObservableCollection<ContentViewModels> ContentViewModels { get; set; } 
        public MainViewModel()
        {
            ContentViewModels = new ObservableCollection<ContentViewModels>()
            {
                new ContentViewModels(SimpleIoc.Default.GetInstance<User1ViewModel>(),"User1"),
                new ContentViewModels(SimpleIoc.Default.GetInstance<User2ViewModel>(),"User2"),
            };
        }
    }
}