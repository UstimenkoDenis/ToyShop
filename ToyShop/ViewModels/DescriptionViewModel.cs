﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.ViewModels
{
    public class DescriptionViewModel 
    {
       public Toy GetObjectToy { get; set; }
       public string Available { get; set; }       
    }
}