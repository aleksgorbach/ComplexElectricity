// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:41

namespace ComplexElectricity.Dependencies.Initializing.Bootstrappers {
    #region References

    using CommonServiceLocator.NinjectAdapter.Unofficial;
    using Application;
    using UI.Drawings.Canvas;
    using Utils.Factories;
    using Microsoft.Practices.ServiceLocation;
    using Ninject;

    #endregion

    internal static class Bootstrapper {
        public static void Initialize() {
            var kernel = new StandardKernel();
            ServiceLocator.SetLocatorProvider(() => new NinjectServiceLocator(kernel));
            RegisterDependencies(kernel);
        }

        private static void RegisterDependencies(IKernel kernel) {
            kernel.Bind<IServiceLocator>().ToConstant(ServiceLocator.Current);
            kernel.Bind<IFactory<IApplication>>().To<Application.Factory>();
            kernel.Bind<IFactory<ICanvas>>().To<DrawingCanvas.Factory>();
            kernel.Bind<ICanvas>().To<DrawingCanvas>();
            kernel.Bind<IApplication>().To<Application>();
        }
    }
}