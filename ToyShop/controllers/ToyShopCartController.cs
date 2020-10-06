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
            var items = _toyShopCart.getToyShopItems();
            _toyShopCart.ListToyShopItems = items;

            var obj = new ToyShopCartViewModel 
            {
                ToyShopCart = _toyShopCart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id) 
        {
            var item = _toyRep.Toys.FirstOrDefault(i => i.Id == id);
            if(item != null) 
            {
                _toyShopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
