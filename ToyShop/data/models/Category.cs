using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyShop.data.models 
{
    public class Category 
    {
        public int Id { set; get; }
        public string CategoryName  { set; get; }
        public string Desc { set; get; }
        public List<Toy> Toys { set; get; }

    }
}
