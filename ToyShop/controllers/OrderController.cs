using Microsoft.AspNetCore.Mvc;
using ToyShop.data.interfaces;
using ToyShop.Data.models;
using ToyShop.data.models;

namespace ToyShop.Controllers
{
    public class OrderController : Controller 
    {

        private readonly IAllOrders AllOrders;
        private readonly ToyShopCart ToyShopCart;

        public OrderController(IAllOrders allOrders, ToyShopCart toyShopCart) 
        {
            this.AllOrders = allOrders;
            this.ToyShopCart = toyShopCart;
        }

        public IActionResult Checkout()
        {
            var items = ToyShopCart.GetToyShopItems();
            ToyShopCart.ListToyShopItems = items;

            if (ToyShopCart.ListToyShopItems.Count != 0)
            {
                return View();                
            }

            return View("Alert");
        }

        [HttpPost]
        public IActionResult Checkout(Order order) 
        {

            ToyShopCart.ListToyShopItems = ToyShopCart.GetToyShopItems();

            if (ToyShopCart.ListToyShopItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас должны быть товары");
            }

            if (ModelState.IsValid) 
            {
                AllOrders.CreateOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }
        public IActionResult Alert()
        {
            return View();
        }
        public IActionResult Complete() 
        {
            ToyShopCart.RemoveAllFromCart();
            ViewBag.Message = "Спасибо за заказ! Мы скоро свяжемся с вами.";
            return View();
        }
    }
}