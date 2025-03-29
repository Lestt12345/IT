//string name;
//int l;
//int total_water = 0;
//Console.Write($"what is your name? ");
//name = Console.ReadLine();
//while (true)
//{
//    for (int i = 0; i < 3; i++)
//    {
//        Console.Write($"how much mililiters you drank? ");
//        l = Convert.ToInt32(Console.ReadLine());
//        total_water += l;
//        Console.WriteLine($"{name} drank {l}l");
//    }
//    if (total_water < 2000)
//    {
//        Console.WriteLine("drink more\n");
//    }
//    else
//    {
//        Console.WriteLine("you feeling good\n");
//    }
//    total_water = 0;
//}
//static void Main(string[] args)
//{

//}

//------------------------------------------------------------------------------------------------------------------------

//int[] numbers = { 1,2,3,4,5,6,7,87,9,0 };
//int count = 0;
//Console.Write("input number: ");
//int numb = Convert.ToInt32(Console.ReadLine());
//foreach (int n in numbers)
//{
//    if (n < numb)
//    {
//        count++;
//    }
//}
//Console.WriteLine($"count of numb under {numb}: {count}");

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 87, 9, 0, 2, 3, 1, };
//int count_parn = 0;
//int count_neParn = 0;
//int count_unik = 0;
//foreach (int n in numbers)
//{
//    if (n % 2 == 0)
//    {
//        count_parn++;
//    }
//    else
//    {
//        count_neParn++;
//    }
//    int tmp = 0;
//    foreach (int n2 in numbers)
//    {
//        if (n != n2)
//        {
//            tmp++;
//        }
//    }
//    if (tmp == numbers.Length - 1)
//    {
//        count_unik++;
//    }
//}
//Console.WriteLine($"parn: {count_parn}\nneparn: {count_neParn}\nunikaln: {count_unik}");

//int[] arr1 = { 1, 2 };
//int[] arr2 = { 1, 3 };
//int[] arr_tmp = new int[100];
//int cur_ind = 0;
//foreach (int a1 in arr1)
//{
//    bool is_common = false;
//    foreach (int a2 in arr2)
//    {
//        if (a1 == a2) // есть ли элемент с arr1 есть в arr2
//        {
//            is_common = true;
//            break;
//        }
//    }
//    if (!is_common) // если элемента с arr1 нет в arr2
//    {
//        arr_tmp[cur_ind] = a1;
//        cur_ind++;
//    }
//}
//foreach (int a2 in arr2)
//{
//    bool is_common = false;
//    foreach (int a1 in arr1)
//    {
//        if (a2 == a1) // есть ли элемент с arr2 есть в arr1
//        {
//            is_common = true;
//            break;
//        }
//    }
//    if (!is_common) // если элемента с arr2 нет в arr1
//    {
//        arr_tmp[cur_ind] = a2;
//        cur_ind++;
//    }
//}
//int[] arr3 = new int[cur_ind];
//Array.Copy(arr_tmp, arr3, cur_ind);
//foreach (int a3 in arr3)
//{
//    Console.Write($"{a3}  ");
//}

//Console.Write("input sentence: ");
//string sentence = Console.ReadLine();
//string[] words = sentence.Split(' ');
//Console.WriteLine($"count words: {words.Length}");

//int vowel_сount = 0;
//string vowels = "aeiouyAEIOUY";
//foreach (char c in sentence)
//{
//    if (vowels.Contains(c))
//    {
//        vowel_сount++;
//    }
//}
//Console.WriteLine($"number of vowels: {vowel_сount}");

//Console.Write("input word: ");
//string word = Console.ReadLine();
//int words_count = 0;
//int index = 0;
//while ((index = sentence.IndexOf(word, index)) != -1)
//{
//    words_count++;
//    sentence = sentence.Remove(index, word.Length);
//}
//Console.WriteLine($"number of {word}: {words_count}");

//------------------------------------------------------------------------------------------------------------------------

//class Car
//{
//    private string name;
//    private int year;
//    public Car(string n, int y)
//    {
//        name = n;
//        year = y;
//    }
//    public void info()
//    {
//        Console.WriteLine($"car: {name}\nyear: {year}");
//    }
//}

//class Book
//{
//    private string title;
//    private string author;
//    private int year;
//    public Book(string t, string a, int y)
//    {
//        if (y < 1450)
//        {
//            title = "err";
//            author = "err";
//            year = 0;
//        }
//        else
//        {
//            title = t;
//            author = a;
//            year = y;
//        }
//    }
//    public void info()
//    {
//        Console.WriteLine($"title: {title}\nauthor: {author}\nyear: {year}");
//    }
//}

//class TempConv
//{
//    public static double to_celsius(double f)
//    {
//        return (f - 32) * 5 / 9;
//    }

//    public static double to_fahrenheit(double c)
//    {
//        return (c * 9 / 5) + 32;
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Car car = new Car("toyota", 2000);
//        car.info();
//        Console.WriteLine("________________________________");
//        Book[] books = { new Book("t1", "y1", 1800), new Book("t2", "y2", 1400) };
//        foreach (Book book in books)
//        {
//            book.info();
//        }
//        Console.WriteLine("________________________________");
//        Console.WriteLine($"123°F = {TempConv.to_celsius(123)}°C");
//        Console.WriteLine($"-2°C = {TempConv.to_fahrenheit(-2)}°F");
//    }
//}

//class Employee
//{
//    public string name;
//    public double salary;

//    public Employee(string n, double s)
//    {
//        name = n;
//        salary = s;
//    }

//    public virtual void ShowInfo()
//    {
//        Console.WriteLine($"Name: {name}\nSalary: {salary}");
//    }
//}

//class Manager : Employee
//{
//    private string department;

//    public Manager(string n, double s, string d) : base(n, s)
//    {
//        department = d;
//    }

//    public override void ShowInfo()
//    {
//        Console.WriteLine($"name: {name}\nsalary: {salary}\ndepartment: {department}");
//    }
//}

//class Developer : Employee
//{
//    private string prog_lang;

//    public Developer(string n, double s, string p) : base(n, s)
//    {
//        prog_lang = p;
//    }

//    public override void ShowInfo()
//    {
//        Console.WriteLine($"name: {name}\nsalary: {salary}\nprogramming language: {prog_lang}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Employee[] employees = { new Manager("n1", 30000, "d1"), new Developer("n2", 99999999, "C#") };

