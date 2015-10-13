// Created 13.10.2015
// Modified by  13.10.2015 at 20:07

namespace ComplexElectricityCore.App.Dependencies {
    #region References

    using Models.ElectricSystems;
    using Ninject.Modules;

    #endregion

    public class CoreModule : NinjectModule {
        public override void Load() {
            Bind<IElectricSystem>().To<ElectricSystem>();
        }
    }
}