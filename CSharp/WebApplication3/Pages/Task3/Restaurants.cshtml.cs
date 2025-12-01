using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.WebApplication3.Data;

namespace WebApplication3.Pages.Task3
{
    public class RestaurantsModel : PageModel
    {
        private readonly AppDbContext _context;
        public RestaurantsModel(AppDbContext context) => _context = context;

        public IList<Restaurant> Restaurants { get; set; }
        public string CurrentFilter { get; set; }
        public int CurrentPage { get; set; }

        public async Task OnGetAsync(string searchString, int pageNumber = 1)
        {
            // Проверка пустых таблиц
            if (!_context.Restaurants.Any() && !_context.Dishes.Any() && !_context.Categories.Any())
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
                for (int i = 1; i <= 5; i++)
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

                        // Привязываем случайные категории
                        foreach (var category in categories.OrderBy(c => random.Next()).Take(2))
                        {
                            _context.DishCategories.Add(new DishCategory
                            {
                                DishId = dish.Id,
                                CategoryId = category.Id
                            });
                        }
                        _context.SaveChanges();
                    }
                }
            }

            CurrentFilter = searchString;
            CurrentPage = pageNumber;

            var query = _context.Restaurants
                .Include(r => r.Dishes)
                    .ThenInclude(d => d.DishCategories)
                        .ThenInclude(dc => dc.Category)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
                query = query.Where(r => r.Name.Contains(searchString));

            int pageSize = 5;
            Restaurants = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}
