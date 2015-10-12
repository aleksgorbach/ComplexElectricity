// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 13:56

namespace ComplexElectricity_Desktop.Views {
    #region References

    using ComplexElectricity_Desktop.Models;

    #endregion

    internal interface IView<TViewModel>
        where TViewModel : IModel {
    }
}