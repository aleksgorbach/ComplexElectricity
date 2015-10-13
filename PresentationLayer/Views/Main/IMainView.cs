// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:48

namespace PresentationLayer.Views.Main {
    #region References

    using System;
    using Models.Canvas.Context;
    using PresentationLayer.Models.Canvas.Context.Items;

    #endregion

    #region References

    #endregion

    public interface IMainView : IView {
        void Repaint(IDrawableCollection items);

        event Action<DrawingContextEventArgs> InputDetected;
    }
}