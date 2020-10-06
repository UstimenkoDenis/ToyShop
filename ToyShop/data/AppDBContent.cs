using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;
using ToyShop.Data.models;

namespace ToyShop.Data 
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options ) : base(options) 
        {

        }

        public DbSet<Toy> Toy { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ToyShopCartItem> ToyShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }

    }
}
