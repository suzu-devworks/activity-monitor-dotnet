using System;

namespace ActivityMonitor.WinApp.ViewModels
{
    public interface ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter);

        public void Execute(object parameter);

    }
}
