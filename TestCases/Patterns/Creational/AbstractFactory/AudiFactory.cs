// //AudiFactory.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars;
using TestCases.Patterns.Creational.AbstractFactory.GasCars;
using TestCases.Patterns.Creational.AbstractFactory.GasCars.Audi;

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public class AudiFactory : ICarAbstractFactory
    {
        private GasCar GetCarModel(AudiA8 car) => new AudiA8 { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName };
        public ElectroCar BuildElectroCar(ElectroCar car)
        {
            return null;
        }

        public GasCar BuildGasCar(GasCar car)
        {
            return GetCarModel((dynamic)car);
        }
    }
}