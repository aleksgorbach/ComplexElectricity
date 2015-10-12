// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 15:35

#region References

using System;
using System.Windows.Forms;
using ComplexElectricity_Desktop.Views.Main;

#endregion

namespace ComplexElectricity_Desktop {
    #region References

    using App.Dependencies;
    using App.Dependencies.Modules;

    #endregion

    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CompositionRoot.Register(new CompositionRoot(new AppModule()));
            Application.Run(CompositionRoot.Current.Resolve<MainView>());
        }
    }
}