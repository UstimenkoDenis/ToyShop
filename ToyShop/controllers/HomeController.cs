using ToyShop.data.interfaces;
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