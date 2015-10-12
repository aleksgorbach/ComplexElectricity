// Created 08.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 11:05

namespace ComplexElectricity {
    #region References

    using ViewModels.ElectricElements;

    #endregion

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public readonly IElectricElementsViewModel _model;

        public MainWindow(IElectricElementsViewModel model) {
            InitializeComponent();
            _model = model;
        }
    }
}