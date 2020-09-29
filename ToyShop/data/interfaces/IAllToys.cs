using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.data.interfaces {
    public interface IAllToys {

        IEnumerable<Toy> Toys { get; }
        IEnumerable<Toy> getFavToy { get; set; }
        Toy getObjectToy(int toyId);

    }
}
