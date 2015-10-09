// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:15

namespace ComplexElectricity.UI.Drawings.Canvas {
    #region References

    using System.Windows.Controls;

    #endregion

    public interface ICanvas {
        void Init(Canvas canvas);

        void Add(IDrawable element);
    }
}