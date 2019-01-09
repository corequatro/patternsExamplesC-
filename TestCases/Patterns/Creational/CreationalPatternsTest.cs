// //PatternsTest.cs
// // Copyright (c) 2019 01 08All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System;
using NUnit.Framework;
using TestCases.Patterns.Creational.AbstractFactory;
using TestCases.Patterns.Creational.AbstractFactory.ElectroCars.Tesla;
using TestCases.Patterns.Creational.AbstractFactory.GasCars.Audi;

namespace TestCases.Patterns.Creational
{
    public class CreationalPatternsTest
    {
        [Test]
        public void AbstractFactoryTest()
        {
            var teslaClient = new CarClient(new TeslaFactory());
            var model3 = teslaClient.GetFactory.BuildElectroCar(new Model3());
            var modelS = teslaClient.GetFactory.BuildElectroCar(new ModelS());
            Assert.AreEqual(typeof(Model3).FullName, model3.GetType().FullName);
            Assert.IsFalse(model3.CarId == Guid.Empty);
            Assert.AreEqual(typeof(ModelS).FullName, modelS.GetType().FullName);
            Assert.IsFalse(modelS.CarId == Guid.Empty);

            var audiClient = new CarClient(new AudiFactory());
            var audiA8 = audiClient.GetFactory.BuildGasCar(new AudiA8());
            Assert.AreEqual(typeof(AudiA8).FullName, audiA8.GetType().FullName);
            Assert.IsFalse(audiA8.CarId == Guid.Empty);

        }

    }
}