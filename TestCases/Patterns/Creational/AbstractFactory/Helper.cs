// //Helper.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

using System.Reflection;
using TestCases.Patterns.Creational.AbstractFactory.GasCars;

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public static class Helper
    {
        public static TCar DefineCarBuildMethod<TFactory, TCar, TCarScheme>(TCarScheme car, string nameOfMethodToCall, TFactory factory) where TCarScheme : BaseCarScheme where TCar : BaseCar where TFactory : ICarAbstractFactory
        {
            var cacType = car.GetType();
            var factoryType = factory.GetType();
            var getCarModelMethod = factoryType.GetMethod(nameOfMethodToCall, BindingFlags.NonPublic | BindingFlags.Instance,
                null, new[] { cacType }, null);
            if (getCarModelMethod != null)
            {

                return getCarModelMethod.Invoke(factory, new[] { car }) as TCar;
            }

            return null;
        }
    }
}