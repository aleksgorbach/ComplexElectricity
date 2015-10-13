// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:09

namespace ElectricityDesktop.Input {
    #region References

    using System.Windows.Forms;
    using PresentationLayer.Models.Input;
    using PresentationLayer.Utils;

    #endregion

    internal class MouseInput : IMouseInput {
        public MouseInput(MouseEventArgs args) {
            Position = new Vector2(args.X, args.Y);
        }

        public IVector2 Position { get; }
    }
}