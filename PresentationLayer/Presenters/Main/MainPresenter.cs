// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:25

#region References

#endregion

namespace PresentationLayer.Presenters.Main {
    #region References

    using ComplexElectricityCore.Models.ElectricSystems;
    using Models.Canvas.Context;
    using Models.Drawables.Electric;
    using Models.Input;
    using Views.Main;

    #endregion

    #region References

    #endregion

    internal class MainPresenter : IMainPresenter {
        private readonly IVisualElectricSystem _electricSystem;
        private readonly IMainView _view;

        public MainPresenter(IMainView view, IElectricSystem electricSystem) {
            _view = view;
            _electricSystem = new VisualElectricSystem(electricSystem);
            _view.InputDetected += OnCanvasInput;
        }

        public void Run() {
            _view.Show();
        }

        private void OnCanvasInput(DrawingContextEventArgs eventArgs) {
            HandleInput(eventArgs.Event, eventArgs.InputArgs);
        }

        private void HandleInput(InputEvent eventType, IInput input) {
            //todo обработать - добавить или изменить фигуры
            _electricSystem.HandleInput(eventType, input);
            Repaint();
        }

        private void Repaint() {
            _view.Repaint(_electricSystem.Drawables);
        }
    }
}