// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 10:40

namespace ComplexElectricity.Application.Notifiers {
    #region References

    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Annotations;

    #endregion

    internal class Notifier : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}