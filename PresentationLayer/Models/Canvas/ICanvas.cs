// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 12:35

namespace PresentationLayer.Models.Canvas {
    #region References

    using Context;

    #endregion

    public interface ICanvas {
        void Draw(IDrawingContext context);
    }
}