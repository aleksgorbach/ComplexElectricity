// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:44

namespace PresentationLayer.Models.Canvas.Context.Items {
    #region References

    using System.Collections.Generic;
    using Drawables;

    #endregion

    internal class DrawableCollection : IDrawableCollection {
        public IEnumerable<IDrawable> Items { get; }
    }
}