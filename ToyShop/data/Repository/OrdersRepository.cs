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

        private readonly AppDBContent appDBContent;
        private readonly ToyShopCart toyShopCart;

        public OrdersRepository(AppDBContent appDBContent, ToyShopCart toyShopCart)
        {
            this.appDBContent = appDBContent;
            this.toyShopCart = toyShopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();

            var items = toyShopCart.listToyShopItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    toyID = el.toy.id,
                    orderID = order.id,
                    price = el.toy.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
            appDBContent.SaveChanges();
        }
    }
}