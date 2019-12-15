﻿using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

namespace Task_Manager
{
    public class TaskICommand : ICommand
    {

        Action _TargetExecuteMethod;
        Func<bool> _TargetCanExecuteMethod;

        public TaskICommand(Action executeMethod)
        {
            _TargetExecuteMethod = executeMethod;
        }

        public TaskICommand(Action executeMethod, Func<bool> canExecuteMethod)
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

        // Prism commands solve this in their implementation 
        public event EventHandler CanExecuteChanged = delegate { };

        void ICommand.Execute(object parameter)
        {
            if (_TargetExecuteMethod != null)
            {
                _TargetExecuteMethod();
            }
        }

    }
}