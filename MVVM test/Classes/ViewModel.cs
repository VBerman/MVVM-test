using MVVM_test.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_test.Classes
{
    public class ViewModel
    {
        
     
        private static ApplicationViewModel instance;

        public ViewModel()
        {

        }


        internal static ApplicationViewModel Instance
        {
            get
            {
                instance = instance ?? new ApplicationViewModel();
                return instance;
            }

        }




    }

}
