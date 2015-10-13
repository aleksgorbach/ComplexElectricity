// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 11:20

namespace PresentationLayer.App.Dependencies {
    #region References

    using Ninject.Modules;
    using Presenters.Main;

    #endregion

    public class PresentationModule : NinjectModule {
        public override void Load() {
            Bind<IMainPresenter>().To<MainPresenter>();
        }
    }
}