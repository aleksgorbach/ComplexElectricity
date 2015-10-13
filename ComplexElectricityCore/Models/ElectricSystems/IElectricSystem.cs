// Created 13.10.2015 
// Modified by Gorbach Alex 13.10.2015 at 15:05

namespace ComplexElectricityCore.Models.ElectricSystems {
    #region References

    using System.Collections.Generic;
    using Elements;

    #endregion

    public interface IElectricSystem {
        IEnumerable<IElectricElement> VisualElements { get; }
    }
}