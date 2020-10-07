using System.Collections.Generic;
using ToyShop.data.models;

namespace ToyShop.data.interfaces 
{
    public interface IToysCategory 
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