//        foreach (Employee employee in employees)
//        {
//            employee.ShowInfo();
//            Console.WriteLine();
//        }
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    static void Main()
//    {
//        //1
//        Console.Write("number: ");
//        int user_number = Convert.ToInt32(Console.ReadLine());
//        if (user_number < 1 || user_number > 100)
//        {
//            Console.WriteLine("error");
//        }
//        else
//        {
//            if (user_number % 3 == 0 && user_number % 5 == 0)
//            {
//                Console.WriteLine("Fizz Buzz");
//            }
//            else if (user_number % 3 == 0)
//            {
//                Console.WriteLine("Fizz");
//            }
//            else if (user_number % 5 == 0)
//            {
//                Console.WriteLine("Buzz");
//            }
//            else
//            {
//                Console.WriteLine(user_number);
//            }
//        }

//        //2
//        Console.WriteLine();
//        Console.Write("value: ");
//        double value = Convert.ToDouble(Console.ReadLine());
//        Console.Write("proc: ");
//        double proc = Convert.ToDouble(Console.ReadLine());
//        Console.WriteLine($"{proc}% of {value} = {value * proc / 100}");

//        //3
//        Console.WriteLine();
//        Console.Write("digit 1: ");
//        int d1 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("digit 2: ");
//        int d2 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("digit 3: ");
//        int d3 = Convert.ToInt32(Console.ReadLine());
//        Console.Write("digit 4: ");
//        int d4 = Convert.ToInt32(Console.ReadLine());
//        int formed_number = d1 * 1000 + d2 * 100 + d3 * 10 + d4;
//        Console.WriteLine($"formed number: {formed_number}");

//        //4
//        Console.WriteLine();
//        Console.Write("number: ");
//        int numb = Convert.ToInt32(Console.ReadLine());
//        if (numb >= 100000 && numb <= 999999)
//        {
//            int d_1 = numb / 100000;
//            int d_6 = numb % 10;
//            numb -= d_1 * 100000;
//            numb += d_6 * 100000;
//            numb -= d_6;
//            numb += d_1;
//            Console.WriteLine($"number: {numb}");
//        }
//        else
//        {
//            Console.WriteLine("error");
//        }

//        //5
//        Console.WriteLine();
//        Console.Write("input date (DD.MM.YYYY): ");
//        DateTime date = DateTime.Parse(Console.ReadLine());
//        string season;
//        if (date.Month >= 3 && date.Month <= 5)
//        {
//            season = "spring";
//        }
//        else if (date.Month >= 6 && date.Month <= 8)
//        {
//            season = "summer";
//        }
//        else if (date.Month >= 9 && date.Month <= 11)
//        {
//            season = "autumn";
//        }
//        else
//        {
//            season = "winter";
//        }
//        string day_of_week = date.DayOfWeek.ToString();
//        Console.WriteLine($"{season} {day_of_week}");

//        //6
//        Console.WriteLine();
//        Console.Write("temperature: ");
//        double temper = Convert.ToDouble(Console.ReadLine());
//        Console.Write("1. fahrenheit to celsius\n2. celsius to fahrenheit\nchoose: ");
//        int choice = Convert.ToInt32(Console.ReadLine());
//        if (choice == 1)
//        {
//            Console.WriteLine($"{temper}°F = {(temper - 32) * 5 / 9}°C");
//        }
//        else if (choice == 2)
//        {
//            Console.WriteLine($"{temper}°C = {(temper * 9 / 5) + 32}°F");
//        }
//        else
//        {
//            Console.WriteLine("error");
//        }

//        //7
//        Console.WriteLine();
//        Console.Write("start: ");
//        int start = Convert.ToInt32(Console.ReadLine());
//        Console.Write("end: ");
//        int end = Convert.ToInt32(Console.ReadLine());
//        if (start > end)
//        {
//            for (int i = end; i < start + 1; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }
//        for (int i = start; i < end + 1; i++)
//        {
//            if (i % 2 == 0)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Task
//{
//    public void draw_square(int length, char symbol)
//    {
//        for (int i = 0; i < length; i++)
//        {
//            for (int j = 0; j < length; j++)
//            {
//                Console.Write(symbol);
//            }
//            Console.WriteLine();
//        }
//    }

//    public bool is_palindrome(int number)
//    {
//        string num = number.ToString();
//        string reversed_num = new string(num.ToCharArray().Reverse().ToArray());
//        return num == reversed_num;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Task task = new Task();

//        Console.Write("lenght: ");
//        int length = Convert.ToInt32(Console.ReadLine());
//        Console.Write("symbol: ");
//        char symbol = Convert.ToChar(Console.ReadLine());
//        Console.WriteLine();
//        task.draw_square(length, symbol);

//        Console.WriteLine();

//        Console.Write("numb: ");
//        int number = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine(task.is_palindrome(number));
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Task
//{
//    public bool isEven(int a)
//    {
//        return a % 2 == 0;
//    }

//    public void printText(string text, int count)
//    {
//        for (int i = 0; i < count; i++)
//        {
//            Console.WriteLine(text);
//        }
//    }

//    public int find_max(int a, int b, int c)
//    {
//        if (a > b && a > c)
//        {
//            return a;
//        }
//        else if (b > a && b > c)
//        {
//            return b;
//        }
//        else if (c > a && c > b)
//        {
//            return c;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    public int sumArray(int[] arr)
//    {
//        int sum = 0;
//        foreach (int i in arr)
//        {
//            sum += i;
//        }
//        return sum;
//    }
//}

//class City
//{
//    public string city_name { get; set; }
//    public string country_name { get; set; }
//    public int population {  get; set; }
//    public int phone_code { get; set; }
//    public List<string> districts { get; set; } = new List<string>();

//    public void set_info()
//    {
//        Console.Write("enter city name: ");
//        city_name = Console.ReadLine();
//        Console.Write("enter country name: ");
//        country_name = Console.ReadLine();
//        Console.Write("enter population: ");
//        population = Convert.ToInt32(Console.ReadLine());
//        Console.Write("enter phone code: ");
//        phone_code = Convert.ToInt32(Console.ReadLine());
//        Console.Write("enter coutn of districts: ");
//        int districts_count = Convert.ToInt32(Console.ReadLine());
//        string district;
//        for (int i = 0; i < districts_count; i++)
//        {
//            Console.Write("enter district: ");
//            district = Console.ReadLine();
//            districts.Add(district);
//        }
//    }

//    public void info()
//    {
//        Console.WriteLine($"city Name: {city_name}");
//        Console.WriteLine($"country Name: {country_name}");
//        Console.WriteLine($"population: {population}");
//        Console.WriteLine($"phone Code: {phone_code}");
//        Console.Write("districts: ");
//        foreach (string district in districts)
//        {
//            Console.Write($"{district}, ");
//        }
//        Console.WriteLine("\b\b.");
//    }
//}

//class Card
//{
//    private int number;
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Task t1= new Task();
//        Console.WriteLine(t1.isEven(3));
//        t1.printText("asd", 3);
//        Console.WriteLine(t1.find_max(3, 2, 11));
//        int[] arr = { 3, 2, 1 };
//        Console.WriteLine(t1.sumArray(arr));

