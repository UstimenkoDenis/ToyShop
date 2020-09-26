using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.data.interfaces {
    interface IAllToys {

        IEnumerable<Toy> Toys { get; set }
        IEnumerable<Toy> getFavToy { get; set }
        Toy getObjectToy(int toyId);

    }
}
