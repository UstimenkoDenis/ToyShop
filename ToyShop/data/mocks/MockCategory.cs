using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.data.mocks {
    public class MockCategory : IToysCategory {
        public IEnumerable<Category> allCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Спокойная игра", desc = "Конструкторы, кубики, логические игры"},
                    new Category { categoryName = "Активная игра", desc = "Беговелы, машинки"}
                }
            }
        }
    }
}
