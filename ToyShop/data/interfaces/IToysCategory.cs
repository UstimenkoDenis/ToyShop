using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.data.interfaces 
{
    public interface IToysCategory 
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