//        Console.WriteLine();

//        City c1 = new City();
//        c1.set_info();
//        c1.info();
//    }
//}

//class Card
//{
//    private long number;
//    private string full_name;
//    private int cvc;
//    private DateTime expiry_date;

//    public Card()
//    {
//        Console.Write("card number: ");
//        number = Convert.ToInt64(Console.ReadLine());
//        if (number < 1000000000000000 || number > 9999999999999999)
//        {
//            number = 0;
//        }
//        Console.Write("full name: ");
//        full_name = Console.ReadLine();
//        Console.Write("cvc: ");
//        cvc = Convert.ToInt32(Console.ReadLine());
//        if (number < 100 || number > 999)
//        {
//            cvc = 0;
//        }
//        Console.Write("expiry date (YYYY-MM-DD): ");
//        expiry_date = Convert.ToDateTime(Console.ReadLine());
//    }

//    public long get_number()
//    {
//        return number;
//    }

//    public string get_fullName()
//    {
//        return full_name;
//    }

//    public int get_cvc()
//    {
//        return cvc;
//    }

//    public DateTime get_expiryDate()
//    {
//        return expiry_date;
//    }

//    public void info()
//    {
//        Console.WriteLine($"card number: {number}");
//        Console.WriteLine($"full name: {full_name}");
//        Console.WriteLine($"cvc: ne pokashu :)");
//        Console.WriteLine($"expiry date: {expiry_date.ToShortDateString()}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Card c1 = new Card();
//        c1.info();
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    class Member
//    {
//        private string name;
//        private enum Role
//        {
//            admin = 1,
//            moder,
//            user
//        }
//        Role role;
//        private bool mega_prava;
//        private bool edit_posts;
//        private bool read_posts;

//        public void input_info()
//        {
//            Console.Write("name: ");
//            name = Console.ReadLine();
//            Console.Write("1 - admin\n2 - moder\n3 - user\nchoose: ");
//            role = (Role)Convert.ToInt32(Console.ReadLine());
//            if (role == Role.admin)
//            {
//                mega_prava = true;
//                edit_posts = true;
//                read_posts = true;
//            }
//            else if (role == Role.moder)
//            {
//                mega_prava = false;
//                edit_posts = true;
//                read_posts = true;
//            }
//            else if (role == Role.user)
//            {
//                mega_prava = false;
//                edit_posts = false;
//                read_posts = true;
//            }
//            else
//            {
//                role = 0;
//                mega_prava = false;
//                edit_posts = false;
//                read_posts = false;
//            }
//        }

//        public void info()
//        {
//            Console.WriteLine($"name: {name}\nrole: {role}\n\tmega_prava: {mega_prava}\n\tedit_posts: {edit_posts}\n\tread_posts: {read_posts}"); // сори что в одну строку :))
//        }
//    }
//    static void Main(string[] args)
//    {
//        Member m1 = new Member();
//        m1.input_info();
//        Console.WriteLine();
//        m1.info();
//    }
//}

//class Program
//{
//    enum DaysOfWeek
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday
//    }

//    static void print_day(int numb)
//    {
//        foreach (int day in Enum.GetValues(typeof(DaysOfWeek)))
//        {
//            if (numb == day)
//            {
//                Console.WriteLine((DaysOfWeek)day);
//                return;
//            }
//        }
//        Console.WriteLine("error");
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("enter number of day: ");
//        int numb = Convert.ToInt32(Console.ReadLine());
//        print_day(numb);
//    }
//}

//class Program
//{
//    enum Months
//    {
//        January = 1,
//        February,
//        March,
//        April,
//        May,
//        June,
//        July,
//        August,
//        September,
//        October,
//        November,
//        December
//    }

//    static void print_season(Months month)
//    {
//        if ((month >= Months.January && month <= Months.February) || month == Months.December)
//        {
//            Console.WriteLine("winter");
//        }
//        else if (month >= Months.March && month <= Months.May)
//        {
//            Console.WriteLine("spring");
//        }
//        else if (month >= Months.June && month <= Months.August)
//        {
//            Console.WriteLine("summer");
//        }
//        else if (month >= Months.September && month <= Months.November)
//        {
//            Console.WriteLine("autumn");
//        }
//        else
//        {
//            Console.WriteLine("error");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("enter month: ");
//        Months month = (Months)Enum.Parse(typeof(Months), Console.ReadLine(), true); // ну не моя строчка, зато можно и так и так писать)
//        print_season(month);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int? a = null;
//        try
//        {
//            a = Convert.ToInt32(Console.ReadLine());
//        }
//        catch { }
//        finally
//        {
//            if (a.HasValue)
//            {
//                Console.WriteLine(a);
//            }
//            else
//            {
//                Console.WriteLine("null");
//            }
//        }
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    static int rom_to_int(string rom)
//    {
//        if (rom.Length > 15)
//        {
//            return 0;
//        }
//        int integeR = 0;
//        int maxNumb_ind = 0;
//        int maxNumb = 0;
//        for (int i = 0; i < rom.Length; i++)
//        {
//            switch (rom[i])
//            {
//                case 'I':
//                    if (1 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 1;
//                    }
//                    break;
//                case 'V':
//                    if (5 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 5;
//                    }
//                    break;
//                case 'X':
//                    if (10 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 10;
//                    }
//                    break;
//                case 'L':
//                    if (50 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 50;
//                    }
//                    break;
//                case 'C':
//                    if (100 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 100;
//                    }
//                    break;
//                case 'D':
//                    if (500 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 500;
//                    }
//                    break;
//                case 'M':
//                    if (1000 > maxNumb)
//                    {
//                        maxNumb_ind = i;
//                        maxNumb = 1000;
//                    }
//                    break;
//                default:
//                    return 0;
//            }
//        }
//        for (int i = maxNumb_ind; i < rom.Length; i++)
//        {
//            switch (rom[i])
//            {
//                case 'I':
//                    integeR += 1;
//                    break;
//                case 'V':
//                    integeR += 5;
//                    break;
//                case 'X':
//                    integeR += 10;
//                    break;
//                case 'L':
//                    integeR += 50;
//                    break;
//                case 'C':
//                    integeR += 100;
//                    break;
//                case 'D':
//                    integeR += 500;
//                    break;
//                case 'M':
//                    integeR += 1000;
//                    break;
//            }
//        }
//        for (int i = 0; i < maxNumb_ind; i++)
//        {
//            switch (rom[i])
//            {
//                case 'I':
//                    integeR -= 1;
//                    break;
//                case 'V':
//                    integeR -= 5;
//                    break;
//                case 'X':
//                    integeR -= 10;
//                    break;
//                case 'L':
//                    integeR -= 50;
//                    break;
//                case 'C':
//                    integeR -= 100;
//                    break;
//                case 'D':
//                    integeR -= 500;
//                    break;
//                case 'M':
//                    integeR -= 1000;
//                    break;
//            }
//        }
//        return integeR;
//    }

