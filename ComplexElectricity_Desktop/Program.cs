// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 14:29

#region References

using System;
using System.Windows.Forms;

#endregion

namespace ComplexElectricity_Desktop {
    #region References

    using Views;

    #endregion

    internal static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}