// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:30

namespace PresentationLayer.Models.Drawables.Electric {
    #region References

    using System;
    using Canvas.Context;
    using Canvas.Context.Items;
    using ComplexElectricityCore.Models.ElectricSystems;
    using Input;

    #endregion

    internal class VisualElectricSystem : IVisualElectricSystem {
        private readonly IElectricSystem _system;

        public VisualElectricSystem(IElectricSystem system) {
            _system = system;
            Drawables = new DrawableCollection();
        }

        public IDrawableCollection Drawables { get; }

        public void HandleInput(InputEvent eventType, IInput input) {
            Console.WriteLine($"{eventType}: {input}");
        }
    }
}