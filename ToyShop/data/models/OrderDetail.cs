using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToyShop.data.models
{
    public class OrderDetail
    {
        
        public int id { get; set; }
        public int orderID { get; set; }
        public int toyID { get; set; }
        public uint price { get; set; }
        public virtual Toy toy { get; set; }
        public virtual Order order { get; set; }

    }
}