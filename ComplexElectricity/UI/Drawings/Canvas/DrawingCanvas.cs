// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:33

namespace ComplexElectricity.UI.Drawings.Canvas {
    #region References

    using System.Windows.Controls;
    using Utils.Factories;
    using Microsoft.Practices.ServiceLocation;

    #endregion

    internal class DrawingCanvas : ICanvas {
        private Canvas _canvas;

        public void Init(Canvas canvas) {
            _canvas = canvas;
        }

        public void Add(IDrawable element) {
            throw new System.NotImplementedException();
        }

        public class Factory : Factory<ICanvas> {
            public Factory(IServiceLocator container)
                : base(container) {
            }
        }
    }
}