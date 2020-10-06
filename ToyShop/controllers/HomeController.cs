using ToyShop.data.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.Data.models;
using ToyShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ToyShop.Controllers 
{
    public class HomeController : Controller 
    {
        private IAllToys _toyRep;
        
        public HomeController(IAllToys toyRep)
        {
            _toyRep = toyRep;            
        }

        public ViewResult Index()
        {   
            var homeToys = new HomeViewModel 
            {
                FavToys = _toyRep.GetFavToy
            };
            return View(homeToys);
        }
    }
}