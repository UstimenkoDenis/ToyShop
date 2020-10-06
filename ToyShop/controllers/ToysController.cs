using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.ViewModels;
using ToyShop.data.models;

namespace ToyShop.controllers 
{
    public class ToysController : Controller 
    {

        private readonly IAllToys _allToys;
        private readonly IToysCategory _allCategories;

        public ToysController (IAllToys iAllToys, IToysCategory iToysCat) 
        {
            _allToys = iAllToys;
            _allCategories = iToysCat;
        }

        [Route("Toys/List")]
        [Route("Toys/List/{category}")]
        public ViewResult List(string category) 
        {
            string _category = category;
            IEnumerable<Toy> toys = null;
            string currCategory="";
            if(string.IsNullOrEmpty(category)) 
            {
                toys = _allToys.Toys.OrderBy(i => i.Id);
            } else 
                {
                    if (string.Equals("active", category, StringComparison.OrdinalIgnoreCase))
                    {
                        toys = _allToys.Toys.Where(i => i.Category.CategoryName.Equals("Активная игра")).OrderBy(i => i.Id); 
                        currCategory = "Спокойная игра";
                    } 
                    else if (string.Equals("quiet", category, StringComparison.OrdinalIgnoreCase))
                    {
                        toys = _allToys.Toys.Where(i => i.Category.CategoryName.Equals("Спокойная игра")).OrderBy(i => i.Id); 
                        currCategory = "Активная игра";
                    }

                currCategory = _category;
            }

            var toyObj = new ToysListViewModel 
            {    
                    AllToys = toys,
                    CurrCategory = currCategory
            };

            ViewBag.Title = "Johannes Shell Toys";
            
            return View(toyObj);
        }
    }
}
