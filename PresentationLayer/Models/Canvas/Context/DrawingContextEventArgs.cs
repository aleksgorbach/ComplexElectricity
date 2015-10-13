// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:11

namespace PresentationLayer.Models.Canvas.Context {
    #region References

    using System;
    using Input;

    #endregion

    public enum InputEvent {
        Press,
        Release,
        Move,
        Click
    }

    public class DrawingContextEventArgs : EventArgs {
        public DrawingContextEventArgs(InputEvent eventType, IInput inputArgs) {
            Event = eventType;
            InputArgs = inputArgs;
        }

        public InputEvent Event { get; }
        public IInput InputArgs { get; }
    }
}