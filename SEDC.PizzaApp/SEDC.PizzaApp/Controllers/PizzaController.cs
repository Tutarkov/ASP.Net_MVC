using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetAllPizzas()
        {
            List<Pizza> pizzasDb = StaticDb.Pizzas;
            return View(pizzasDb);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            var pizza = StaticDb.Pizzas.FirstOrDefault(p => p.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }

            var pizzaViewModel = PizzaMapper.PizzaToViewModel(pizza);

            return View(pizzaViewModel);
        }

        public ActionResult Index()
        {
            var pizzas = StaticDb.Pizzas;
            var pizzaViewModels = new List<PizzaViewModel>();

            foreach (var pizza in pizzas)
            {
                var pizzaViewModel = PizzaMapper.PizzaToViewModel(pizza);
                pizzaViewModels.Add(pizzaViewModel);
            }

            return View(pizzaViewModels);
        }

    }
}
