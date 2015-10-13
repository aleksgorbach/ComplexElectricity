// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:45

namespace PresentationLayer.Models.Canvas.Context {
    #region References

    using Items;

    #endregion

    public interface IDrawingContext {
        void Draw(IDrawableCollection collection);
    }
}