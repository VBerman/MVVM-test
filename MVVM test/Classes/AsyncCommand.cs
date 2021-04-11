using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_test.Classes
{
    class AsyncCommand : IAsyncCommand
    {
        private Func<object, Task> execute;

        public AsyncCommand(Func<object, Task> execute)
        {
            this.execute = execute;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ExecuteAsync(parameter);
        }

        public Task ExecuteAsync(object parameter) 
        {
            return execute(parameter);
            //new AsyncCommand<Dictionary<String, String>>(async parameter => await DB.Instance.SaveChangesAsync());
        }


    }


}
