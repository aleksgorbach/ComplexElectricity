// Created 09.10.2015 
// Modified by Gorbach Alex 09.10.2015 at 15:19

namespace ComplexElectricity.Utils.Factories {
    public interface IFactory<out T> {
        T Build();
    }
}