//    static void Main(string[] args)
//    {
//        string rom = "IvLiX"; //как надо: 50 + 9 - 4 = 45, в моем коде: 50 + 1 + 10 - 1 - 5 = 55
//        rom = rom.ToUpper();
//        Console.WriteLine(rom_to_int(rom));
//    }
//}

//class Program
//{
//    public class Car
//    {
//        private string mark;
//        private string model;
//        private int year;

//        public string Mark
//        {
//            get
//            {
//                return mark;
//            }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("mark empty");
//                }
//                mark = value;
//            }
//        }

//        public string Model
//        {
//            get
//            {
//                return model;
//            }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("model empty");
//                }
//                model = value;
//            }
//        }

//        public int Year
//        {
//            get
//            {
//                return year;
//            }
//            set
//            {
//                if (value < 1886 || value > DateTime.Now.Year)
//                {
//                    throw new ArgumentException($"year not on 1886 - {DateTime.Now.Year}");
//                }
//                year = value;
//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        Car c1 = new Car();
//        Console.Write("mark: ");
//        c1.Mark = Console.ReadLine();
//        Console.Write("model: ");
//        c1.Model = Console.ReadLine();
//        Console.Write("year: ");
//        c1.Year = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine();
//        Console.WriteLine($"{c1.Mark}\n{c1.Model}\n{c1.Year}");
//    }
//}

//class Program
//{
//    class Circle
//    {
//        private int radius;
//        private int diameter;
//        private double area;
//        private double circumference;

//        public int Radius
//        {
//            get
//            {
//                return radius;
//            }
//            set
//            {
//                if (value < 0)
//                {
//                    throw new ArgumentException("< 0");
//                }
//                radius = value;
//                diameter = 2 * radius;
//                area = Math.PI * (radius * radius);
//                circumference = 2 * Math.PI * radius;
//            }
//        }

//        public int Diameter
//        {
//            get
//            {
//                return diameter;
//            }
//        }

//        public double Area
//        {
//            get
//            {
//                return area;
//            }
//        }

//        public double Circumference
//        {
//            get
//            {
//                return circumference;
//            }
//        }
//    }
//    static void Main(string[] args)
//    {
//        Circle c1 = new Circle();
//        Console.Write("radius: ");
//        c1.Radius = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine();
//        Console.WriteLine($"radius: {c1.Radius}");
//        Console.WriteLine($"diameter: {c1.Diameter}");
//        Console.WriteLine($"area: {c1.Area}");
//        Console.WriteLine($"circumference: {c1.Circumference}");
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    class Book_list
//    {
//        private List<string> books = new List<string>();

//        public string Books
//        {
//            get
//            {
//                if (books.Count == 0)
//                {
//                    return "empty";
//                }
//                else
//                {
//                    string all_books = "";
//                    foreach (string book in books)
//                    {
//                        all_books += book + ", ";
//                    }
//                    all_books.Trim(); //.Trim() мне vs посоветовал :)
//                    return all_books + "\b\b.";
//                }
//            }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("name empty");
//                }
//                books.Add(value);
//            }
//        }

//        public void del_book(string book)
//        {
//            foreach (string b in books)
//            {
//                if (b == book)
//                {
//                    books.Remove(b);
//                    return;
//                }
//            }
//            Console.WriteLine("error");
//        }

//        public bool srch_book(string book)
//        {
//            foreach (string b in books)
//            {
//                if (b == book)
//                {
//                    return true;
//                }
//            }
//            return false;
//        }
//    }

//    static Book_list menu(Book_list bl1)
//    {
//        while (true)
//        {
//            string name;
//            Console.Clear();
//            Console.WriteLine("1 - add");
//            Console.WriteLine("2 - delete");
//            Console.WriteLine("3 - search");
//            Console.WriteLine("4 - view all");
//            Console.WriteLine("0 - exit");
//            Console.Write("choose: ");
//            int ch = Convert.ToInt32(Console.ReadLine());
//            switch (ch)
//            {
//                case 1:
//                    Console.Write("name: ");
//                    name = Console.ReadLine();
//                    try
//                    {
//                        bl1.Books = name;
//                    }
//                    catch (ArgumentException ex)
//                    {
//                        Console.WriteLine(ex.Message);
//                    }
//                    break;
//                case 2:
//                    Console.Write("name: ");
//                    name = Console.ReadLine();
//                    bl1.del_book(name);
//                    break;
//                case 3:
//                    Console.Write("name: ");
//                    name = Console.ReadLine();
//                    Console.WriteLine(bl1.srch_book(name));
//                    break;
//                case 4:
//                    Console.WriteLine(bl1.Books);
//                    break;
//                case 0:
//                    return bl1;
//                default:
//                    Console.WriteLine("error");
//                    break;
//            }
//            Console.Write("press any key...");
//            Console.ReadKey(); // это что за пушкаа
//        }
//    }
//    static void Main(string[] args)
//    {
//        Book_list bl1 = new Book_list();
//        menu(bl1);
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    public class Weather
//    {
//        public int temp { get; set; }
//        public int wind { get; set; }
//        public int cloudy { get; set; }

//        public virtual void flight_stat()
//        {
//            Console.WriteLine("сhecking flight status");
//        }

//        public virtual void info()
//        {
//            Console.WriteLine($"temp: {temp}С");
//            Console.WriteLine($"wind: {wind}m/s");
//            Console.WriteLine($"cloudy: {cloudy}%");
//        }
//    }

//    public class Spring : Weather
//    {
//        public override void flight_stat()
//        {
//            if (cloudy > 70)
//            {
//                Console.WriteLine("ne kakih flights dyadya");
//            }
//            else
//            {
//                Console.WriteLine("flights allowed");
//            }
//        }
//    }

//    public class Summer : Weather
//    {
//        public override void flight_stat()
//        {
//            if (temp > 35)
//            {
//                Console.WriteLine("ne kakih flights dyadya");
//            }
//            else
//            {
//                Console.WriteLine("flights allowed");
//            }
//        }
//    }

//    public class Autumn : Weather
//    {
//        public override void flight_stat()
//        {
//            if (cloudy > 70)
//            {
//                Console.WriteLine("ne kakih flights dyadya");
//            }
//            else
//            {
//                Console.WriteLine("flights allowed");
//            }
//        }
//    }

//    public class Winter : Weather
//    {
//        public bool is_snow { get; set; }

