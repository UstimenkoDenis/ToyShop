using System.Collections.Generic;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.Data.Repository
{
    public class CategoryRepository : IToysCategory 
    {
        private readonly AppDBContent AppDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.AppDBContent = appDBContent;
        }
        public IEnumerable<Category> AllCategories => AppDBContent.Category;
    }
}
