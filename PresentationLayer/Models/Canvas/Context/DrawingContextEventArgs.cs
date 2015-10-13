// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 14:32

namespace PresentationLayer.Models.Canvas.Context {
    #region References

    using System;
    using Utils;

    #endregion

    public enum InputEvent {
        Press,
        Release,
        Move
    }

    public class DrawingContextEventArgs : EventArgs {
        public DrawingContextEventArgs(InputEvent eventType, Vector2 position)
            : base() {
            Event = eventType;
            Position = position;
        }

        public InputEvent Event { get; }
        public Vector2 Position { get; }
    }
}