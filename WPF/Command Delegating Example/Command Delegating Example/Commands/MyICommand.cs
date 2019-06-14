using System;
using System.Windows.Input;

namespace Command_Delegating_Example.Commands
{
    public class MyICommand : ICommand
    {
        Func<bool> _TargetCanExecuteMethod;
        Action _TargetExecuteMethod;
        
        public MyICommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public MyICommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _TargetExecuteMethod = executeMethod;
            _TargetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        bool ICommand.CanExecute(object parameter)
        {

            if (_TargetCanExecuteMethod != null)
            {
                return _TargetCanExecuteMethod();
            }

            if (_TargetExecuteMethod != null)
            {
                return true;
            }

            return false;
        }


        public event EventHandler CanExecuteChanged;

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }
    }

}
