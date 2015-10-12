// Created 08.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 9:31

namespace ComplexElectricity {
    #region References

    using System.Windows;
    using Dependencies.Initializing.Bootstrappers;
    using Microsoft.Practices.ServiceLocation;

    #endregion

    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App {
        protected override void OnStartup(StartupEventArgs e) {
            Bootstrapper.Initialize();
            var window = ServiceLocator.Current.GetInstance<MainWindow>();
            window.Show();
            base.OnStartup(e);
        }
    }
}