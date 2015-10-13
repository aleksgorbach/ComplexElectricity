// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:31

namespace ElectricityDesktop.Views {
    #region References

    using System;
    using System.Windows.Forms;
    using Input;
    using PresentationLayer.Models.Canvas.Context;
    using PresentationLayer.Models.Canvas.Context.Items;
    using PresentationLayer.Models.Input;
    using PresentationLayer.Views.Main;

    #endregion

    public partial class MainView : Form, IMainView {
        public MainView() {
            InitializeComponent();
            Subscribe();
        }

        public void Repaint(IDrawableCollection items) {
            Console.WriteLine("repaint");
        }


        public new void Show() {
            Application.Run(this);
        }

        #region Initializing

        private void Subscribe() {
            _canvasPanel.MouseClick += (sender, args) => OnInputDetected(InputEvent.Click, new MouseInput(args));
        }

        #endregion

        #region Input

        public event Action<DrawingContextEventArgs> InputDetected;

        private void OnInputDetected(InputEvent eventType, IInput input) {
            InputDetected?.Invoke(new DrawingContextEventArgs(eventType, input));
        }

        #endregion
    }
}