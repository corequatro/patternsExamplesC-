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
        private ElectroCar GetCarModel(ModelSScheme car) => new ModelS { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName };
        private ElectroCar GetCarModel(Model3Scheme car) => new Model3 { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName };
       
        public ElectroCar BuildElectroCar(ElectroCarScheme car)
        {
            return Helper.DefineCarBuildMethod<TeslaFactory, ElectroCar, ElectroCarScheme>(car, nameof(GetCarModel), this);
        }

        public GasCar BuildGasCar(GasCarScheme car)
        {
            throw new NotImplementedException();
        }
    }
}