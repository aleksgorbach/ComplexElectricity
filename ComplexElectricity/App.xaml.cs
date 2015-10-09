// Created 08.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:24

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
            base.OnStartup(e);
            Bootstrapper.Initialize();
            var window = ServiceLocator.Current.GetInstance<MainWindow>();
            window.Show();
        }
    }
}