using Abstract_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Factory.AbstractFactory
{
    public class IndustrialfurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new Chair("Industrial");
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable("Industrial");
        }

        public Sofa CreateSofa()
        {
            return new Sofa("Industrial");
        }
    }
}
