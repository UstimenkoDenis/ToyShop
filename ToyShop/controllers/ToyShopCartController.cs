using Microsoft.AspNetCore.Mvc;
using ToyShop.data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;
using ToyShop.ViewModels;
using ToyShop.Data.models;

namespace ToyShop.Controllers {
    public class ToyShopCartController : Controller
    {
        private IAllToys _toyRep;
        private readonly ToyShopCart _toyShopCart;
        public ToyShopCartController(IAllToys toyRep, ToyShopCart toyShopCart) 
        {
            _toyRep = toyRep;
            _toyShopCart = toyShopCart;
        }

        public ViewResult Index() 
        {            
            var items = _toyShopCart.GetToyShopItems();
            _toyShopCart.ListToyShopItems = items;

            if (_toyShopCart.ListToyShopItems.Count != 0)
            {
                var obj = new ToyShopCartViewModel
                {
                    ToyShopCart = _toyShopCart
                };

                return View(obj);
            }

            return View("CartIsEmpty");
            
        }

        public RedirectToActionResult AddToCart(int id) 
        {
            var item = _toyRep.Toys.FirstOrDefault(i => i.Id == id);
            if(item != null) 
            {
                _toyShopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int id)
        {
            
            _toyShopCart.RemoveFromCart(id);
           

            return RedirectToAction("Index");
        }

        public IActionResult CartIsEmpty()
        {
            ViewBag.Message = "Корзина не содержит товаров.";
            return View();
        }
    }
}
