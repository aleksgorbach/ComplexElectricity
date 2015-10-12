// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 15:39

namespace ComplexElectricity_Desktop.App.Dependencies.Modules {
    #region References

    using ComplexElectricity_Desktop.Models;
    using Views;
    using Ninject.Modules;

    #endregion

    internal class AppModule : NinjectModule {
        public override void Load() {
            Bind<MainViewModel>().ToSelf();
            Bind<MainView>().ToSelf();
        }
    }
}