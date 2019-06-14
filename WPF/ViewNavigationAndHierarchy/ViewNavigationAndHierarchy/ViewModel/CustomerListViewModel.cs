using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewNavigationAndHierarchy.ViewModel
{
    public class CustomerListViewModel :ViewModelBase
    {
        public static string message { get; set; }
        public CustomerListViewModel()
        {
            message = "Count = 0";
        }
    }
}
