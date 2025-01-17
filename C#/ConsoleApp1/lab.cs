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