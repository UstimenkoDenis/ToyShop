using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;
using ToyShop.Data.models;

namespace ToyShop.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {

        private readonly AppDBContent AppDBContent;
        private readonly ToyShopCart ToyShopCart;

        public OrdersRepository(AppDBContent appDBContent, ToyShopCart toyShopCart)
        {
            this.AppDBContent = appDBContent;
            this.ToyShopCart = toyShopCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderTime = DateTime.Now;
            AppDBContent.Order.Add(order);
            AppDBContent.SaveChanges();

            var items = ToyShopCart.ListToyShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ToyID = el.toy.Id,
                    OrderID = order.Id,
                    Price = el.toy.Price
                };
                AppDBContent.OrderDetail.Add(orderDetail);
            }
            AppDBContent.SaveChanges();
        }
    }
}