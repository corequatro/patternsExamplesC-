// //AudiFactory.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars.Audi;
using TestCases.Patterns.Creational.AbstractFactory.GasCars;
using TestCases.Patterns.Creational.AbstractFactory.GasCars.Audi;

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public class AudiFactory : ICarAbstractFactory
    {
        private GasCar GetCarModel(AudiA8Scheme car) => new AudiA8 { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName };
        private ElectroCar GetCarModel(AudiEtronScheme car) => new AudiEtron { CarId = Guid.NewGuid(), CarModel = car.GetType().FullName };

        public ElectroCar BuildElectroCar(ElectroCarScheme car)
        {
            return Helper.DefineCarBuildMethod<AudiFactory, ElectroCar, ElectroCarScheme>(car, nameof(GetCarModel), this);
        }

        public GasCar BuildGasCar(GasCarScheme car)
        {
            return Helper.DefineCarBuildMethod<AudiFactory, GasCar, GasCarScheme>(car, nameof(GetCarModel), this);
        }



    }
}