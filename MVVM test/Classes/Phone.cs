using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.Classes
{
    class Phone
    {
        private string title { get; set; }
        public string Title
        {
            get { return title; }
            set 
            {
                title = value;
            }
        }

       
    }
}
