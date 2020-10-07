
namespace ToyShop.data.models
{
    public class OrderDetail
    {
        
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int ToyID { get; set; }
        public uint Price { get; set; }
        public virtual Toy Toy { get; set; }
        public virtual Order Order { get; set; }

    }
}