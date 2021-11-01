using Abstract_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract_Factory.AbstractFactory
{
    public class ClassicFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new Chair("Classic");
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable("Classic");
        }

        public Sofa CreateSofa()
        {
            return new Sofa("Classic");
        }
    }
}
