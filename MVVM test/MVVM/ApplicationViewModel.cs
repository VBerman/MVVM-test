using MVVM_test.Classes;
using MVVM_test.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.MVVM
{
    class ApplicationViewModel
    {
        public ObservableCollection<Phone> Phones { get; set; }
        public ApplicationViewModel()
        {
            Phones = new ObservableCollection<Phone>() 
            {
                new Phone(){Title="Check0"},
                new Phone(){Title="Check1"},
                new Phone(){Title="Check2"},
                new Phone(){Title="Check3"}
            };

            Assets = new ObservableCollection<Asset> (DB.Instance.Assets.ToList());
            
        }
        public ObservableCollection<Asset> Assets { get; set; }
        

    }
}
