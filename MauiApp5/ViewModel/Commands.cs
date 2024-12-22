using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp5.VievModel
{
    internal class Commands : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        Action _viewModelAction;

        public Commands(Action viewModelAction)
        {
            _viewModelAction = viewModelAction;
        }


        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _viewModelAction();
        }
    }
}
