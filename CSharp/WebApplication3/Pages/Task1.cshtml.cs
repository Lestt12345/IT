// Pages/Orders/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WebApplication3.Data;
using WebApplication3.Data.WebApplication3.Data;

namespace WebApplication3.Pages
{
    public class Task1 : PageModel
    {
        private readonly AppDbContext _context;
        public Task1(AppDbContext context) => _context = context;

        public IList<Order> Orders { get; set; }

        public string CurrentFilter { get; set; }
        public int CurrentPage { get; set; }

        public async Task OnGetAsync(string searchString, int pageNumber = 1)
        {
            // Проверка пустой таблицы Orders
            if (!_context.Orders.Any())
            {
                var products = new List<Product>();
                for (int i = 1; i <= 10; i++)
                    products.Add(new Product { Title = $"Product {i}", Price = i * 10 });

                _context.Products.AddRange(products);
                await _context.SaveChangesAsync();

                var random = new Random();
                for (int i = 1; i <= 20; i++)
                {
                    var order = new Order
                    {
                        CustomerName = $"Customer {i}",
                        OrderDate = DateTime.Now.AddDays(-i)
                    };
                    _context.Orders.Add(order);
                    await _context.SaveChangesAsync();

                    foreach (var product in products.OrderBy(p => random.Next()).Take(3))
                    {
                        _context.OrderProducts.Add(new OrderProduct
                        {
                            OrderId = order.Id,
                            ProductId = product.Id,
                            Quantity = random.Next(1, 5)
                        });
                    }
                    await _context.SaveChangesAsync();
                }
            }

            CurrentFilter = searchString;
            CurrentPage = pageNumber;

            var query = _context.Orders
                .Include(o => o.OrderProducts)
                    .ThenInclude(op => op.Product)
                .AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
                query = query.Where(o => o.CustomerName.Contains(searchString));

            query = query.OrderByDescending(o => o.OrderDate);

            int pageSize = 5;
            Orders = await query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }
    }
}