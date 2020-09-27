using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.ViewModels {
    public class ToysListViewModel {
        public IEnumerable<Toy> allToys { get; set; }
        public string currCategory { get; set; }
    }
}
