using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.Data.models {
    public class ToyShopCart {
        private readonly AppDBContent appDBContent;
        public ToyShopCart(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        public string ToyShopCartId { get; set; }
        public List<ToyShopCartItem> listToyShopItems { get; set; }

        public static ToyShopCart GetCart(IServiceProvider services) {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string toyShopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", toyShopCartId);

            return new ToyShopCart(context) { ToyShopCartId = toyShopCartId };
        }

        public void AddToCart(Toy toy, int amount) {
            appDBContent.ToyShopCartItem.Add(new ToyShopCartItem
            {
                ToyShopCartId = ToyShopCartId,
                toy = toy,
                price = toy.price
            });

            appDBContent.SaveChanges();
        }

        public List<ToyShopCartItem> getToyShopItems() {
            return appDBContent.ToyShopCartItem.Where(t => t.ToyShopCartId == ToyShopCartId).Include(s => s.toy).ToList();
        }
    }
}
