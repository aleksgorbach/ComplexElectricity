// Created 08.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:14

namespace ComplexElectricity.Application {
    #region References

    using System.Windows.Controls;
    using ComplexElectricity.UI.Drawings.Canvas;

    #endregion

    public interface IApplication {
        void Init(ICanvas canvas);
    }
}