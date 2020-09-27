﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.ViewModels;

namespace ToyShop.controllers {
    public class ToysController : Controller {

        private readonly IAllToys _allToys;
        private readonly IToysCategory _allCategories;

        public ToysController (IAllToys iAllToys, IToysCategory iToysCat) {
            _allToys = iAllToys;
            _allCategories = iToysCat;
        }
        public ViewResult List() {
            ToysListViewModel obj = new ToysListViewModel();
            obj.allToys = _allToys.Toys;
            obj.currCategory = "Игрушки";
            return View(obj);
        }
    }
}
