﻿using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _open;

        public DelegateCommand(Action<object> open) 
        {
            _open = open;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _open?.Invoke(parameter);
        }
    }
}