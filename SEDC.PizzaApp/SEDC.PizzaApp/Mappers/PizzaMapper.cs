using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaToViewModel(Pizza pizza)
        {
            var pizzaViewModel = new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                PizzaSize = pizza.PizzaSize
            };

            pizzaViewModel.Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price;

            return pizzaViewModel;
        }

    }
}
