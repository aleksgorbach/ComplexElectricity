// Created 13.10.2015
// Modified by  13.10.2015 at 20:09

#region References

#endregion

namespace ElectricityDesktop {
    #region References

    using System;
    using System.Windows.Forms;
    using App.Dependencies;
    using App.Dependencies.Modules;
    using ComplexElectricityCore.App.Dependencies;
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
            CompositionRoot.Register(new CompositionRoot(new AppModule(), new PresentationModule(), new CoreModule()));
            var presenter = CompositionRoot.Current.Resolve<IMainPresenter>();
            presenter.Run();
        }
    }
}