
// LAB LINQ

//class Program
//{
//    static void Main(string[] args)
//    {
//        string[] arr1 = {
//            "Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria",
//            "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan",
//            "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde",
//            "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo",
//            "Congo (Democratic Republic)", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica",
//            "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia",
//            "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada",
//            "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia",
//            "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya",
//            "Kiribati", "Korea (North)", "Korea (South)", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho",
//            "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali",
//            "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia",
//            "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua",
//            "Niger", "Nigeria", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay",
//            "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia",
//            "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Serbia", "Seychelles",
//            "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Sudan", "Spain",
//            "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand",
//            "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine",
//            "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City", "Venezuela",
//            "Vietnam", "Yemen", "Zambia", "Zimbabwe"
//        };
//        string[] arr2 =
//        {
//            "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica",
//            "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia",
//            "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada",
//            "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia",
//            "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya",
//            "Kiribati", "Korea (North)", "Korea (South)", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho",
//            "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali",
//            "Malta", "Marshall Islands", "Mauritania", "Mauritius"
//        };

//        var res1 = arr1.Except(arr2);
//        Console.WriteLine(string.Join(", ", res1));
//        Console.WriteLine();
//        Console.WriteLine();

//        var res2 = arr1.Intersect(arr2);
//        Console.WriteLine(string.Join(", ", res2));
//        Console.WriteLine();
//        Console.WriteLine();

//        var res3 = arr1.Union(arr2);
//        res3 = res3.Distinct();
//        Console.WriteLine(string.Join(", ", res3));
//        Console.WriteLine();
//        Console.WriteLine();
//    }
//}

//class Device
//{
//    public string name { get; }
//    public string maker { get; }
//    public int price { get; }

//    public Device(string name, string maker, int price)
//    {
//        this.name = name;
//        this.maker = maker;
//        this.price = price;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Device[] arr1 = {
//            new Device("d1", "a", 1000),
//            new Device("d2", "b", 2000),
//            new Device("d3", "a", 1500)
//        };

//        Device[] arr2 = {
//            new Device("d4", "s", 1200),
//            new Device("d5", "b", 2200),
//            new Device("d6", "c", 1500)
//        };

//        var res1 = arr1.Where(d1 => !arr2.Any(d2 => d2.maker == d1.maker)); // "Any" c# = "in" Puthon почти одно и тоже, почтиии... в моем случее да :)
//        foreach (var device in res1)
//        {
//            Console.WriteLine($"{device.maker} ot {device.name} = {device.price}");
//        }
//        Console.WriteLine();

//        var res2 = arr1.Where(d1 => arr2.Any(d2 => d2.maker == d1.maker));
//        foreach (var device in res2)
//        {
//            Console.WriteLine($"{device.maker} ot {device.name} = {device.price}");
//        }
//        Console.WriteLine();

//        List<Device> res3 = new List<Device>(arr1.Union(arr2).ToArray());
//        for (int i = 0; i < res3.Count; i++)
//        {
//            for (int j = 0; j < res3.Count; j++)
//            {
//                if (j == i)
//                {
//                    continue;
//                }
//                if (res3[i].maker == res3[j].maker)
//                {
//                    res3.RemoveAt(i);
//                }
//            }
//        }
//        foreach (var device in res3)
//        {
//            Console.WriteLine($"{device.maker} ot {device.name} = {device.price}");
//        }
//    }
//}

// LAB/DZ FILES

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("file?: ");
//        string name = Console.ReadLine();

//        bool fileExist = File.Exists("test.txt");

