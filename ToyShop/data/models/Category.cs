using System.Collections.Generic;

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
