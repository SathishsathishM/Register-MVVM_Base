using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMTask.ViewModel
{
    public class Eventcommad : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action _action;
        public Eventcommad(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object? parameter)
        {
           return true;
        }

    public void Execute(object? parameter)
       {
          _action.Invoke();
       }
       
    }
}
