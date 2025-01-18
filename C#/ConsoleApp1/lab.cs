
/*
    LAB
*/

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] numbers = { 1, 1, 5, 6, 8, 10, 2, 12, 21512, 12, 7, 14, 21, -7 };

//        var evenNumbersMethod = numbers.Where(num => num % 2 == 0);
//        Console.WriteLine("parn: " + string.Join(", ", evenNumbersMethod));

//        var notEvenNumbersMethod = numbers.Where(num => num % 2 != 0);
//        Console.WriteLine("ne parn: " + string.Join(", ", notEvenNumbersMethod));

//        int a = 5;
//        var bilsh_zadan = numbers.Where(num => num > a);
//        Console.WriteLine("bilsh_zadan: " + string.Join(", ", bilsh_zadan));

//        int frst = 3;
//        int sec = 10;
//        var diapazon = numbers.Where(num => num > frst && num < sec);
//        Console.WriteLine("diapazon: " + string.Join(", ", diapazon));

//        var kr7_sort = numbers.Where(num => num % 7 == 0).OrderBy(n => n);
//        Console.WriteLine("kr7_sort: " + string.Join(", ", kr7_sort));

//        var kr8_sortSpad = numbers.Where(num => num % 8 == 0).OrderByDescending(n => n);
//        Console.WriteLine("kr8_sortSpad: " + string.Join(", ", kr8_sortSpad));
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] cities = { "Kyiv", "Lviv", "Odesa", "Kharkiv", "Dnipro", "Chernivtsi", "Mykolaiv", "Zaporizhzhia", "Nizhyn", "Nemyriv", "Kramatorsk" };

//        var all = cities.Select(city => city);
//        Console.WriteLine("all: " + string.Join(", ", all));

//        int l = 4;
//        var cities_length = cities.Where(city => city.Length == l);
//        Console.WriteLine($"cities_length: " + string.Join(", ", cities_length));

//        var cities_A = cities.Where(city => city.StartsWith("A"));
//        Console.WriteLine("cities_A: " + string.Join(", ", cities_A));

//        var cities_M = cities.Where(city => city.EndsWith("m"));
//        Console.WriteLine("cities_M: " + string.Join(", ", cities_M));

//        var cities_N_K = cities.Where(city => city.StartsWith("N") && city.EndsWith("k"));
//        Console.WriteLine("cities_N_K: " + string.Join(", ", cities_N_K));

//        var cities_Ne = cities.Where(city => city.StartsWith("Ne")).OrderByDescending(city => city);
//        Console.WriteLine("cities_Ne: " + string.Join(", ", cities_Ne));
//    }
//}

//class Student
//{
//    public string first_name { get; }
//    public string last_name { get; }
//    public int age {  get; }
//    public string university { get; }

//    public Student(string first_name, string last_name, int age, string university)
//    {
//        this.first_name = first_name;
//        this.last_name = last_name;
//        this.age = age;
//        this.university = university;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student[] students = {
//            new Student("Boris", "Brown", 21, "MIT"),
//            new Student("Alice", "Brooks", 19, "Oxford"),
//            new Student("Boris", "Johnson", 22, "Harvard"),
//            new Student("Diana", "Smith", 20, "MIT"),
//            new Student("John", "Brody", 23, "Oxford"),
//            new Student("Emily", "Clark", 18, "Stanford")
//        };

//        var all = students.Select(student => student);
//        Console.WriteLine("all:\n");
//        foreach (Student student in all)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var boris = students.Where(student => student.first_name == "Boris");
//        Console.WriteLine("\nboris:\n");
//        foreach (Student student in boris)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var bro = students.Where(student => student.last_name.StartsWith("Bro"));
//        Console.WriteLine("\nbro:\n");
//        foreach (Student student in bro)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var older19 = students.Where(student => student.age > 19);
//        Console.WriteLine("\nolder19:\n");
//        foreach (Student student in older19)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var _20_23 = students.Where(student => student.age > 20 && student.age < 23);
//        Console.WriteLine("\n_20_23:\n");
//        foreach (Student student in _20_23)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var mit = students.Where(student => student.university == "MIT");
//        Console.WriteLine("\nmit:\n");
//        foreach (Student student in mit)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }

//        var oxford18 = students.Where(student => student.university == "Oxford" && student.age > 18).OrderByDescending(student => student.age);
//        Console.WriteLine("\noxford18:\n");
//        foreach (Student student in oxford18)
//        {
//            Console.WriteLine("\t" + student.first_name + " " + student.last_name + "\n");
//        }
//    }
//}

/*
    DZ
*/

//class Company
//{
//    public string name { get; }
//    public DateTime date { get; }
//    public string profile { get; }
//    public string director_name { get; }
//    public int emp_count { get; }
//    public string address { get; }

//    public Company(string name, DateTime date, string profile, string director_name, int emp_count, string address)
//    {
//        this.name = name;
//        this.date = date;
//        this.profile = profile;
//        this.director_name = director_name;
//        this.emp_count = emp_count;
//        this.address = address;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Company[] companies = {
//            new Company("FoodTech Solutions", new DateTime(2019, 5, 1), "Marketing", "John White", 120, "London"),
//            new Company("White IT", new DateTime(2023, 1, 15), "IT", "Michael Black", 250, "New York"),
//            new Company("Global Foods", new DateTime(2020, 8, 25), "Food Production", "Sarah Green", 80, "London"),
//            new Company("Digital Market Co", new DateTime(2018, 11, 3), "Marketing", "Alice Brown", 300, "Paris"),
//            new Company("EcoWhite Tech", new DateTime(2021, 3, 12), "IT", "George White", 95, "Berlin")
//        };

//        var all = companies.Select(company => company);
//        Console.WriteLine("\nall:\n");
//        foreach (var c in all)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var food = companies.Where(company => company.name.Contains("Food"));
//        Console.WriteLine("\nfood:\n");
//        foreach (var c in food)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var marketing = companies.Where(company => company.profile == "Marketing");
//        Console.WriteLine("\nmarketing:\n");
//        foreach (var c in marketing)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var marketing_it = companies.Where(company => company.profile == "Marketing" || company.profile == "IT");
//        Console.WriteLine("\nmarketing_it:\n");
//        foreach (var c in marketing_it)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var more100 = companies.Where(company => company.emp_count > 100);
//        Console.WriteLine("\nmore100:\n");
//        foreach (var c in more100)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var _100_300 = companies.Where(company => company.emp_count > 100 && company.emp_count < 300);
//        Console.WriteLine("\n_100_300:\n");
//        foreach (var c in _100_300)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var london = companies.Where(company => company.address == "London");
//        Console.WriteLine("\nlondon:\n");
//        foreach (var c in london)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var dir_white = companies.Where(company => company.director_name.Split(' ')[1] == "White");
//        Console.WriteLine("\ndir_white:\n");
//        foreach (var c in dir_white)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var older_2years = companies.Where(company => (DateTime.Now - company.date).TotalDays > 2 * 365);
//        Console.WriteLine("\nolder_2years:\n");
//        foreach (var c in older_2years)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var ago_123days = companies.Where(company => (DateTime.Now - company.date).TotalDays == 123);
//        Console.WriteLine("\nago_123days:\n");
//        foreach (var c in ago_123days)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }

//        var blackDir_whiteName = companies.Where(company => company.director_name.Split(' ')[1] == "Black" && company.name.Contains("White"));
//        Console.WriteLine("\nblackDir_whiteName:\n");
//        foreach (var c in blackDir_whiteName)
//        {
//            Console.WriteLine("\t" + c.name + "\n");
//        }
//    }
//}