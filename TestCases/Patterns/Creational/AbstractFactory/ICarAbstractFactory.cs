// //ICarAbstractFactory.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using TestCases.Patterns.Creational.AbstractFactory.ElectroCars;
using TestCases.Patterns.Creational.AbstractFactory.GasCars;

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public interface ICarAbstractFactory
    {
        ElectroCar BuildElectroCar(ElectroCar car);
        GasCar BuildGasCar(GasCar car);
    }
}