//        public override void flight_stat()
//        {
//            if (is_snow || cloudy > 70)
//            {
//                Console.WriteLine("ne kakih flights dyadya");
//            }
//            else
//            {
//                Console.WriteLine("flights allowed");
//            }
//        }

//        public override void info()
//        {
//            base.info();
//            Console.WriteLine($"snow: {is_snow}");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Winter w1 = new Winter();
//        Console.Write("temp: ");
//        w1.temp = Convert.ToInt32(Console.ReadLine());
//        Console.Write("wind: ");
//        w1.wind = Convert.ToInt32(Console.ReadLine());
//        Console.Write("cloudy: ");
//        w1.cloudy = Convert.ToInt32(Console.ReadLine());
//        Console.Write("is snow: ");
//        w1.is_snow = Convert.ToBoolean(Console.ReadLine());
//        Console.Clear();
//        w1.flight_stat();
//    }
//}

//class Program
//{
//    public class Payment
//    {
//        public virtual void Pay(int amount)
//        {
//            Console.WriteLine("pay method");
//        }
//    }

//    public class CardPayment : Payment
//    {
//        public int bank { get; set; }

//        public override void Pay(int amount)
//        {
//            if (bank >= amount)
//            {
//                bank -= amount;
//            }
//            else
//            {
//                Console.WriteLine("error");
//            }
//        }
//    }

//    public class CashPayment : Payment
//    {
//        public int vallet { get; set; }

//        public override void Pay(int amount)
//        {
//            if (vallet >= amount)
//            {
//                vallet -= amount;
//            }
//            else
//            {
//                Console.WriteLine("error");
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        CardPayment c1 = new CardPayment();
//        CashPayment c2 = new CashPayment();
//        c1.bank = 12;
//        c2.vallet = 5;
//        c1.Pay(11);
//        c2.Pay(11);
//    }
//}

//public delegate int MathOperation(int a, int b);

//class Program
//{
//    public static int Add(int a, int b)
//    {
//        return a + b;
//    }

//    public static int Subtract(int a, int b)
//    {
//        return a - b;
//    }

//    public static int umnosh(int a, int b)
//    {
//        return a * b;
//    }

//    public static int dil(int a, int b)
//    {
//        if (b == 0)
//        {
//            throw new Exception($"{a} / {b} = error");
//        }
//        return a / b;
//    }

//    static void Main(string[] args)
//    {
//        MathOperation operation;

//        operation = Add;
//        Console.WriteLine($"result: {operation(4, 2)}");

//        operation = Subtract;
//        Console.WriteLine($"result: {operation(4, 2)}");

//        operation = umnosh;
//        Console.WriteLine($"result: {operation(4, 2)}");

//        operation = dil;
//        Console.WriteLine($"result: {operation(4, 2)}");
//    }
//}

//class Program
//{
//    static void timer(int seconds)
//    {
//        for (int i = 0; i < seconds; i++)
//        {
//            Thread.Sleep(1000);
//            Console.WriteLine($"{i + 1} seconds elapsed...");
//        }
//        Console.WriteLine("done");
//    }
//    static void Main(string[] args)
//    {
//        timer(10);
//    }
//}

//using System.Threading;

//public class TimerEventArgs : EventArgs
//{
//    public int SecondsElapsed { get; }

//    public TimerEventArgs(int secondsElapsed)
//    {
//        SecondsElapsed = secondsElapsed;
//    }
//}

//public class Timer
//{
//    // 
//    public event EventHandler<TimerEventArgs> Tick; // Подія "Тікання" 
//    public event EventHandler Completed;           // Подія "Завершення" 

//    private readonly int _duration;

//    public Timer(int durationInSeconds)
//    {
//        _duration = durationInSeconds;
//    }

//    public void Start()
//    {
//        Console.WriteLine("Таймер розпочав роботу...");

//        for (int i = 1; i <= _duration; i++)
//        {
//            Thread.Sleep(1000); // Очікуємо 1 секунду 

//            // Викликаємо подію Tick 
//            Tick?.Invoke(this, new TimerEventArgs(i));
//        }

//        // Викликаємо подію Completed 
//        Completed?.Invoke(this, EventArgs.Empty);
//    }
//}

//public class TimerSubscriber
//{
//    public void OnTick(object sender, TimerEventArgs e)
//    {
//        Console.WriteLine($"Тік-так: {e.SecondsElapsed} секунд пройшло");
//    }

//    public void OnCompleted(object sender, EventArgs e)
//    {
//        Console.WriteLine("Таймер завершив роботу!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Timer timer = new Timer(7); // Таймер на 5 секунд 
//        TimerSubscriber subscriber = new TimerSubscriber();

//        // Підписка на події 
//        timer.Tick += subscriber.OnTick;
//        timer.Completed += subscriber.OnCompleted;

//        // Запуск таймера 
//        timer.Start();
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

//class Program
//{
//    static int[] TwoSum(int[] nums, int target)
//    {
//        int[] ind = { -1, -1 };
//        if ((nums.Length >= 2 && nums.Length <= Math.Pow(10, 4)) && (target >= Math.Pow(-10, 9) && target <= Math.Pow(10, 9)))
//        {
//            for (int i = 0; i < nums.Length - 1; i++)
//            {
//                if (nums[i] >= Math.Pow(-10, 9) && nums[i] <= Math.Pow(10, 9))
//                {
//                    for (int j = i + 1; j < nums.Length; j++)
//                    {
//                        if (nums[i] + nums[j] == target)
//                        {
//                            ind[0] = i;
//                            ind[1] = j;
//                            return ind;
//                        }
//                    }
//                }
//            }
//        }
//        return null;
//    }

//    static void Main(string[] args)
//    {
//        TwoSum([3, 2, 1], 6);
//    }
//}

//class Program
//{
//    static string LongestCommonPrefix(string[] strs)
//    {
//        for (int i = 0; i < strs.Length; i++)
//        {
//            if (strs[i].Length > 200 && strs[i].Any(c => char.IsUpper(c)))
//            {
//                return null;
//            }
//        }
//        string pref = "";
//        if (1 <= strs.Length && strs.Length <= 200)
//        {
//            int min_ind = 0;
//            for (int i = 1; i < strs.Length; i++)
//            {
//                if (strs[min_ind].Length > strs[i].Length)
//                {
//                    min_ind = i;
//                }
//            }
//            for (int i = 0; i < strs[min_ind].Length; i++)
//            {
//                for (int j = 0; j < strs.Length; j++)
//                {
//                    if (strs[min_ind][i] == strs[j][i])
//                    {
//                        continue;
//                    }
//                    else
//                    {
//                        return pref;
//                    }
//                }
//                pref += strs[min_ind][i];
//            }
//        }
//        return pref;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine(LongestCommonPrefix(new string[] { "car", "carten", "caten" }));
//    }
//}

