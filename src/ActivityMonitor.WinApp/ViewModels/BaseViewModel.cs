using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ActivityMonitor.WinApp.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly PropertyChangedEventArgsCache _PropertyChangedEventArgsCache = new();

        protected void SetProperty<T>(ref T backingstore, T value, [CallerMemberName] string propertyName = null)
        {
            if (object.Equals(backingstore, value))
            {
                return;
            }

            backingstore = value;
            PropertyChanged?.Invoke(this, _PropertyChangedEventArgsCache.Get(propertyName));
        }

    }
}
