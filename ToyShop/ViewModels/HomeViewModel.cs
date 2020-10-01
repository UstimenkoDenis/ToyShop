using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;
using ToyShop.Data.models;

namespace ToyShop.ViewModels {
    public class HomeViewModel {
        public IEnumerable<Toy> favToys { get; set; }
    }
}
