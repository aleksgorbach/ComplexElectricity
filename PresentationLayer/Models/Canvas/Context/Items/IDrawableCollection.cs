// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:45

namespace PresentationLayer.Models.Canvas.Context.Items {
    #region References

    using System.Collections.Generic;
    using PresentationLayer.Models.Drawables;

    #endregion

    public interface IDrawableCollection {
        IEnumerable<IDrawable> Items { get; }
    }
}