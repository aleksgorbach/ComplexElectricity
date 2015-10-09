// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 13:59

namespace ComplexElectricity.UI.Properties.Items {
    #region References

    using ValueEditors;

    #endregion

    internal interface IPropertyItem {
        IPropertyValueEditor ValueEditor { get; }
    }
}