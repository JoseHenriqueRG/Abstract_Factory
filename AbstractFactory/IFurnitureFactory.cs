using Abstract_Factory.Models;

namespace Abstract_Factory.AbstractFactory
{
    public interface IFurnitureFactory
    {
        Chair CreateChair();
        CoffeeTable CreateCoffeeTable();
        Sofa CreateSofa();
    }
}
