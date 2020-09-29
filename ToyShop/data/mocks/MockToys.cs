﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.interfaces;
using ToyShop.data.models;

namespace ToyShop.data.mocks {
    public class MockToys : IAllToys
    {
        private readonly IToysCategory _categoryToys = new MockCategory();
        public IEnumerable<Toy> Toys {
            
            get {
                return new List<Toy> {
                    new Toy {
                        name = "Беговел Единорожка",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/unicorn.gif",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Львенок",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/Lion.gif",
                        price = 4500,
                        isFavourite = false,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Мишка",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/bike.jpg",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Зайка",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/hare.gif",
                        price = 4500,
                        isFavourite = false,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Лосёнок",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/horse.gif",
                        price = 4500,
                        isFavourite = false,
                        available = false,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Панда",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/panda.gif",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Беговел Лисёнок",
                        shortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        longDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        img = "/img/fox.gif",
                        price = 4500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Бульдозер",
                        shortDesc = "Конструктор для маленьких.",
                        longDesc = "Количество деталей в данном конструкторе не так велико. Да это и не главное, а главное то, что малыш начнет познавать первые шаги в конструировании, и будет очень рад, когда из четырех кубиков соберет свой первый трактор .",
                        img = "/img/t.gif",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Машинка с трактором",
                        shortDesc = "Конструктор для маленьких.",
                        longDesc = "Игрушка большого размера и все детали удобны для игры маленькому ребенку. Яркие цвета притянут внимание ребенка, побуждая к усидчивой спокойной игре. Трактор - это маленький конструктор, развивающий мелкую моторику. Содержание логической составляющей выделяет данную игрушку из ряда подобных.",
                        img = "/img/trailer.gif",
                        price = 3500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Пожарная машина",
                        shortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        longDesc = "Всем скорее в машину! Мы отправляемся на срочный вызов! Четыре пожарных дружинника, станут маленькими героями в руках вашего малыша! Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        img = "/img/redbus.gif",
                        price = 2500,
                        isFavourite = true,
                        available = false,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Кубики",
                        shortDesc = "Конструктор с крупными деталями",
                        longDesc = "Кубики - конструктор с крупными деталями, хорошо ложащимися в руку малыша. Яркие краски подымают настроение при игре и притягивают внимание малыша побуждая его усесться и заняться спокойной, конструктивной  игрой.",
                        img = "/img/boxes.gif",
                        price = 3500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Автовоз",
                        shortDesc = "Большая деревянная игрушка",
                        longDesc = "Машина большого размера и все элементы удобны в управлении для малыша. Игрушка полностью из дерева, краски безопасные для детей. Цвета машинок можно задать при заказе",
                        img = "/img/autonew.gif",
                        price = 3000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Палочки Да Винчи",
                        shortDesc = "Логическая игра",
                        longDesc = "В пятнадцатом веке Леонардо Да Винчи изобрел способ строительства без верёвок и гвоздей. Балки удерживали друг друга и могли нести большие нагрузки. Цветные палочки Да Винчи помогут вашим детям приобрести первые навыки в строительстве. Маленькие дети могут изучать цвета, а также использовать их как счётные палочки.",
                        img = "/img/dav.jpg",
                        price = 2000,
                        isFavourite = true,
                        available = false,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Погремушка",
                        shortDesc = "Для самых маленьких.",
                        longDesc = "Для самых маленьких мы изготавливаем погремушки применяя покраску льняным маслом. Безопасные для малюток, они устойчивы к слюне и их можно грызть",
                        img = "/img/bear.gif",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Радуга",
                        shortDesc = "Конструктор",
                        longDesc = "Радуги так же как и кубики занимают достойное место среди развивающих игрушек. Вариантов конструкций великое множество - что дает простор для фантазии ребёнка.",
                        img = "/img/rainbow.gif",
                        price = 2000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Машинка Johannes Shell",
                        shortDesc = "Полностью деревянная машинка.",
                        longDesc = "Игрушка выполнена в виде смешной машинки с разноцветными кляксами. Голова водителя держится на резинке. Дети очень любят с ней играться, пытаясь вытащить водителя из машины. Не беспокойтесь - голова держится крепко!",
                        img = "/img/shell.gif",
                        price = 1000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Циферблат",
                        shortDesc = "Развивающая игра для малышей",
                        longDesc = "Изучайте цифры вместе с нами! Так же есть возможность выкладывать некоторые буквы Игрушка развивает мелкую моторику.",
                        img = "/img/numbers.gif",
                        price = 500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.First(),

                    },
                    new Toy {
                        name = "Розовый автобус",
                        shortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        longDesc = "Специально для девочек! Розовый автобус с четырьмя малышками! Данная игрушка развивает мелкую моторику и просто дарит отличное настроение!",
                        img = "/img/pink.gif",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),
                    },
                    new Toy {
                        name = "Спецзаказ",
                        shortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        longDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику, но необычная! Цвета каждого элемента были выбраны заказчиком индивидуально. Вы можете заказать игрушку любимых цветов вашего малыша.",
                        img = "/img/Bus.gif",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Автобус Пикник",
                        shortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        longDesc = "Семья из четырех человек уселась в автобус и отправилась на пикник за город. Данная игрушка развивает мелкую моторику и просто дарит отличное настроение!",
                        img = "/img/busNEW.gif",
                        price = 1500,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },
                    new Toy {
                        name = "Лесовоз",
                        shortDesc = "Большая деревянная машина",
                        longDesc = "Игрушка большого размера и все детали удобно управляются маленьким ребенком. Из бревнышек можно сложить чудесный домик, что отлично развивает мелкую моторику! Сочетание активной игры с логической, делает эту машинку очень популярной.",
                        img = "/img/auto.gif",
                        price = 3000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryToys.allCategories.Last(),

                    },                    
                };
            }
        }
        public IEnumerable<Toy> getFavToy { get ; set ; }

        public Toy getObjectToy(int toyId)
        {
            throw new NotImplementedException();
        }
    }
}
