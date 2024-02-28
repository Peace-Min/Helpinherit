using inherit.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inherit.Model
{
    public class ContentViewModels
    {
        public IViewModel ViewModel { get; set; }
        public string Name { get; set; }

        public ContentViewModels(IViewModel vm,string name) 
        {
            this.ViewModel = vm;
            this.Name = name;
        }
    }
}
