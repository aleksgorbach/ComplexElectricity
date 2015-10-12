// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 15:11

namespace ComplexElectricity_Desktop.App.Dependencies {
    #region References

    using Ninject;

    #endregion

    internal class CompositionRoot : ICompositionRoot {
        private IKernel _kernel;

        public CompositionRoot(IKernel kernel) {
        }

        public TInterface Resolve<TInterface>() {
            return _kernel.Get<TInterface>();
        }
    }
}