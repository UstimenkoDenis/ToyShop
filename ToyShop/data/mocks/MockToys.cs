using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.data.mocks {
    public class MockToys : IAllToys
    {
        public IEnumerable<Toy> Toys {
            get {
                return new List<Toy> {
                    new Toy {
                        name = "Беговел Единорог", 
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        category = ,

                    },
                    
                }
            }
        }
        public IEnumerable<Toy> getFavToy { get ; set ; }

        public Toy getObjectToy(int toyId)
        {
            throw new NotImplementedException();
        }
    }
}
