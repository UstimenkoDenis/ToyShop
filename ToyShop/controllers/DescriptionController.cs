using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.ViewModels;

namespace ToyShop.controllers
{
    public class DescriptionController : Controller
    {

        private IAllToys _toyRep;
        public DescriptionController(IAllToys toyRep)
        {
            _toyRep = toyRep;
            
        }
        
        public ViewResult Index(int id) 
        {
            string theToyAvail;

            if (_toyRep.GetObjectToy(id).Available) 
            {
                theToyAvail = "Есть в наличии";
            } else
            {
                theToyAvail = "Нет в наличии";
            }

                var theToy = new DescriptionViewModel 
                { 
                    GetObjectToy = _toyRep.GetObjectToy(id),
                    Available = theToyAvail
                };
            return View(theToy);
        }
    }
}
