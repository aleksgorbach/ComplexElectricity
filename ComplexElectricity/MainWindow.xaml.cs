// Created 08.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:20

namespace ComplexElectricity {
    #region References

    using Application;
    using UI.Drawings.Canvas;
    using Utils.Factories;

    #endregion

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        private readonly IApplication _application;

        public MainWindow(IFactory<IApplication> appFactory, IFactory<ICanvas> canvasFactory) {
            InitializeComponent();
            var canvas = canvasFactory.Build();
            canvas.Init(Canvas);

            _application = appFactory.Build();
            _application.Init(canvas);
        }
    }
}