using Abstract_Factory.AbstractFactory;
using Microsoft.AspNetCore.Mvc;

namespace Abstract_Factory.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string pedido)
        {
            if (!string.IsNullOrEmpty(pedido))
            {
                switch (pedido) { 
                    case "modern":
                        ViewBag.Result = ClientMethod(new ModernFurnitureFactory());
                        break;
                    case "victorian":
                        ViewBag.Result = ClientMethod(new VictorianFurnitureFactory());
                        break;
                    case "industrial":
                        ViewBag.Result = ClientMethod(new IndustrialfurnitureFactory());
                        break;
                    case "classic":
                        ViewBag.Result = ClientMethod(new ClassicFurnitureFactory());
                        break;
                }
            }

            return View();
        }

        private static string ClientMethod(IFurnitureFactory factory)
        {
            var chair = factory.CreateChair().Info;
            var coffeeTable = factory.CreateCoffeeTable().Info;
            var sofa = factory.CreateSofa().Info;

            return $"{chair} | {coffeeTable} | {sofa}";
        }
    }
}

