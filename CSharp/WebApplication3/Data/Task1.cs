namespace WebApplication3.Data
{
    using System;
    using System.Collections.Generic;

    namespace WebApplication3.Data
    {
        public class Order
        {
            public int Id { get; set; }
            public DateTime OrderDate { get; set; }
            public string CustomerName { get; set; }
            public ICollection<OrderProduct> OrderProducts { get; set; }
        }
        public class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public ICollection<OrderProduct> OrderProducts { get; set; }
        }
        public class OrderProduct
        {
            public int OrderId { get; set; }
            public Order Order { get; set; }

            public int ProductId { get; set; }
            public Product Product { get; set; }

            public int Quantity { get; set; }
        }
    }
}
