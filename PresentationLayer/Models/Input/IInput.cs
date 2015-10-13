// Created 13.10.2015
// Modified by Александр 13.10.2015 at 20:27

namespace PresentationLayer.Models.Input {
    #region References

    using Utils;

    #endregion

    public interface IInput {
        IVector2 Position { get; }
    }
}