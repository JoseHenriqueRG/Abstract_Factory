using Abstract_Factory.Models;
using System;

namespace Abstract_Factory.AbstractFactory
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new Chair("Modern");
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable("Modern");
        }

        public Sofa CreateSofa()
        {
            return new Sofa("Modern");
        }
    }
}