//------------------------------------------------------------------------------------------------------------------------

/*
public class Player
{

    // створюєте поля класу та налаштування їх 
    public string Name { get; }
    private int health;
    public int Health
    {
        get => health;
        private set
        {
            health = value;
            OnHealthChanged?.Invoke(this, EventArgs.Empty); // виклик івенту(події) 
            if (health <= 0)
            {
                OnPlayerDied?.Invoke(this, EventArgs.Empty);
            }
            // повернутись  
        }
    }
    // створення івентів  
    public event EventHandler OnHealthChanged;
    public event EventHandler OnPlayerDied;

    // констуктор обʼєкту 
    public Player(string name, int initialHealth)
    {
        Name = name;
        Health = initialHealth;
    }

    // методи 
    public void TakeDamage(int damage)
    {
        Console.WriteLine($"{Name} takes {damage} damage");
        Health -= damage;
    }

    public void Heal(int healAmount)
    {
        Health += healAmount;
        if (Health > 100) Health = 100;
        Console.WriteLine($"{Name} healed on {healAmount}");
    }
}

public class Game
{
    static void Main(string[] args)
    {
        // створення ігрового обʼєкту 
        Player player = new Player("Borsuk", 100);

        // підписки для борсука 
        player.OnHealthChanged += (sender, e) => {
            Player p = sender as Player;
            Console.WriteLine($"[Event] Health {p.Name} : {p.Health}");
        };

        player.OnPlayerDied += (sender, e) => {
            Player p = sender as Player;
            Console.WriteLine($"[Event] {p.Name} died!");
        };

        // ігровий сценарій 
        player.TakeDamage(30);
        player.TakeDamage(50);
        player.Heal(20);
        player.TakeDamage(50);
    }
}
*/

//class Program
//{
//    public class Pushka
//    {
//        public string Name { get; }
//        private int bulets;
//        private int mags = 5;

//        public int Bulets
//        {
//            get => bulets;
//            private set
//            {
//                bulets = value;
//                if (bulets < 0 || mags < 0) {
//                    OnBuletsUnderMin?.Invoke(this, EventArgs.Empty);
//                }
//                OnBuletsChanged?.Invoke(this, EventArgs.Empty);
//                if (bulets <= 0)
//                {
//                    OnBuletsEmpty?.Invoke(this, EventArgs.Empty);
//                }
//            }
//        }

//        public event EventHandler OnBuletsChanged;
//        public event EventHandler OnBuletsEmpty;
//        public event EventHandler OnBuletsUnderMin;

//        public Pushka(string name, int inBulets)
//        {
//            Name = name;
//            Bulets = inBulets;
//        }

//        public void Fire(int bulets_)
//        {
//            Console.WriteLine($"{Name} lost {bulets_}");
//            Bulets -= bulets_;
//        }

//        public void Reaload()
//        {
//            mags -= 1;
//            Bulets = 30;
//            Console.WriteLine($"{Name} reloaded");
//        }
//    }

//    public class Game
//    {
//        static void Main(string[] args)
//        {
//            Pushka p1 = new Pushka("AK-47", 30);
//            p1.OnBuletsChanged += (sender, e) =>
//            {
//                Pushka p1 = sender as Pushka;
//                Console.WriteLine($"[Event] Bulets {p1.Name} : {p1.Bulets}");
//            };
//            p1.OnBuletsEmpty += (sender, e) =>
//            {
//                Pushka p1 = sender as Pushka;
//                Console.WriteLine($"[Event] {p1.Name} empty!");
//            };
//            p1.OnBuletsUnderMin += (sender, e) =>
//            {
//                Pushka p1 = sender as Pushka;
//                Console.WriteLine($"[Event] {p1.Name} broken or zero magasines!");
//                Environment.Exit(1);
//            };

//            p1.Fire(20);
//            p1.Fire(50);
//            p1.Reaload();
//            p1.Reaload();
//        }
//    }
//}

//class Program
//{
//    class Clad
//    {
//        private int total_kg = 0;
//        private int total_clads = 0;
//        Random random = new Random();

//        public int Total_kg
//        {
//            get => total_kg;
//            set
//            {
//                total_kg = value;
//                total_clads++;
//                if (total_clads % 10 == 0) OnCount10?.Invoke(this, EventArgs.Empty);
//            }
//        }

//        public int Total_clads
//        {
//            get => total_clads;
//        }

//        public event EventHandler OnCount10;

//        public void find_clad()
//        {
//            Total_kg += random.Next(1, 10);
//            Console.WriteLine($"total kg: {total_kg}");
//        }
//    }

//    static void Main(string[] args)
//    {
//        Clad c1 = new Clad();
//        c1.OnCount10 += (sender, e) =>
//        {
//            Clad p1 = sender as Clad;
//            Console.WriteLine($"[Event] you finded {c1.Total_clads}");
//        };
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//        c1.find_clad();
//    }
//}

//class Program
//{
//    static int[] zeros(int[] arr)
//    {
//        int[] arr_tmp = new int[10];
//        int ind = 0;
//        foreach(int i in arr)
//        {
//            if (i != 0)
//            {
//                arr_tmp[ind] = i;
//                ind++;
//            }
//        }
//        foreach(int i in arr)
//        {
//            if(i == 0)
//            {
//                arr_tmp[ind] = i;
//                ind++;
//            }
//        }
//        return arr_tmp;
//    }
//    static void Main(string[] args)
//    {
//        int[] arr = { 1, 5, 8, 0, 7, 4, 12, 0, 5, 0 };
//        arr = zeros(arr);
//        foreach(int i in arr)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}

//class Program
//{
//    string[] basic_items = { "wooden_sword", "stone_sword", "iron_sword", "diamond_sword", "denis`s_sword" };

//    class Inv
//    {
//        private List<string> inventory = new List<string>();

