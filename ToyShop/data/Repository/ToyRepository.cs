using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.Data.Repository {
    public class ToyRepository : IAllToys {
        private readonly AppDBContent appDBContent;
        public ToyRepository(AppDBContent appDBContent) {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Toy> Toys => appDBContent.Toy.Include(t => t.Category);

        public IEnumerable<Toy> getFavToy => appDBContent.Toy.Where(p => p.isFavourite).Include(t => t.Category);

        public Toy getObjectToy(int toyId) => appDBContent.Toy.FirstOrDefault(p => p.id == toyId);
    }
}
