// Created 13.10.2015
// Modified by Александр 13.10.2015 at 21:13

namespace ComplexElectricityCore.Models.ElectricSystems {
    #region References

    using System.Collections.Generic;
    using Elements;

    #endregion

    internal class ElectricSystem : IElectricSystem {
        private readonly IList<IElectricElement> _elements;

        public ElectricSystem() {
            _elements = new List<IElectricElement>();
        }

        public IEnumerable<IElectricElement> VisualElements => _elements;
    }
}