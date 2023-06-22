using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Models
{
    public static class PizzaExtensions
    {
        public static PizzaViewModel ToViewModel(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
                PizzaSize = pizza.PizzaSize
            };
        }
    }
}
