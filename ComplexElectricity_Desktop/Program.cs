// Created 12.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 12:36

#region References

#endregion

namespace ElectricityDesktop {
    #region References

    using System;
    using System.Windows.Forms;
    using ElectricityDesktop.App.Dependencies;
    using ElectricityDesktop.App.Dependencies.Modules;
    using PresentationLayer.App.Dependencies;
    using PresentationLayer.Presenters.Main;

    #endregion

    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CompositionRoot.Register(new CompositionRoot(new AppModule(), new PresentationModule()));
            var presenter = CompositionRoot.Current.Resolve<IMainPresenter>();
            presenter.Run();
        }
    }
}