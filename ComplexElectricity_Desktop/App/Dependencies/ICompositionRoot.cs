// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 14:33

namespace ComplexElectricity_Desktop.App.Dependencies {
    internal interface ICompositionRoot {
        TInterface Resolve<TInterface>();
    }
}