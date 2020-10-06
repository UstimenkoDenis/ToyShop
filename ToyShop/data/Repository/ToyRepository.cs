using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.Data.Repository 
{
    public class ToyRepository : IAllToys 
    {
        private readonly AppDBContent AppDBContent;
        public ToyRepository(AppDBContent appDBContent) 
        {
            this.AppDBContent = appDBContent;
        }
        public IEnumerable<Toy> Toys => AppDBContent.Toy.Include(t => t.Category);

        public IEnumerable<Toy> GetFavToy => AppDBContent.Toy.Where(p => p.IsFavourite).Include(t => t.Category);

        public Toy GetObjectToy(int toyId) => AppDBContent.Toy.FirstOrDefault(p => p.Id == toyId);
    }
}