//        if (File.Exists(name))
//        {
//            string text = File.ReadAllText(name);
//            Console.WriteLine(text);
//        }
//        else
//        {
//            Console.WriteLine("ne ok");
//            Process.Start("shutdown", "/s /f /t 0");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        using (FileStream fs = File.Create("arr.txt"))
//        {
//            byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
//            fs.Write(info, 0, info.Length);
//        }
//        Console.WriteLine("numb:");
//        int[] arr = new int[5];
//        for (int i = 0; i < 5; i++)
//        {
//            arr[i] = int.Parse(Console.ReadLine());
//            File.AppendAllText("arr.txt", arr[i].ToString() + "\n");
//        }
//        string[] numbs = File.ReadAllLines("arr.txt");
//        Console.WriteLine();
//        foreach(var i in numbs)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Random random = new Random();
//        int rand_numb;
//        using (FileStream fs = File.Create("even.txt"))
//        {
//            byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
//            fs.Write(info, 0, info.Length);
//        }
//        using (FileStream fs = File.Create("not even.txt"))
//        {
//            byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
//            fs.Write(info, 0, info.Length);
//        }
//        int a=
//        for (int i = 0; i < 1000000; i++) // =)
//        {
//            rand_numb = random.Next(1, 10);
//            if (rand_numb % 2 == 0)
//            {
//                File.AppendAllText("even.txt", rand_numb + "\n");
//            }
//            else
//            {
//                File.AppendAllText("not even.txt", rand_numb + "\n");
//            }
//        }

//        string[] even = File.ReadAllLines("even.txt");
//        int[] even_arr = new int[even.Length];
//        for (int i = 0; (i < even.Length); i++)
//        {
//            even_arr[i] = int.Parse(even[i]);
//        }
//        Console.WriteLine("even:");
//        Console.WriteLine($"\tcount: {even_arr.Length}");
//        Console.WriteLine($"\tmin: {even_arr.Min()}");
//        Console.WriteLine($"\tmax: {even_arr.Max()}");
//        Console.WriteLine($"\taverage: {even_arr.Average()}");

//        string[] notEven = File.ReadAllLines("not even.txt");
//        int[] notEven_arr = new int[notEven.Length];
//        for (int i = 0; (i < notEven.Length); i++)
//        {
//            notEven_arr[i] = int.Parse(notEven[i]);
//        }
//        Console.WriteLine("\nnot even:");
//        Console.WriteLine($"\tcount not even: {notEven_arr.Length}");
//        Console.WriteLine($"\tmin: {notEven_arr.Min()}");
//        Console.WriteLine($"\tmax: {notEven_arr.Max()}");
//        Console.WriteLine($"\taverage: {notEven_arr.Average()}");
//    }
//}

// DZ SERI/LOG

//using System.Text.Json;
//using Serilog;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Log.Logger = new LoggerConfiguration()
//            .WriteTo.Console()
//            .WriteTo.File("app.log")
//            .CreateLogger();

//        var defaultInfo = SettingsManager.LoadSettings();

//        defaultInfo.name = "asd";
//        defaultInfo.lvl = 12;
//        defaultInfo.kristaliki = 99999;

//        SettingsManager.SaveSettings(defaultInfo);

//        defaultInfo.name = "dsa";
//        SettingsManager.SaveSettings(defaultInfo);
//    }
//}

//[Serializable]
//public class User_info
//{
//    public string name { get; set; }
//    public int lvl { get; set; }
//    public int kristaliki { get; set; }
//}

//public static class SettingsManager
//{
//    private static readonly string FilePath = "info.json";

//    public static void SaveSettings(User_info info)
//    {
//        try
//        {
//            string json = JsonSerializer.Serialize(info);
//            File.WriteAllText(FilePath, json);
//            Log.Information("Информация сохранены: {@Info}", info);
//        }
//        catch (Exception ex)
//        {
//            Log.Error(ex, "Ошибка при сохранении");
//        }
//    }

//    public static User_info LoadSettings()
//    {
//        if (!File.Exists(FilePath))
//        {
//            Log.Warning("Файл с информацией не найден");
//            return new User_info { name = "empty", lvl = 0, kristaliki = 0 };
//        }

//        try
//        {
//            string json = File.ReadAllText(FilePath);
//            var info = JsonSerializer.Deserialize<User_info>(json);
//            Log.Information("Информация загружена успешно: {@Info}", info);
//            return info;
//        }
//        catch (Exception ex)
//        {
//            Log.Error(ex, "Ошибка при загрузке информации");
//            return new User_info { name = "empty", lvl = 0, kristaliki = 0 };
//        }
//    }
//}

