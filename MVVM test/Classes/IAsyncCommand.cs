using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_test.Classes
{
    interface IAsyncCommand : ICommand
    {
        public Task ExecuteAsync(object parameter);
    
   
    }
}
