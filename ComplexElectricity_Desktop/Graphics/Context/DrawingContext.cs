// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:47

namespace ElectricityDesktop.Graphics.Context {
    #region References

    using System;

    #region References

    using System.Drawing;
    using PresentationLayer.Models.Canvas.Context;
    using PresentationLayer.Models.Canvas.Context.Items;

    #endregion

    #endregion

    internal class DrawingContext : IDrawingContext {
        private readonly Graphics _graphics;

        public DrawingContext(Graphics g) {
            _graphics = g;
        }

        public void Draw(IDrawableCollection collection) {
            throw new NotImplementedException();
        }
    }
}