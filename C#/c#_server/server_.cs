using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Net.Sockets;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }
    public int Year { get; set; }
    public bool IsAvailable { get; set; }
    public int Quantity { get; set; }
}

public class Car_selled
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public decimal Price_selled { get; set; }
    public int Year { get; set; }
}


class AppDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Car_selled> Cars_selled { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=SysProg_carsDB; Trusted_Connection=True; TrustServerCertificate=True");
    }
}

class Program
{
    class Tasks
    {
        private AppDbContext context;

        public Tasks(AppDbContext context)
        {
            this.context = context;
        }

        public string search_byId(string options)
        {
            foreach (var car in context.Cars)
            {
                if (car.Id == int.Parse(options))
                {
                    Console.WriteLine("search_byId done");
                    return $"{car.Brand} {car.Model} {car.Year}\nPrice: {car.Price}\n{(car.IsAvailable ? $"Quantity: {car.Quantity}" : "Not available")}";
                }
            }
            Console.WriteLine("search_byId not done");
            return "Car not found";
        }

        public string search_byPrice(string options)
        {
            int start_price = int.Parse(options.Split('_')[0]);
            int end_price = int.Parse(options.Split('_')[1]);
            string result = "";
            foreach (var car in context.Cars)
            {
                if (car.Price >= start_price && car.Price <= end_price)
                {
                    Console.WriteLine("search_byPrice done");
                    result += $"{car.Brand} {car.Model} {car.Year}\nPrice: {car.Price}\n{(car.IsAvailable ? $"Quantity: {car.Quantity}" : "Not available")}\n\n";
                }
            }
            Console.WriteLine("search_byPrice not done");
            return result == "" ? "Car not found" : result;
        }

        public string search_byBrandAndModel(string options)
        {
            string brand = options.Split('_')[0];
            string model = options.Split('_')[1];
            string result = "";
            foreach (var car in context.Cars)
            {
                if (car.Brand == brand && car.Model == model)
                {
                    Console.WriteLine("search_byBrandAndModel done");
                    result += $"{car.Brand} {car.Model} {car.Year}\nPrice: {car.Price}\n{(car.IsAvailable ? $"Quantity: {car.Quantity}" : "Not available")}\n\n";
                }
            }
            Console.WriteLine("search_byBrandAndModel not done");
            return result == "" ? "Car not found" : result;
        }

        public string make_unavailable(string options)
        {
            foreach (var car in context.Cars)
            {
                if (car.Id == int.Parse(options))
                {
                    car.IsAvailable = false;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("make_unavailable exception: " + ex.Message);
                        return "Error";
                    }
                    Console.WriteLine("make_unavailable done");
                    return "Now this car is not available";
                }
            }
            Console.WriteLine("make_unavailable not done");
            return "Car not found";
        }

        public string add_car_toAvailable(string options)
        {
            foreach (var car in context.Cars)
            {
                if (car.Id == int.Parse(options) && car.IsAvailable == true) // до доступних
                {
                    car.Quantity++;
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("add_car_toAvailable exception: " + ex.Message);
                        return "Error";
                    }
                    Console.WriteLine("add_car_toAvailable done");
                    return "Added one more car";
                }
            }
            Console.WriteLine("add_car_toAvailable not done");
            return "Car not found";
        }

        public string sell_car(string options)
        {
            foreach (var car in context.Cars)
            {
                if (car.Id == int.Parse(options) && car.IsAvailable == true) // до доступних
                {
                    car.IsAvailable = false;
                    car.Quantity--;
                    context.Cars_selled.Add(new Car_selled { Brand = car.Brand, Model = car.Model, Price_selled = car.Price, Year = car.Year });
                    try
                    {
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("sell_car exception: " + ex.Message);
                        return "Error";
                    }
                    Console.WriteLine("sell_car done");
                    return "Sold one car";
                }
            }
            Console.WriteLine("sell_car not done");
            return "Car not found";
        }

        public string edit_car(string options)
        {
            string[] options_splited = options.Split('_');
            int? Id;
            int? Year, Quantity;
            string? Brand, Model;
            decimal? Price;
            bool? IsAvailable;
            try
            {
                Id = int.Parse(options_splited[0]);
                Brand = options_splited[1] == "current" ? null : options_splited[1];
                Model = options_splited[2] == "current" ? null : options_splited[2];
                Price = options_splited[3] == "current" ? null : decimal.Parse(options_splited[3]);
                Year = options_splited[4] == "current" ? null : int.Parse(options_splited[4]);
                IsAvailable = options_splited[5] == "current" ? null : bool.Parse(options_splited[5]);
                Quantity = options_splited[6] == "current" ? null : int.Parse(options_splited[6]);
            }
            catch
            {
                return "Error";
            }

            foreach (var car in context.Cars)
            {
                if (car.Id == Id)
                {
                    car.Brand = Brand ?? car.Brand;
                    car.Model = Model ?? car.Model;
                    car.Price = Price ?? car.Price;
                    car.Year = Year ?? car.Year;
                    car.IsAvailable = IsAvailable ?? car.IsAvailable;
                    car.Quantity = Quantity ?? car.Quantity;
                    context.SaveChanges();
                    return "Edited one car";
                }
            }
            return "Car not found";
        }
    }

    static async Task Main(string[] args)
    {
        TcpListener listener = new TcpListener(IPAddress.Any, 5000);
        listener.Start();
        Console.WriteLine("Server started");

        TcpClient client = await listener.AcceptTcpClientAsync();
        Console.WriteLine("Client connected");
        using (NetworkStream stream = client.GetStream())
        {
            using (StreamReader reader = new StreamReader(stream))
            {
                using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
                {
                    using (AppDbContext context = new AppDbContext())
                    {
                        int ch = -1;
                        while (ch != 0)
                        {
                            string message; // {choice_id)|{value}
                            while ((message = await reader.ReadLineAsync()) != null)
                            {
                                ch = int.Parse(message.Split('|')[0]);
                                string options = message.Split('|')[1];
                                Tasks tasks = new Tasks(context);
                                switch (ch)
                                {
                                    case 1: 
                                        writer.WriteLine(tasks.search_byId(options));
                                        break;
                                    case 2:
                                        writer.WriteLine(tasks.search_byPrice(options));
                                        break;
                                    case 3:
                                        writer.WriteLine(tasks.search_byBrandAndModel(options));
                                        break;
                                    case 4:
                                        writer.WriteLine(tasks.make_unavailable(options));
                                        break;
                                    case 5:
                                        writer.WriteLine(tasks.add_car_toAvailable(options));
                                        break;
                                    case 6:
                                        writer.WriteLine(tasks.sell_car(options));
                                        break;
                                    case 7:
                                        writer.WriteLine(tasks.edit_car(options));
                                        break;
                                    case 0: break;
                                    default:
                                        writer.WriteLine("Error");
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }
        client.Close();
        listener.Stop();
    }
}