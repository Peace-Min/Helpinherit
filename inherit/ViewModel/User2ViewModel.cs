﻿using inherit.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace inherit.ViewModel
{
    public class User2ViewModel : User1ViewModel , IViewModel
    {
        
        public User2ViewModel() 
        {
            Task.Run(() =>
            {
                while(true)
                {
                    Application.Current.Dispatcher.Invoke(() =>
                    {
                        var a = InheritText;
                        Task.Delay(5000);
                    });
                }
            });
        }
    }
}
