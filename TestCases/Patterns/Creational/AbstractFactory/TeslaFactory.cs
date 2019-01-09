// //TeslaFactory.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars.Tesla;
using TestCases.Patterns.Creational.AbstractFactory.GasCars;

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public class TeslaFactory : ICarAbstractFactory
    {
        private ElectroCar GetCarModel(ModelS car) => new ModelS { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName.ToString() };
        private ElectroCar GetCarModel(Model3 car) => new Model3 { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName.ToString() };
        public ElectroCar BuildElectroCar(ElectroCar car)
        {
            return GetCarModel((dynamic)car);
        }



        public GasCar BuildGasCar(GasCar car)
        {
            throw new System.NotImplementedException();
        }
    }
}