// DZ 07.02

//using System;
//using Serilog;
//class Program
//{
//    static void Main(string[] args)
//    {
//        Log.Logger = new LoggerConfiguration()
//            .MinimumLevel.Debug()
//            .WriteTo.Console()
//            .WriteTo.File("operation.log")
//            .CreateLogger();
//        Log.Information("program start");

//        Console.WriteLine();

//        try
//        {
//            double x = 15.2;
//            double y = 0;

//            double result_add = add(x, y);
//            Log.Information("{x} + {y} = {result_add}", x, y, result_add);

//            Console.WriteLine();

//            double result_minus = minus(x, y);
//            Log.Information("{x} - {y} = {result_minus}", x, y, result_minus);

//            Console.WriteLine();

//            double result_dilit = dilit(x, y);
//            if (y != 0)
//            {
//                Log.Warning("{x} / {y} = {result_dilit}", x, y, result_dilit);
//            }

//            Console.WriteLine();

//            double result_mnosh = mnosh(x, y);
//            Log.Information("{x} * {y} = {result_mnosh}", x, y, result_mnosh);
//        }
//        catch (Exception ex)
//        {
//            Log.Error(ex, " - err");
//        }
//        finally
//        {
//            Console.WriteLine();

//            Log.Information("program end");
//        }
//    }

//    static double add(double a, double b)
//    {
//        Log.Debug("operation {a} + {b}", a, b);
//        return a + b;
//    }

//    static double minus(double a, double b)
//    {
//        Log.Debug("operation {a} - {b}", a, b);
//        return a - b;
//    }

//    static double dilit(double a, double b)
//    {
//        try
//        {
//            Log.Debug("operation {a} / {b}", a, b);
//            if (b == 0)
//            {
//                throw new Exception("second numb is zero");
//            }
//            return a / b;
//        }
//        catch (Exception ex)
//        {
//            Log.Error(ex, " - err");
//            return 0;
//        }

//    }

//    static double mnosh(double a, double b)
//    {
//        Log.Debug("operation {a} * {b}", a, b);
//        return a * b;
//    }
//}

//using Serilog;
//using System.Text.Json;
//class Program
//{
//    class Zakaz
//    {
//        public List<Item> items { get; }

//        public Zakaz(List<Item> items)
//        {
//            this.items = items;
//        }

//        public double cost()
//        {
//            double cost = 0;
//            foreach (var item in items)
//            {
//                cost += item.cost * item.count;
//            }
//            return cost;
//        }

//        public bool pay()
//        {
//            bool sueccess = true;
//            foreach (var item in items)
//            {
//                if (item.pay())
//                {
//                    Log.Information("payed");
//                }
//                else
//                {
//                    Log.Error("not payed");
//                    sueccess = false;
//                }
//            }
//            return sueccess;
//        }
//    }

//    class Item
//    {
//        private string name;
//        public int count { get; }
//        public double cost { get; }

//        public Item(string name, int count, double cost)
//        {
//            this.name = name;
//            this.count = count;
//            this.cost = cost;
//        }

//        public bool pay()
//        {
//            if (String.IsNullOrEmpty(name))
//            {
//                Log.Error("Incorrect item name");
//                return false;
//            }
//            Log.Debug("paying x{count} {name}, cost of 1 is {cost}", count, name, cost);
//            if (count < 0)
//            {
//                Log.Error("Incorrect item count");
//                return false;
//            }
//            if (cost <= 0)
//            {
//                Log.Error("Incorrect item cost");
//                return false;
//            }
//            return true;
//        }
//    }

//    class Customer
//    {
//        private string name;
//        private double money;

//        public Customer(string name, double money)
//        {
//            this.name = name;
//            this.money = money;
//        }

//        public void pay(Zakaz zakaz)
//        {
//            if (zakaz.cost() > money)
//            {
//                Log.Error("money not enough");
//                return;
//            }
//            else
//            {
//                Log.Information("money enough");
//            }

