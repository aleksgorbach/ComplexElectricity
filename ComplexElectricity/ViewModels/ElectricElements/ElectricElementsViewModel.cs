// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 10:56

namespace ComplexElectricity.ViewModels.ElectricElements {
    #region References

    using System.Collections.ObjectModel;

    #endregion

    internal class ElectricElementsViewModel : IElectricElementsViewModel {
        public ObservableCollection<IElectricElementViewModel> Elements { get; set; }
    }
}