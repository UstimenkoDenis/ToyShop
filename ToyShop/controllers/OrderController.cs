using Microsoft.AspNetCore.Mvc;
using ToyShop.data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.Data.models;
using ToyShop.data.models;

namespace ToyShop.Controllers
{
    public class OrderController : Controller {

        private readonly IAllOrders allOrders;
        private readonly ToyShopCart toyShopCart;

        public OrderController(IAllOrders allOrders, ToyShopCart toyShopCart) {
            this.allOrders = allOrders;
            this.toyShopCart = toyShopCart;
        }

        public IActionResult Checkout() {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order) {

            toyShopCart.listToyShopItems = toyShopCart.getToyShopItems();

            if (toyShopCart.listToyShopItems.Count == 0) {
                ModelState.AddModelError("", "У вас должны быть товары");
            }

            if (ModelState.IsValid) {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }

        public IActionResult Complete() {
            ViewBag.Message = "Спасибо за заказ! Мы скоро свяжемся с вами.";
            return View();
        }
    }
}