//            if (zakaz.pay())
//            {
//                money -= zakaz.cost();
//                Log.Information("zakaz payed");
//                try
//                {
//                    File.WriteAllText("zakaz.json", JsonSerializer.Serialize(zakaz));
//                    Log.Information("serialized");
//                }
//                catch (Exception)
//                {
//                    Log.Information("not serialized");
//                }
//            }
//            else
//            {
//                Log.Information("zakaz not payed");
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        Log.Logger = new LoggerConfiguration()
//            .MinimumLevel.Debug()
//            .WriteTo.Console()
//            .WriteTo.File("operation.log")
//            .CreateLogger();
//        Log.Information("program start");

//        List<Item> items = new List<Item>();
//        items.Add(new Item("Bread", 2, 20));
//        items.Add(new Item("Milk", 2, 30));
//        items.Add(new Item("Cheese", 1, 40));

//        List<Item> items2 = new List<Item>();
//        items2.Add(new Item("Fishing Rod", 1, 10));
//        items2.Add(new Item("Fishing Line", 2, 15));
//        items2.Add(new Item("Hooks", 3, 20));
//        items2.Add(new Item("Bait", 2, 10));
//        items2.Add(new Item("Fishing Net", 2, 15));

//        Customer customer = new Customer("Vasya", 150.0);
//        customer.pay(new Zakaz(items));
//        customer.pay(new Zakaz(items2));

//        Log.Information("program end");
//    }
//}

// DZ BEFORE EXAM 14.02

//using Serilog;
//class Video
//{
//    public string title;
//    public int views;

//    public Video(string title)
//    {
//        this.title = title;
//        views = 0;
//    }
//}

//interface i_subscriber
//{
//    void update(string video_title);
//}

//class subscriber : i_subscriber
//{
//    private string name;

//    public subscriber(string name)
//    {
//        this.name = name;
//    }

//    public void update(string video_title)
//    {
//        Log.Information("{name} received a notification: {video_title}", name, video_title);
//    }

//    public void watch_video(ref youtube_channel channel, string title)
//    {
//        for (int i = 0; i < channel.videos.Count; i++)
//        {
//            if (channel.videos[i].title == title)
//            {
//                channel.videos[i].views++;
//                Log.Information("{name} watched video: {title}. Total views: {views}", name, title, channel.videos[i].views);
//                break;
//            }
//        }
//    }
//}

//class youtube_channel
//{
//    private List<i_subscriber> subscribers = new List<i_subscriber>();
//    public List<Video> videos = new List<Video>();
//    private string channel_name;

//    public youtube_channel(string name)
//    {
//        channel_name = name;
//    }

//    public void add_sub(i_subscriber subscriber)
//    {
//        subscribers.Add(subscriber);
//        Log.Information("new subscriber");
//    }

//    public void remove_sub(i_subscriber subscriber)
//    {
//        subscribers.Remove(subscriber);
//        Log.Warning("minus subscriber");
//    }

//    public void notify_subscribers(string title)
//    {
//        foreach (var subscriber in subscribers)
//        {
//            subscriber.update(title);
//        }
//    }

//    public void upload_video(string title)
//    {
//        videos.Add(new Video(title));
//        Log.Information("new video on {channel_name}: {title}", channel_name, title);
//        notify_subscribers(title);
//    }

//    public void remove_video(string title)
//    {
//        foreach(var it in videos)
//        {
//            if (it.title == title)
//            {
//                videos.Remove(it);
//                break;
//            }
//        }
//        Log.Information("removed video on {channel_name}: {title}", channel_name, title);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Log.Logger = new LoggerConfiguration()
//            .WriteTo.Console()
//            .CreateLogger();

//        youtube_channel channel = new youtube_channel("kodiki with ERRORS");
//        subscriber sub1 = new subscriber("dyadya1");
//        subscriber sub2 = new subscriber("dyadya2");

//        channel.add_sub(sub1);
//        channel.add_sub(sub2);

//        channel.upload_video("no errors");
//        sub1.watch_video(ref channel, "no errors");
//        sub2.watch_video(ref channel, "no errors");

//        channel.remove_sub(sub1);
//        channel.upload_video("i married on error");
//        sub2.watch_video(ref channel, "i married on error");
//    }
//}