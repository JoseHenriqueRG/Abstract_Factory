using Abstract_Factory.Models;

namespace Abstract_Factory.AbstractFactory
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public Chair CreateChair()
        {
            return new Chair("Vitorian");
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new CoffeeTable("Vitorian");
        }

        public Sofa CreateSofa()
        {
            return new Sofa("Vitorian");
        }
    }
}
