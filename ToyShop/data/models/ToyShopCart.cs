using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using ToyShop.data.models;

namespace ToyShop.Data.models 
{
    public class ToyShopCart
    {
        private readonly AppDBContent AppDBContent;
        public ToyShopCart(AppDBContent appDBContent) 
        {
            this.AppDBContent = appDBContent;
        }
        public string ToyShopCartId { get; set; }
        public List<ToyShopCartItem> ListToyShopItems { get; set; }

        public static ToyShopCart GetCart(IServiceProvider services) 
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string toyShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", toyShopCartId);

            return new ToyShopCart(context) { ToyShopCartId = toyShopCartId };
        }

        public void AddToCart(Toy toy) 
        {
            AppDBContent.ToyShopCartItem.Add(new ToyShopCartItem 
            {
                ToyShopCartId = ToyShopCartId,
                toy = toy,
                price = toy.Price
            });

            AppDBContent.SaveChanges();
        }

        public void RemoveFromCart(int id)
        {
            ToyShopCartItem itemToy = AppDBContent.ToyShopCartItem.Where(i => i.toy.Id == id).FirstOrDefault();

            if(itemToy != null)
            {
                AppDBContent.ToyShopCartItem.Remove(itemToy);
                AppDBContent.SaveChanges();
            }    
        }

        public void RemoveAllFromCart()
        {
            AppDBContent.ToyShopCartItem.RemoveRange(AppDBContent.ToyShopCartItem);
            AppDBContent.SaveChanges();
                        
        }

        public List<ToyShopCartItem> GetToyShopItems() 
        {
            return AppDBContent.ToyShopCartItem.Where(t => t.ToyShopCartId == ToyShopCartId).Include(s => s.toy).ToList();
        }
    }
}
