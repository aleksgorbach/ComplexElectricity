using PresentationLayer.Models.Canvas.Context.Items;

namespace PresentationLayer.Models.Drawables.Electric {
    using Canvas.Context;
    using Input;

    interface IVisualElectricSystem {
        IDrawableCollection Drawables { get; }
        void HandleInput(InputEvent eventType, IInput input);
    }
}
