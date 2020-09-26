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
                    new Category { categoryName = "Младенцы", desc = "Дети до одного года"},
                    new Category { categoryName = "Активная игра", desc = "Игрушки для детей от года до трёх"}
                }
            }
        }
    }
}
