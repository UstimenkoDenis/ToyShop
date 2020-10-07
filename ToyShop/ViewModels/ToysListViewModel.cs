using System.Collections.Generic;
using ToyShop.data.models;

namespace ToyShop.ViewModels 
{
    public class ToysListViewModel 
    {
        public IEnumerable<Toy> AllToys { get; set; }
        public string CurrCategory { get; set; }
    }
}
