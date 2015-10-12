// Created 12.10.2015 
// Modified by Gorbach Alex 12.10.2015 at 13:56

namespace ComplexElectricity_Desktop.Views {
    #region References

    using System.Windows.Forms;
    using Models;

    #endregion

    public partial class MainView : Form, IView<MainViewModel> {
        public MainView() {
            InitializeComponent();
        }
    }
}