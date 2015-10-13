// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:28

namespace PresentationLayer.Models.Canvas.Context.Items {
    #region References

    using System.Collections.Generic;
    using Drawables;

    #endregion

    internal class DrawableCollection : IDrawableCollection {
        private readonly IList<IDrawable> _items;

        public DrawableCollection() {
            _items = new List<IDrawable>();
        }

        public IEnumerable<IDrawable> Items => _items;
    }
}