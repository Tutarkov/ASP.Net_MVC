using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;
using System.Xml.Linq;

using System.Collections.Generic;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        private static List<Order> orders = new List<Order>
        {
            new Order { Id = 1, User = "John Doe", Pizza = "Margherita" },
            new Order { Id = 2, User = "Jane Smith", Pizza = "Pepperoni" },
            new Order { Id = 3, User = "Bob Johnson", Pizza = "Vegetarian" }
        };

        public IActionResult Index()
        {
            return View("ListOrders");
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }

            Order order = orders.Find(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }

            return View(order);
        }

        public IActionResult RedirectToIndex()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
