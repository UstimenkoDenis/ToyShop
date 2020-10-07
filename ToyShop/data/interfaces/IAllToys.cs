using System.Collections.Generic;
using ToyShop.data.models;

namespace ToyShop.data.interfaces
{
    public interface IAllToys 
    {

        IEnumerable<Toy> Toys { get; }
        IEnumerable<Toy> GetFavToy { get; }
        Toy GetObjectToy(int toyId);

    }
}
