﻿
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