//        public void open_case()
//        {
//            Random random = new Random();
//            int rand = random.Next(1, 101);
//            if (rand <= 2)
//            {
//                Console.WriteLine("you find denis`s_sword\nyou want take it? (1 - yes; 0 - no): ");
//                int ch = Convert.ToInt32(Console.ReadLine());
//                if (ch == 1)
//                {
//                    inventory.Add("denis`s_sword");
//                }
//                else return;
//            }
//            else if (rand <= 15)
//            {
//                Console.WriteLine("you find diamond_sword\nyou want take it? (1 - yes; 0 - no): ");
//                int ch = Convert.ToInt32(Console.ReadLine());
//                if (ch == 1)
//                {
//                    inventory.Add("diamond_sword");
//                }
//                else return;
//            }
//            else if (rand <= 30)
//            {
//                Console.WriteLine("you find iron_sword\nyou want take it? (1 - yes; 0 - no): ");
//                int ch = Convert.ToInt32(Console.ReadLine());
//                if (ch == 1)
//                {
//                    inventory.Add("iron_sword");
//                }
//                else return;
//            }
//            else if (rand <= 60)
//            {
//                Console.WriteLine("you find stone_sword\nyou want take it? (1 - yes; 0 - no): ");
//                int ch = Convert.ToInt32(Console.ReadLine());
//                if (ch == 1)
//                {
//                    inventory.Add("stone_sword");
//                }
//                else return;
//            }
//            else if (rand <= 100)
//            {
//                Console.WriteLine("you find wooden_sword\nyou want take it? (1 - yes; 0 - no): ");
//                int ch = Convert.ToInt32(Console.ReadLine());
//                if (ch == 1)
//                {
//                    inventory.Add("wooden_sword");
//                }
//                else return;
//            }
//            else
//            {
//                Console.WriteLine("you find nothing");
//            }

//        }

//        public void Remove(string name)
//        {
//            if (!(inventory.Remove(name)))
//            {
//                Console.WriteLine("error");
//            }
//        }

//        public void info()
//        {
//            foreach (string item in inventory)
//            {
//                Console.Write(item + ", ");
//            }
//            Console.WriteLine();
//        }

//        public void exit()
//        {
//            Environment.Exit(1);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Inv inventory = new Inv();
//        int ch;

//        while (true)
//        {
//            Console.WriteLine("1 - open a case");
//            Console.WriteLine("2 - show inventory");
//            Console.WriteLine("3 - remove item");
//            Console.WriteLine("4 - exit");
//            Console.Write("choose: ");
//            ch = Convert.ToInt32(Console.ReadLine());

//            switch (ch)
//            {
//                case 1:
//                    inventory.open_case();
//                    break;
//                case 2:
//                    inventory.info();
//                    break;
//                case 3:
//                    inventory.info();
//                    Console.Write("name: ");
//                    string name = Console.ReadLine();
//                    inventory.Remove(name);
//                    break;
//                case 4:
//                    inventory.exit();
//                    break;
//                default:
//                    Console.WriteLine("error");
//                    break;
//            }

//        }
//    }
//}

//class Program
//{
//    static void max_of_three<T>(T a, T b, T c) where T : IComparable<T> // where T : IComparable<T> - гпт помог
//    {
//        T max = a;
//        if (b.CompareTo(max) > 0)
//        {
//            max = b;
//        }
//        if (c.CompareTo(max) > 0)
//        {
//            max = c;
//        }
//        Console.WriteLine(max);
//    }

//    static T Sum<T>(T[] arr)
//    {
//        dynamic sum = default(T); // типа null
//        foreach (var item in arr)
//        {
//            sum += (dynamic)item; // шобы += работал и игнорил тип переменной, вроде так
//        }
//        return (T)sum;
//    }


//    static void Main(string[] args)
//    {

//    }
//}

//class Program
//{
//static bool CanPlaceFlowers(int[] flowerbed, int n)
//{
//    if (flowerbed.Length == 1)
//    {
//        if (n == 1 && flowerbed[0] == 0)
//        {
//            return true;
//        }
//        else if (n == 0)
//        {
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//    int count = 0;
//    for (int i = 0; i < n; i++)
//    {
//        for(int j = 0; j < flowerbed.Length; j++)
//        {
//            if (j == 0)
//            {
//                if (flowerbed[j + 1] == 0 && flowerbed[j] == 0)
//                {
//                    flowerbed[j] = 1;
//                    count++;
//                }
//                continue;
//            }
//            else if (j == flowerbed.Length - 1)
//            {
//                if (flowerbed[j - 1] == 0 && flowerbed[j] == 0)
//                {
//                    flowerbed[j] = 1;
//                    count++;
//                }
//                continue;
//            }
//            else
//            {
//                if (flowerbed[j] == 0 && flowerbed[j - 1] == 0 && flowerbed[j + 1] == 0)
//                {
//                    flowerbed[j] = 1;
//                    count++;
//                    continue;
//                }
//            }
//        }
//    }
//    if (count >= n)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}

//public class Solution
//{
//    public bool CanPlaceFlowers(int[] flowerbed, int n)
//    {
//        bool result = false;
//        int placedPlants = n;
//        for (int i = 0; i < flowerbed.Length; i++)
//        {
//            if (flowerbed[i] == 0 && // если она пустая
//                (i == 0 || flowerbed[i - 1] == 0) && // если слева пусто
//                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0) /* если справа пусто */ && placedPlants > 0) // если вообще надо садить
//            { // если все гуд то садим
//                placedPlants--;
//                flowerbed[i] = 1;
//            }
//            if (placedPlants == 0)
//            { // если все сделано то тру
//                result = true;
//                break;
//            }
//        }
//        return result; // если не все сделано то изначальный фолс
//    }
//}

//static void Main(string[] args)
//{
//    Console.WriteLine(CanPlaceFlowers([1, 0, 0, 0, 0, 0, 1], 2));
//}
//}

//class Program
//{
//    static void add_to_array<T>(ref List<T> arr, T element)
//    {
//        arr.Add(element);
//    }

//    static void v10raziv(ref int[] arr)
//    {
//        int max_ind = 0;
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] > arr[max_ind])
//            {
//                max_ind = i;
//            }
//        }
//        arr[max_ind] *= 10;
//    }

//    static void Main(string[] args)
//    {
//        List<string> arr = new List<string>();
//        add_to_array(ref arr, "asfg");
//        foreach (string i in arr)
//        {
//            Console.Write(i + " ");
//        }

//        Console.WriteLine();

//        int[] arr_ = { 1, 2, 3, 4 };
//        v10raziv(ref arr_);
//        foreach (int i in arr_)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            int a = int.Parse(Console.ReadLine());
//            Console.Clear();
//            Console.Write(a + "/");
//            int a_ = int.Parse(Console.ReadLine());
//            int b = int.Parse(Console.ReadLine());
//            Console.Clear();
//            Console.Write(a + "/" + a_ + "\n" + b + "/");
//            int b_ = int.Parse(Console.ReadLine());
//            Console.WriteLine();

//            for (int i = 1; i < a_ * b_ + 1; i++)
//            {
//                if (i % a_ == 0 && i % b_ == 0)
//                {
//                    Console.WriteLine($"{a * (i / a_)}/{i}  *{i / a_}\n{b * (i / b_)}/{i}  *{i / b_}");
//                    break;
//                }
//            }

//            Console.Write("\nPress enter to continue...");
//            Console.ReadLine();
//            Console.Clear();
//        }
//    }
//}

