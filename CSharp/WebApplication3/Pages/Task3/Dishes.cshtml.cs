using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.WebApplication3.Data;

namespace WebApplication3.Pages.Task3
{
    public class DishesModel : PageModel
    {
        private readonly AppDbContext _context;
        public DishesModel(AppDbContext context) => _context = context;

        public IList<Dish> Dishes { get; set; }
        public string CurrentCategory { get; set; }

        public async Task OnGetAsync(string category)
        {
            // Проверка пустых таблиц
            if (!_context.Dishes.Any() && !_context.Restaurants.Any() && !_context.Categories.Any())
            {
                // Создаем категории
                var categories = new List<Category>
                {
                    new Category { Name = "Супи" },
                    new Category { Name = "Напої" },
                    new Category { Name = "Десерти" }
                };
                _context.Categories.AddRange(categories);
                _context.SaveChanges();

                // Создаем рестораны
                var restaurants = new List<Restaurant>();
                for (int i = 1; i <= 3; i++)
                {
                    restaurants.Add(new Restaurant
                    {
                        Name = $"Restaurant {i}",
                        Address = $"Address {i}"
                    });
                }
                _context.Restaurants.AddRange(restaurants);
                _context.SaveChanges();

                // Создаем блюда и привязываем к ресторанам и категориям
                var random = new Random();
                foreach (var restaurant in restaurants)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        var dish = new Dish
                        {
                            Title = $"Dish {i} of {restaurant.Name}",
                            Price = random.Next(50, 500),
                            RestaurantId = restaurant.Id
                        };
                        _context.Dishes.Add(dish);
                        _context.SaveChanges();

                        foreach (var cat in categories.OrderBy(c => random.Next()).Take(2))
                        {
                            _context.DishCategories.Add(new DishCategory
                            {
                                DishId = dish.Id,
                                CategoryId = cat.Id
                            });
                        }
                        _context.SaveChanges();
                    }
                }
            }

            CurrentCategory = category;

            var query = _context.Dishes
                .Include(d => d.Restaurant)
                .Include(d => d.DishCategories)
                    .ThenInclude(dc => dc.Category)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
                query = query.Where(d => d.DishCategories.Any(dc => dc.Category.Name == category));

            Dishes = await query.OrderBy(d => d.Title).ToListAsync();
        }
    }
}
