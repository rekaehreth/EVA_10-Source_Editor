using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Source_Editor.ViewModels
{
    class DelegateCommand : ICommand
    {
        private readonly Action<Object> _execute;
        private readonly Func<Object, Boolean> _canExecute;
        public event EventHandler CanExecuteChanged;
        public DelegateCommand(Action<Object> execute, Func<Object, Boolean> canExecute = null)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