//class Program
//{
//    static int uprostit(ref int a, ref int a_)
//    {
//        int b = a;
//        for (int i = Math.Min(a, a_); i > 1; i--)
//        {
//            if (a % i == 0 && a_ % i == 0)
//            {
//                a /= i;
//                a_ /= i;
//                uprostit(ref a, ref a_);
//                return b / a;
//            }
//        }
//        return b / a;
//    }

//    static void Main(string[] args)
//    {
//        while (true)
//        {
//            int a = int.Parse(Console.ReadLine());
//            Console.Clear();
//            Console.Write(a + "/");
//            int a_ = int.Parse(Console.ReadLine());
//            Console.Clear();
//            Console.Write(a + "/" + a_);

//            Console.WriteLine($"  :{uprostit(ref a, ref a_)}\n{a}/{a_}");

//            Console.Write("\nPress enter to continue...");
//            Console.ReadLine();
//            Console.Clear();
//        }
//    }
//}

//if (p.val != q.val)
//{
//    return false;
//}
//if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
//{
//    return true;
//}
//else
//{
//    return false;
//}

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
//        DateTime start;
//        DateTime end;
//        Console.Write("value: ");
//        int a = int.Parse(Console.ReadLine());
//        Console.Clear();
//        start = DateTime.Now;
//        for (int i = 0; i < a; i++)
//        {
//            Console.WriteLine(i + 1);
//        }
//        end = DateTime.Now;
//        Console.Clear();
//        Console.WriteLine($"writed {a} numbers in: {Math.Round((end - start).TotalSeconds, 1)}");
//    }
//}

//using System.ComponentModel.DataAnnotations;
//using System.Globalization;
//using System.Text.Json;

//class Program
//{
//    static void Main(string[] args)
//    {
//        json_.Run();
//    }
//}

//public class json_
//{
//    public static void Run()
//    {
//        var car = new Car("rs7", "audi", "12ghf231ghf1");

//        string json = JsonSerializer.Serialize(car);
//        File.WriteAllText("car.json", json);

//        string read_json = File.ReadAllText("car.json");
//        var ds_car = JsonSerializer.Deserialize<Car>(read_json);

//        Console.WriteLine(ds_car.mark + " " + ds_car.model);
//    }
//}

//[Serializable]
//public class Car
//{
//    public string mark { get; set; }
//    public string model { get; set; }

//    [NonSerialized]
//    private string _vin;

//    public Car(string mark, string model, string vin)
//    {
//        this.mark = mark;
//        this.model = model;
//        _vin = vin;
//    }

//    public Car()
//    {

//    }
//}

//using Serilog;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Log.Logger = new LoggerConfiguration()
//                     .WriteTo.Console()
//                     .WriteTo.File("app.log")
//                     .CreateLogger();
//        Log.Information("hi logger");

//        try
//        {
//            throw new Exception("test error");
//        }
//        catch (Exception ex)
//        {
//            Log.Error(ex, "error in code");
//        }
//        Log.CloseAndFlush();
//    }
//}

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

//using Serilog;
//using System.Text.Json;
//class Program
//{
//    class User
//    {
//        private string name;
//        private string pass;
//        public List<string> tovars;

//        public User(string name, string pass)
//        {
//            this.name = name;
//            this.pass = pass;
//            tovars = new List<string>();
//        }

//        public bool authenticate(string name, string pass)
//        {
//            if (name == this.name && pass == this.pass)
//            {
//                Log.Information("{name} authenticated", name);
//                return true;
//            }
//            else
//            {
//                Log.Error("{name} not authenticated", name);
//                return false;
//            }
//        }

//        public void pay()
//        {
//            Random random = new Random();
//            int a = random.Next(3);
//            if (a > 0)
//            {
//                Log.Information("{name} payed zakaz", name);
//                File.WriteAllText("tovars.json", JsonSerializer.Serialize(tovars));
//                Log.Information("serialized");
//            }
//            else
//            {
//                Log.Error("{name} not payed zakaz", name);
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
//        Log.Information("program started");

//        User user = new User("user", "123");
//        Console.Write("name: ");
//        string name = Console.ReadLine();
//        Console.Write("pass: ");
//        string pass = Console.ReadLine();
//        if (!user.authenticate(name, pass))
//        {
//            return;
//        }

//        List<string> catalog = new List<string> { "egg", "piva", "melon", "water", "pepsi" };
//        Log.Debug("searching products");
//        Random random = new Random();
//        int count = random.Next(1, 6);
//        for (int i = 0; i < count; i++)
//        {
//            user.tovars.Add(catalog[random.Next(5)]);
//        }
//        Log.Information("finded tovars added to koshik ({count})", count);

//        user.pay();
//        Log.Information("program ended");
//    }
//}

//using Serilog;
//using System.Globalization;
//class Program
//{
//    public class Text_editor
//    {
//        public string text;

//        public Text_editor(string text)
//        {
//            this.text = text;
//        }

//        public void to_upper()
//        {
//            text = text.ToUpper();
//        }

//        public void to_lower()
//        {
//            text = text.ToLower();
//        }

//        public void to_title()
//        {
//            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
//            text = textInfo.ToTitleCase(text.ToLower());
//        }
//    }
//    static void Main(string[] args)
//    {
//        Log.Logger = new LoggerConfiguration()
//            .MinimumLevel.Debug()
//            .WriteTo.Console()
//            .CreateLogger();

//        Log.Debug("inputing text");
//        Console.Write("text: ");
//        Text_editor text_editor = new Text_editor(Console.ReadLine());
//        text_editor.to_upper();
//        Log.Information("to upper: {text_editor.text}", text_editor.text);
//        text_editor.to_lower();
//        Log.Information("to lower: {text_editor.text}", text_editor.text);
//        text_editor.to_title();
//        Log.Information("to title: {text_editor.text}", text_editor.text);
//    }
//}

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
//        foreach (var it in videos)
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

//class Program
//{
//    static void Main(string[] args)
//    {
//        int a;
//        int b;
//        Console.Write("ihor: ");
//        a = int.Parse(Console.ReadLine());
//        Console.Write("sanya: ");
//        b = int.Parse(Console.ReadLine());
//        Console.WriteLine(a + b);
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        List<string> list1 = new List<string>() { "C#", "C++", "Java", "PHP", "JavaScript" };

        Console.WriteLine("Main started");

        Thread thread = new Thread(Method1);
        thread.Start(list1);

        Console.WriteLine("Thread started");

        thread.Join();

        Console.ReadLine();
    }

    static void Method1(object o)
    {
        List<string> strings = o as List<string>;
        foreach (string s in strings)
        {
            Console.WriteLine(s);
            Thread.Sleep(500);
        }
    }
}

class Bank
{

}