// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 15:00

namespace PresentationLayer.Presenters.Main {
    #region References

    using ComplexElectricityCore.Models.ElectricSystems;
    using Models.Canvas.Context;
    using Utils;
    using Views.Main;

    #endregion

    internal class MainPresenter : IMainPresenter {
        private readonly IMainView _view;
        private readonly IElectricSystem _electricSystem;

        public MainPresenter(IMainView view, IElectricSystem electricSystem) {
            _view = view;
            _electricSystem = electricSystem;
            _view.InputDetected += OnCanvasInput;
        }

        public void Run() {
            _view.Show();
        }

        private void OnCanvasInput(DrawingContextEventArgs eventArgs) {
            HandleInput(eventArgs.Event, eventArgs.Position);
        }

        private void HandleInput(InputEvent eventType, Vector2 position) {
            //todo обработать - добавить или изменить фигуры
            Repaint();
        }

        private void Repaint() {
            _view.Repaint(_electricSystem.VisualElements);
        }
    }
}