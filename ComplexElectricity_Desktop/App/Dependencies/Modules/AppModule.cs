// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 15:39

using ComplexElectricity_Desktop.Views.Main;

namespace ComplexElectricity_Desktop.App.Dependencies.Modules {
    #region References

    using Ninject.Modules;

    #endregion

    internal class AppModule : NinjectModule {
        public override void Load() {
            Bind<IMainView>().To<MainView>();
        }
    }
}