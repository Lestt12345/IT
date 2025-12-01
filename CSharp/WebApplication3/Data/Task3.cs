namespace WebApplication3.Data
{
    using System;
    using System.Collections.Generic;

    namespace WebApplication3.Data
    {
        public class Restaurant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public ICollection<Dish> Dishes { get; set; }
        }

        public class Dish
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }

            public int RestaurantId { get; set; }
            public Restaurant Restaurant { get; set; }

            public ICollection<DishCategory> DishCategories { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }

            public ICollection<DishCategory> DishCategories { get; set; }
        }

        public class DishCategory
        {
            public int DishId { get; set; }
            public Dish Dish { get; set; }

            public int CategoryId { get; set; }
            public Category Category { get; set; }
        }

    }
}