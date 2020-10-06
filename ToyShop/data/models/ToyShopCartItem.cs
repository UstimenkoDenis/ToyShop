using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.Data.models
{
    public class ToyShopCartItem 
    {
        public int id { get; set; }
        public Toy toy { get; set; }
        public int price { get; set; }
        public string ToyShopCartId { get; set; } 
    }
}
