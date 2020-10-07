using System.Collections.Generic;
using ToyShop.data.models;

namespace ToyShop.ViewModels 
{
    public class HomeViewModel 
    {
        public IEnumerable<Toy> FavToys { get; set; }
    }
}
