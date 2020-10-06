﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToyShop.data.models;

namespace ToyShop.Data 
{
    public class DBObjects 
    {
        public static void Initial(AppDBContent content) 
        {
            
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(t => t.Value));

            if (!content.Toy.Any()) 
            {
                
                content.AddRange(
                    new Toy
                    {
                        Name = "Беговел Единорожка",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/unicorn.gif",
                        Price = 4500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Львенок",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/Lion.gif",
                        Price = 4500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Мишка",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/bike.jpg",
                        Price = 4500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Зайка",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/hare.gif",
                        Price = 4500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Лосёнок",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/horse.gif",
                        Price = 4500,
                        IsFavourite = false,
                        Available = false,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Панда",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/panda.gif",
                        Price = 4500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Беговел Лисёнок",
                        ShortDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить.",
                        LongDesc = "Детский беговел - для маленьких детей от одного года, которые учатся ходить. Сделан полностью из дерева и лишен острых углов - полностью безопасен для малыша. Очень устойчив и легок в управлении. Пользуется популярностью у детей обожающих активный отдых. Яркий игрушечный образ притягивают маленьких детей, зарождая у них любовь к спорту!",
                        Img = "/img/fox.gif",
                        Price = 4500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Бульдозер",
                        ShortDesc = "Конструктор для маленьких.",
                        LongDesc = "Количество деталей в данном конструкторе не так велико. Да это и не главное, а главное то, что малыш начнет познавать первые шаги в конструировании, и будет очень рад, когда из четырех кубиков соберет свой первый трактор .",
                        Img = "/img/t.gif",
                        Price = 1500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Машинка с трактором",
                        ShortDesc = "Конструктор для маленьких.",
                        LongDesc = "Игрушка большого размера и все детали удобны для игры маленькому ребенку. Яркие цвета притянут внимание ребенка, побуждая к усидчивой спокойной игре. Трактор - это маленький конструктор, развивающий мелкую моторику. Содержание логической составляющей выделяет данную игрушку из ряда подобных.",
                        Img = "/img/trailer.gif",
                        Price = 3500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Пожарная машина",
                        ShortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        LongDesc = "Всем скорее в машину! Мы отправляемся на срочный вызов! Четыре пожарных дружинника, станут маленькими героями в руках вашего малыша! Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        Img = "/img/redbus.gif",
                        Price = 2500,
                        IsFavourite = true,
                        Available = false,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Кубики",
                        ShortDesc = "Конструктор с крупными деталями",
                        LongDesc = "Кубики - конструктор с крупными деталями, хорошо ложащимися в руку малыша. Яркие краски подымают настроение при игре и притягивают внимание малыша побуждая его усесться и заняться спокойной, конструктивной  игрой.",
                        Img = "/img/boxes.gif",
                        Price = 3500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Автовоз",
                        ShortDesc = "Большая деревянная игрушка",
                        LongDesc = "Машина большого размера и все элементы удобны в управлении для малыша. Игрушка полностью из дерева, краски безопасные для детей. Цвета машинок можно задать при заказе",
                        Img = "/img/autonew.gif",
                        Price = 3000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Палочки Да Винчи",
                        ShortDesc = "Логическая игра",
                        LongDesc = "В пятнадцатом веке Леонардо Да Винчи изобрел способ строительства без верёвок и гвоздей. Балки удерживали друг друга и могли нести большие нагрузки. Цветные палочки Да Винчи помогут вашим детям приобрести первые навыки в строительстве. Маленькие дети могут изучать цвета, а также использовать их как счётные палочки.",
                        Img = "/img/dav.jpg",
                        Price = 2000,
                        IsFavourite = true,
                        Available = false,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Погремушка",
                        ShortDesc = "Для самых маленьких.",
                        LongDesc = "Для самых маленьких мы изготавливаем погремушки применяя покраску льняным маслом. Безопасные для малюток, они устойчивы к слюне и их можно грызть",
                        Img = "/img/bear.gif",
                        Price = 1500,
                        IsFavourite = true,
                        Available = true,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Радуга",
                        ShortDesc = "Конструктор",
                        LongDesc = "Радуги так же как и кубики занимают достойное место среди развивающих игрушек. Вариантов конструкций великое множество - что дает простор для фантазии ребёнка.",
                        Img = "/img/rainbow.gif",
                        Price = 2000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Машинка Johannes Shell",
                        ShortDesc = "Полностью деревянная машинка.",
                        LongDesc = "Игрушка выполнена в виде смешной машинки с разноцветными кляксами. Голова водителя держится на резинке. Дети очень любят с ней играться, пытаясь вытащить водителя из машины. Не беспокойтесь - голова держится крепко!",
                        Img = "/img/shell.jpg",
                        Price = 1000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Циферблат",
                        ShortDesc = "Развивающая игра для малышей",
                        LongDesc = "Изучайте цифры вместе с нами! Так же есть возможность выкладывать некоторые буквы Игрушка развивает мелкую моторику.",
                        Img = "/img/numbers.gif",
                        Price = 500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Спокойная игра"],

                    },
                    new Toy
                    {
                        Name = "Розовый автобус",
                        ShortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        LongDesc = "Специально для девочек! Розовый автобус с четырьмя малышками! Данная игрушка развивает мелкую моторику и просто дарит отличное настроение!",
                        Img = "/img/pink.gif",
                        Price = 1500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],
                    },
                    new Toy
                    {
                        Name = "Спецзаказ",
                        ShortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        LongDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику, но необычная! Цвета каждого элемента были выбраны заказчиком индивидуально. Вы можете заказать игрушку любимых цветов вашего малыша.",
                        Img = "/img/Bus.jpg",
                        Price = 1500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Автобус Пикник",
                        ShortDesc = "Эта игрушка из серии автобусы, развивающие мелкую моторику.",
                        LongDesc = "Семья из четырех человек уселась в автобус и отправилась на пикник за город. Данная игрушка развивает мелкую моторику и просто дарит отличное настроение!",
                        Img = "/img/busNEW.gif",
                        Price = 1500,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    },
                    new Toy
                    {
                        Name = "Лесовоз",
                        ShortDesc = "Большая деревянная машина",
                        LongDesc = "Игрушка большого размера и все детали удобно управляются маленьким ребенком. Из бревнышек можно сложить чудесный домик, что отлично развивает мелкую моторику! Сочетание активной игры с логической, делает эту машинку очень популярной.",
                        Img = "/img/auto.jpg",
                        Price = 3000,
                        IsFavourite = false,
                        Available = true,
                        Category = Categories["Активная игра"],

                    }
                );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get 
            { 
                if(category == null) 
                {
                    var list = new Category[] 
                    {
                         new Category { CategoryName = "Спокойная игра", Desc = "Конструкторы, кубики, логические игры"},
                         new Category { CategoryName = "Активная игра", Desc = "Беговелы, машинки"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list) 
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            } 
        }
    }
}
