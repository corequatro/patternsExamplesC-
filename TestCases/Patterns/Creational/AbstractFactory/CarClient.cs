// //CarClient.cs
// // Copyright (c) 2019 01 09All Rights Reserved
// // Bogdan Lyashenko
// // corequatro@gmail.com

namespace TestCases.Patterns.Creational.AbstractFactory
{
    public class CarClient
    {
        private readonly ICarAbstractFactory _abstractFactory;
        public CarClient(ICarAbstractFactory factory)
        {
            _abstractFactory = factory;
        }

        public ICarAbstractFactory GetFactory => _abstractFactory;
    }
}