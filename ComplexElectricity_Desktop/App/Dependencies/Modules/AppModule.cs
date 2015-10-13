// Created 12.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 12:36

#region References

#endregion

namespace ElectricityDesktop.App.Dependencies.Modules {
    #region References

    using ElectricityDesktop.Views;
    using Ninject.Modules;
    using PresentationLayer.Views.Main;

    #endregion

    internal class AppModule : NinjectModule {
        public override void Load() {
            Bind<IMainView>().To<MainView>();
        }
    }
}