// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 15:35

namespace ComplexElectricity_Desktop.App.Dependencies {
    #region References

    using Ninject;
    using Ninject.Modules;

    #endregion

    internal class CompositionRoot : ICompositionRoot {
        private readonly IKernel _kernel;

        public CompositionRoot(params INinjectModule[] modules) {
            _kernel = new StandardKernel(modules);
        }

        public static ICompositionRoot Current { get; private set; }

        public TInterface Resolve<TInterface>() {
            return _kernel.Get<TInterface>();
        }

        public static void Register(ICompositionRoot compositionRoot) {
            Current = compositionRoot;
        }
    }
}