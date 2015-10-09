// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 14:51

namespace ComplexElectricity.Utils.Factories {
    #region References

    using Microsoft.Practices.ServiceLocation;

    #endregion

    internal abstract class Factory<T> : IFactory<T> {
        private readonly IServiceLocator _container;

        protected Factory(IServiceLocator container) {
            _container = container;
        }

        public virtual T Build() {
            return _container.GetInstance<T>();
        }
    }
}