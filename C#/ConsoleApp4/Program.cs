//using System.Collections;

//class Program
//{
//    static void Main(string[] args)
//    {
//        //1
//        ArrayList list = new ArrayList() { 1, "asd2", 3.1, "asd4", 5.1, "asd6", 7.1, "asd8", 9.1, "asd10" };
//        Thread thread = new Thread(Method_ToString);
//        thread.Start(list);
//        thread.Join();

//        //2
//        Bank bank = new Bank();
//        bank.setMoney(123);
//        bank.setName("asd");
//        bank.setPrecent(321);
//    }

//    //1
//    static void Method_ToString(object list)
//    {
//        ArrayList arrayList = (ArrayList)list;
//        foreach (var item in arrayList)
//        {
//            Console.WriteLine(item.ToString());
//        }
//    }

//    //2
//    class Bank
//    {
//        private double money;
//        private string name;
//        private int precent;

//        public Bank()
//        {
//            money = 0.0;
//            name = "none";
//            precent = 0;
//        }

//        public void setMoney(double money)
//        {
//            this.money = money;
//            Thread thread = new Thread(WriteToFile);
//            thread.Start();
//            thread.Join();
//        }

//        public void setName(string name)
//        {
//            this.name = name;
//            Thread thread = new Thread(WriteToFile);
//            thread.Start();
//            thread.Join();
//        }

//        public void setPrecent(int precent)
//        {
//            this.precent = precent;
//            Thread thread = new Thread(WriteToFile);
//            thread.Start();
//            thread.Join();
//        }

//        public void WriteToFile()
//        {
//            using (StreamWriter sw = new StreamWriter("C:\\IT\\C#\\ConsoleApp4\\Bank.txt", true))
//            {
//                sw.WriteLine($"{money} {name} {precent}");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Game Started, wait to beep with text...\n");
//        Thread.Sleep(new Random().Next(3000, 7000));
//        Thread thread = new Thread(AfterBeepTime);

//        Console.Beep(1000, 200);
//        Console.WriteLine("Beep!\n");
//        thread.Start();

//        thread.Join();
//    }

//    static void AfterBeepTime()
//    {
//        TimeOnly time1 = TimeOnly.FromDateTime(DateTime.Now);
//        while (true)
//        {
//            if (Console.KeyAvailable)
//            {
//                TimeOnly time2 = TimeOnly.FromDateTime(DateTime.Now);
//                Console.WriteLine($"You typed after {Convert.ToInt32((time2 - time1).TotalMilliseconds)}ms");
//                break;
//            }
//        }
//    }
//}

//using System.Diagnostics;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        //1
//        Console.WriteLine("Process:\n");
//        Process[] processes = Process.GetProcesses();
//        foreach (var item in processes)
//        {
//            Console.WriteLine($"ID: {item.Id} | Name: {item.ProcessName}.exe");
//        }

//        // 2
//        Console.WriteLine(Process.GetProcessesByName("System")[0].Id); // для перевірки catch (System.ComponentModel.Win32Exception)
//        try
//        {
//            Console.Write("\nEnter ID process: ");
//            Process process = Process.GetProcessById(int.Parse(Console.ReadLine()));

//            Console.WriteLine($"\nThreads: {process.ProcessName}.exe:");
//            foreach (ProcessThread thread in process.Threads)
//            {
//                Console.WriteLine($"ID: {thread.Id} | Priority: {thread.PriorityLevel} | Time of start: {thread.StartTime}");
//            }

//            Console.WriteLine($"\nModules: {process.ProcessName}.exe:");
//            foreach (ProcessModule module in process.Modules)
//            {
//                Console.WriteLine($"Name: {module.ModuleName} | Path: {module.FileName}");
//            }
//        }
//        catch (ArgumentException)
//        {
//            Console.WriteLine("Invalid process ID");
//        }
//        catch (System.ComponentModel.Win32Exception)
//        {
//            Console.WriteLine("No access to information about threads or modules");
//        }
//    }
//}

//using System.Diagnostics;

//public class Program
//{
//    public static void Main(string[] args)
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("List of active processes:\n");

//            Process[] processes = Process.GetProcesses();
//            foreach (Process process in processes)
//            {
//                Console.WriteLine($"ID: {process.Id} | Name: {process.ProcessName}.exe | Threads: {process.Threads.Count} | Descriptors: {process.HandleCount}");
//            }

//            Console.Write("\nPress enter to save data to a file, or any other key to not save");
//            var key = Console.ReadKey();
//            if (key.Key == ConsoleKey.Enter)
//            {
//                using (StreamWriter sw = new StreamWriter("C:\\IT\\C#\\ConsoleApp4\\processes.txt", false))
//                {
//                    foreach (Process process in processes)
//                    {
//                        sw.WriteLine($"ID: {process.Id} | Name: {process.ProcessName}.exe | Threads: {process.Threads.Count} | Descriptors: {process.HandleCount}");
//                    }
//                }
//                Console.WriteLine("\n\nData saved to processes.txt");
//            }
//            else
//            {
//                Console.Write("\b \b");
//            }

//            Thread.Sleep(5000);
//        }
//    }
//}

//class Program
//{
//    class Philosopher
//    {
//        public int eat_count = 0;
//        public bool is_hungry = true;
//        private readonly int rightFork_index;
//        private readonly int leftFork_index;

//        public Philosopher(int leftFork_index, int rightFork_index)
//        {
//            this.rightFork_index = rightFork_index;
//            this.leftFork_index = leftFork_index;
//        }

//        public void Eat(ref bool[] forks, int philosopher_index)
//        {
//            lock (forks)
//            {
//                if (forks[leftFork_index] || forks[rightFork_index])
//                {
//                    Console.WriteLine($"Philosopher {philosopher_index + 1} couldn't eat — forks are busy.");
//                    return;
//                }
//                else
//                {
//                    forks[leftFork_index] = true;
//                    forks[rightFork_index] = true;
//                }
//            }

//            Console.WriteLine($"Philosopher {philosopher_index + 1} started eating.");
//            Thread.Sleep(new Random().Next(3000, 5000));
//            Console.WriteLine($"Philosopher {philosopher_index + 1} finished eating {++eat_count} times.");
//            lock (forks)
//            {
//                forks[leftFork_index] = false;
//                forks[rightFork_index] = false;
//            }
//            Thread thinkin_thread = new Thread(Start_thinking);
//            thinkin_thread.Start();

//        }

//        public void Start_thinking()
//        {
//            Console.WriteLine("Philosopher starts thinking.");
//            Thread.Sleep(new Random().Next(8000, 12000));
//            is_hungry = true;
//        }
//    }

//    static void Main()
//    {
//        bool[] forks = { false, false, false, false, false };

//        Philosopher[] philosophers = {
//            new Philosopher(0, 1),
//            new Philosopher(1, 2),
//            new Philosopher(2, 3),
//            new Philosopher(3, 4),
//            new Philosopher(4, 0)
//        };

//        Thread[] threads = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int index = i;

//            threads[i] = new Thread(() =>
//            {
//                while (philosophers[index].eat_count < 3)
//                {
//                    if (philosophers[index].is_hungry)
//                    {
//                        philosophers[index].Eat(ref forks, index);
//                    }
//                    Thread.Sleep(3000); // общая задержка для консоли
//                }
//            });
//            threads[i].Start();
//        }
//        foreach (var thread in threads)
//        {
//            thread.Join();
//        }

//        Console.WriteLine("All philosophers have finished their meals.");
//    }
//}

//class Program
//{
//    class Car
//    {
//        public readonly string direction;
//        public bool is_crossed_bridge;

//        public Car(string direction)
//        {
//            this.direction = direction;
//            is_crossed_bridge = false;
//        }
//    }

//    class Bridge
//    {
//        private string last_direction = "none";
//        private readonly object lock_obj = new();

//        public void Cross(Car[] cars, int index)
//        {
//            lock(lock_obj)
//            {
//                if (last_direction == "none" ||
//                    last_direction != cars[index].direction ||
//                    (last_direction == cars[index].direction && !cars.Any(car => car.direction != cars[index].direction)))
//                {
//                    last_direction = cars[index].direction;
//                    Console.WriteLine($"Car {index + 1} is crossing the bridge.");
//                    Thread.Sleep(2000);
//                    Console.WriteLine($"Car {index + 1} crossed the bridge.\n");
//                    cars[index].is_crossed_bridge = true;
//                }
//                else
//                {
//                    //Console.WriteLine($"Car {index + 1} couldn't cross the brige.");
//                }
//                Thread.Sleep(100);
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        Bridge brige = new Bridge();
//        Car[] cars = new Car[]
//        {
//            new Car("right"),
//            new Car("left"),
//            new Car("right"),
//            new Car("right"),
//            new Car("left")
//        };
//    Thread[] threads = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int index = i;
//            threads[i] = new Thread(() =>
//            {
//                while (cars[index].is_crossed_bridge == false)
//                {
//                    brige.Cross(cars, index);
//                }
//            });
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }
//    }
//}

//class Program
//{
//    class Printer_monitor
//    {
//        private readonly bool[] printers = { false, false };
//        private readonly object lock_obj = new();

//        public int Request()
//        {
//            lock (lock_obj)
//            {
//                while (true)
//                {
//                    for (int i = 0; i < 2; i++)
//                    {
//                        if (!printers[i])
//                        {
//                            printers[i] = true;
//                            return i;
//                        }
//                    }
//                    Monitor.Wait(lock_obj);
//                }
//            }
//        }

//        public void Release(int id)
//        {
//            lock (lock_obj)
//            {
//                printers[id] = false;
//                Monitor.Pulse(lock_obj);
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        Printer_monitor monitor = new Printer_monitor();
//        Thread[] users = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int user_id = i + 1;
//            users[i] = new Thread(() =>
//            {
//                Console.WriteLine($"User {user_id} is requesting a printer.");
//                int printer_id = monitor.Request();
//                Console.WriteLine($"User {user_id} received printer {printer_id + 1}.");

//                Thread.Sleep(2000);

//                Console.WriteLine($"User {user_id} is releasing printer {printer_id + 1}.");
//                monitor.Release(printer_id);
//            });
//        }
//        foreach (Thread user in users)
//        {
//            user.Start();
//        }
//        foreach (Thread user in users)
//        {
//            user.Join();
//        }
//    }
//}

//class Program
//{
//    class Printer_monitor
//    {
//        private readonly bool[] printers = { false, false };
//        private readonly object lock_obj = new();

//        public int Request()
//        {
//            while (true)
//            {
//                lock (lock_obj)
//                {
//                    for (int i = 0; i < 2; i++)
//                    {
//                        if (!printers[i])
//                        {
//                            printers[i] = true;
//                            return i;
//                        }
//                    }
//                }
//                Thread.Sleep(100);
//            }
//        }

//        public void Release(int id)
//        {
//            lock (lock_obj)
//            {
//                printers[id] = false;
//            }
//        }
//    }

//    static void Main(string[] args)
//    {
//        Printer_monitor monitor = new Printer_monitor();
//        Thread[] users = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int user_id = i + 1;
//            users[i] = new Thread(() =>
//            {
//                Console.WriteLine($"User {user_id} is requesting a printer.");
//                int printer_id = monitor.Request();
//                Console.WriteLine($"User {user_id} received printer {printer_id + 1}.");

//                Thread.Sleep(2000);

//                Console.WriteLine($"User {user_id} is releasing printer {printer_id + 1}.");
//                monitor.Release(printer_id);
//            });
//        }
//        foreach (Thread user in users)
//        {
//            user.Start();
//        }
//        foreach (Thread user in users)
//        {
//            user.Join();
//        }
//    }
//}

//using System.Data.SqlTypes;

//class Program
//{
//    //1
//    /*
//    static void Main(string[] args)
//    {
//        double average;
//        int[] arr = new int[new Random().Next(1, 100)];
//        Random random = new Random();
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = random.Next(100);
//        }
//        int? arr_parts_count = null;
//        for (int i = 3; i < 11; i++)
//        {
//            if (arr.Length % i == 0) // 3 - 10
//            {
//                arr_parts_count = i;
//                break;
//            }
//        }
//        if (!arr_parts_count.HasValue)
//        {
//            average = arr.Average();
//        }
//        else
//        {
//            int part_size = arr.Length / arr_parts_count.Value;
//            int start = 0;
//            int end = part_size;
//            double[] averages = new double[arr_parts_count.Value];
//            ManualResetEvent[] reset_events = new ManualResetEvent[arr_parts_count.Value];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                reset_events[i] = new ManualResetEvent(false);
//                int index = i;
//                int part_start = start;
//                int part_end = end;
//                ThreadPool.QueueUserWorkItem(state => {
//                    int[] arr_part = new int[part_size];
//                    for (int j = part_start; j < part_end; j++)
//                    {
//                        arr_part[j - part_start] = arr[j];
//                    }
//                    averages[index] = arr_part.Average();
//                    reset_events[index].Set();
//                });
//                start += part_size;
//                end += part_size;
//            }
//            WaitHandle.WaitAll(reset_events);
//            average = averages.Average();
//        }
//        foreach (int num in arr)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine("\n");
//        Console.WriteLine($"Average: {Math.Round(average, 1)}");
//    }
//    */

//    //2
//    /*
//    static void Main(string[] args)
//    {
//        int max;
//        int[] arr = new int[new Random().Next(1, 100)];
//        Random random = new Random();
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = random.Next(100);
//        }
//        int? arr_parts_count = null;
//        for (int i = 3; i < 11; i++)
//        {
//            if (arr.Length % i == 0) // 3 - 10
//            {
//                arr_parts_count = i;
//                break;
//            }
//        }
//        if (!arr_parts_count.HasValue)
//        {
//            max = arr.Max();
//        }
//        else
//        {
//            int part_size = arr.Length / arr_parts_count.Value;
//            int start = 0;
//            int end = part_size;
//            int[] maxs = new int[arr_parts_count.Value];
//            ManualResetEvent[] reset_events = new ManualResetEvent[arr_parts_count.Value];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                reset_events[i] = new ManualResetEvent(false);
//                int index = i;
//                int part_start = start;
//                int part_end = end;
//                ThreadPool.QueueUserWorkItem(state =>
//                {
//                    int[] arr_part = new int[part_size];
//                    for (int j = part_start; j < part_end; j++)
//                    {
//                        arr_part[j - part_start] = arr[j];
//                    }
//                    maxs[index] = arr_part.Max();
//                    reset_events[index].Set();
//                });
//                start += part_size;
//                end += part_size;
//            }
//            WaitHandle.WaitAll(reset_events);
//            max = maxs.Max();
//        }
//        foreach (int num in arr)
//        {
//            Console.Write(num + " ");
//        }
//        Console.WriteLine("\n");
//        Console.WriteLine($"Max: {max}");
//    }
//    */

//    //3
//    /*
//    static void Main(string[] args)
//    {
//        string[] arr = {
//            "apple", "banana", "cat", "dog", "elephant", "fox", "grape", "house", "ice", "jungle",
//            "kite", "lion", "mountain", "notebook", "orange", "parrot", "queen", "rose", "sun", "tree"
//        }; // gpt дал словарь
//        Console.WriteLine("Normal:");
//        foreach (string str in arr)
//        {
//            Console.Write(str + " ");
//        }
//        int? arr_parts_count = null;
//        for (int i = 3; i < 11; i++)
//        {
//            if (arr.Length % i == 0) // 3 - 10
//            {
//                arr_parts_count = i;
//                break;
//            }
//        }
//        if (!arr_parts_count.HasValue)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                arr[i] = new string(arr[i].Reverse().ToArray());
//            }
//        }
//        else
//        {
//            int part_size = arr.Length / arr_parts_count.Value;
//            int start = 0;
//            int end = part_size;
//            string[][] arr_parts = new string[arr_parts_count.Value][];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                arr_parts[i] = new string[part_size];
//            }
//            ManualResetEvent[] reset_events = new ManualResetEvent[arr_parts_count.Value];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                reset_events[i] = new ManualResetEvent(false);
//                int index = i;
//                int part_start = start;
//                int part_end = end;
//                ThreadPool.QueueUserWorkItem(state =>
//                {
//                    string[] arr_part = new string[part_size];
//                    for (int j = part_start; j < part_end; j++)
//                    {
//                        arr_part[j - part_start] = arr[j];
//                    }
//                    for (int j = 0; j < arr_part.Length; j++)
//                    {
//                        arr_part[j] = new string(arr_part[j].Reverse().ToArray());
//                    }
//                    arr_parts[index] = arr_part;
//                    reset_events[index].Set();
//                });
//                start += part_size;
//                end += part_size;
//            }
//            WaitHandle.WaitAll(reset_events);
//            int current_index = 0;
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                for (int j = 0; j < part_size; j++)
//                {
//                    arr[current_index] = arr_parts[i][j];
//                    current_index++;
//                }
//            }
//        }
//        Console.WriteLine("\n\nReversed:");
//        foreach (string str in arr)
//        {
//            Console.Write(str + " ");
//        }
//    }
//    */

//    //4
//    /*
//    static void Main(string[] args)
//    {
//        string[] arr = {
//            "apple", "banana", "cat", "dog", "elephant", "fox", "grape", "house", "ice", "jungle",
//            "kite", "lion", "mountain", "notebook", "orange", "parrot", "queen", "rose", "sun", "tree"
//        }; // gpt дал словарь
//        Console.Write("Word: ");
//        string subword = Console.ReadLine();
//        List<string> finded_subwords = new List<string>();
//        int? arr_parts_count = null;
//        for (int i = 3; i < 11; i++)
//        {
//            if (arr.Length % i == 0) // 3 - 10
//            {
//                arr_parts_count = i;
//                break;
//            }
//        }
//        if (!arr_parts_count.HasValue)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                finded_subwords.AddRange(arr.Where(s => s.Contains(subword, StringComparison.OrdinalIgnoreCase)).ToArray());
//            }
//        }
//        else
//        {
//            object lock_obj = new object();
//            int part_size = arr.Length / arr_parts_count.Value;
//            int start = 0;
//            int end = part_size;
//            ManualResetEvent[] reset_events = new ManualResetEvent[arr_parts_count.Value];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                reset_events[i] = new ManualResetEvent(false);
//                int index = i;
//                int part_start = start;
//                int part_end = end;
//                ThreadPool.QueueUserWorkItem(state =>
//                {
//                    string[] arr_part = new string[part_size];
//                    for (int j = part_start; j < part_end; j++)
//                    {
//                        arr_part[j - part_start] = arr[j];
//                    }
//                    lock (lock_obj)
//                    {
//                        finded_subwords.AddRange(arr_part.Where(s => s.Contains(subword, StringComparison.OrdinalIgnoreCase)).ToArray());
//                    }
//                    reset_events[index].Set();
//                });
//                start += part_size;
//                end += part_size;
//            }
//            WaitHandle.WaitAll(reset_events);
//        }
//        Console.WriteLine("\n");
//        Console.WriteLine("Words with finded subword:");
//        foreach (string str in finded_subwords)
//        {
//            Console.Write(str + " ");
//        }
//    }
//    */

//    //5
//    /*
//    static void Main(string[] args)
//    {
//        string[] arr = {
//            "apple", "banana", "cat", "dog", "elephant", "fox", "grape", "house", "ice", "jungle",
//            "kite", "lion", "mountain", "notebook", "orange", "parrot", "queen", "rose", "sun", "tree"
//        }; // gpt дал словарь
//        Console.WriteLine("Normal:");
//        foreach (string str in arr)
//        {
//            Console.Write(str + " ");
//        }
//        string concatenated_str;
//        int? arr_parts_count = null;
//        for (int i = 3; i < 11; i++)
//        {
//            if (arr.Length % i == 0) // 3 - 10
//            {
//                arr_parts_count = i;
//                break;
//            }
//        }
//        if (!arr_parts_count.HasValue)
//        {
//            concatenated_str = string.Join(" ", arr);
//        }
//        else
//        {
//            int part_size = arr.Length / arr_parts_count.Value;
//            int start = 0;
//            int end = part_size;
//            string[] arr_parts = new string[arr_parts_count.Value];
//            ManualResetEvent[] reset_events = new ManualResetEvent[arr_parts_count.Value];
//            for (int i = 0; i < arr_parts_count.Value; i++)
//            {
//                reset_events[i] = new ManualResetEvent(false);
//                int index = i;
//                int part_start = start;
//                int part_end = end;
//                ThreadPool.QueueUserWorkItem(state =>
//                {
//                    string[] arr_part = new string[part_size];
//                    for (int j = part_start; j < part_end; j++)
//                    {
//                        arr_part[j - part_start] = arr[j];
//                    }
//                    arr_parts[index] = string.Join(" ", arr_part);
//                    reset_events[index].Set();
//                });
//                start += part_size;
//                end += part_size;
//            }
//            WaitHandle.WaitAll(reset_events);
//            concatenated_str = string.Join(" ", arr_parts);
//        }
//        Console.WriteLine("\n\nConverted:");
//        Console.WriteLine(concatenated_str);
//    }
//    */
//}

//class Program
//{
//    //1
//    /*
//    static void Main(string[] args)
//    {
//        Doctor doctor = new Doctor();
//        Thread[] threads = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int index = i + 1;
//            threads[i] = new Thread(() => doctor.ShowMessage($"patient`s {index} message"));
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }
//    }

//    class Doctor
//    {
//        private static Mutex mutex = new Mutex();

//        public void ShowMessage(string message)
//        {
//            mutex.WaitOne();
//            Console.WriteLine(message);
//            Thread.Sleep(3000);
//            Console.Clear();
//            mutex.ReleaseMutex();
//        }
//    }
//    */

//    //2
//    /*
//    static void Main(string[] args)
//    {
//        Queue queue = new Queue(5);
//        Writer writer = new Writer(10);
//        Reader reader = new Reader();
//        Thread writer_thread = new Thread(() =>
//        {
//            writer.start_writing(queue);
//        });
//        Thread reader_thread = new Thread(() =>
//        {
//            reader.start_reading(queue, writer);
//        });
//        writer_thread.Start();
//        reader_thread.Start();
//        writer_thread.Join();
//        reader_thread.Join();
//    }

//    class Writer
//    {
//        private int count;
//        public bool end_writing = false;
//        private Random random = new Random();

//        public Writer(int count) => this.count = count;

//        public void start_writing(Queue queue)
//        {
//            while (count > 0)
//            {
//                if (queue.add_toTheEnd(random.Next()))
//                {
//                    count--;
//                }
//                Thread.Sleep(1000);
//            }
//            end_writing = true;
//        }
//    }

//    class Reader
//    {
//        public void start_reading(Queue queue, Writer writer)
//        {
//            while (true)
//            {
//                int numb = queue.read_first();
//                if (numb == -1 && writer.end_writing) break;
//                if (numb != -1)
//                {
//                    Console.WriteLine(numb);
//                    Thread.Sleep(2000);
//                }
//            }
//        }
//    }

//    class Queue
//    {
//        private List<int> queue;
//        private static Mutex mutex = new Mutex();
//        int size;

//        public Queue(int size)
//        {
//            queue = new List<int>(size);
//            this.size = size;
//        }

//        public bool add_toTheEnd(int numb)
//        {
//            mutex.WaitOne();
//            if (queue.Count < size)
//            {
//                queue.Add(numb);
//                mutex.ReleaseMutex();
//                return true;
//            }
//            mutex.ReleaseMutex();
//            return false;
//        }

//        public int read_first()
//        {
//            mutex.WaitOne();
//            if (queue.Count == 0)
//            {
//                mutex.ReleaseMutex();
//                return -1;
//            }
//            int numb = queue[0];
//            queue.RemoveAt(0);
//            mutex.ReleaseMutex();
//            return numb;
//        }
//    }
//    */

//    //3
//    /*
//    static Mutex mutex = new Mutex();
//    static void Main(string[] args)
//    {
//        Thread[] threads = new Thread[3];
//        for (int i = 0; i < 3; i++)
//        {
//            int index = i + 1;
//            threads[i] = new Thread(() => write_log($"thread {index}"));
//        }
//        using (StreamWriter writer = new StreamWriter("log.log", false))
//        {
//            writer.Write("");
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }
//    }

//    static void write_log(string name)
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            mutex.WaitOne();
//            using (StreamWriter writer = new StreamWriter("log.log", true))
//            {
//                writer.WriteLine($"[{name}] Повідомлення {i}.");
//            }
//            mutex.ReleaseMutex();
//            Thread.Sleep(1000);
//        }
//    }
//    */
//}

using System.Collections.Concurrent;

//class Program
//{
//    //1
//    /*
//    class BankAccount
//    {
//        private double balance;
//        private readonly object lock_obj = new object();

//        public BankAccount(double balance)
//        {
//            this.balance = balance;
//        }

//        public void deposit(double amount)
//        {
//            lock (lock_obj)
//            {
//                balance += amount;
//            }
//        }

//        public void withdraw(double amount)
//        {
//            lock (lock_obj)
//            {
//                if (balance >= amount)
//                {
//                    balance -= amount;
//                }
//                else
//                {
//                    Console.WriteLine("not enough money");
//                }
//            }
//        }

//        public double get_balance()
//        {
//            lock (lock_obj)
//            {
//                return balance;
//            }
//        }
//    }

//    static void Main()
//    {
//        BankAccount account = new BankAccount(1000);

//        Thread depositThread1 = new Thread(() => account.deposit(500));
//        Thread depositThread2 = new Thread(() => account.deposit(300));
//        Thread withdrawThread1 = new Thread(() => account.withdraw(200));
//        Thread withdrawThread2 = new Thread(() => account.withdraw(700));

//        depositThread1.Start();
//        depositThread2.Start();
//        withdrawThread1.Start();
//        withdrawThread2.Start();

//        depositThread1.Join();
//        depositThread2.Join();
//        withdrawThread1.Join();
//        withdrawThread2.Join();

//        Console.WriteLine(account.get_balance());
//    }
//    */

//    //2
//    /*
//    static void Main()
//    {
//        Counter counter = new Counter();
//        Thread[] threads = new Thread[5];

//        for (int i = 0; i < 5; i++)
//        {
//            threads[i] = new Thread(counter.perform_task);
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }

//        Console.WriteLine(counter.count);
//    }

//    class Counter
//    {
//        public int count = 0;

//        public void perform_task()
//        {
//            for (int i = 0; i < 1000000; i++)
//            {
//                Interlocked.Increment(ref count);
//            }
//        }
//    }
//    */

//    //3
//    /*
//    class TaskQueue
//    {
//        private readonly Semaphore semaphore;
//        private readonly ConcurrentQueue<Action> task_queue = new ConcurrentQueue<Action>();
//        private int processed_tasks = 0;
//        private int running_tasks = 0;

//        public TaskQueue(int max_concurrent_tasks)
//        {
//            semaphore = new Semaphore(max_concurrent_tasks, max_concurrent_tasks);
//        }

//        public void enqueue(Action task)
//        {
//            task_queue.Enqueue(task);
//        }

//        public void process_tasks()
//        {
//            while (task_queue.TryDequeue(out var task))
//            {
//                Interlocked.Increment(ref running_tasks);

//                ThreadPool.QueueUserWorkItem(_ =>
//                {
//                    semaphore.WaitOne();
//                    try
//                    {
//                        task();
//                        Interlocked.Increment(ref processed_tasks);
//                    }
//                    finally
//                    {
//                        Interlocked.Decrement(ref running_tasks);
//                        semaphore.Release();
//                    }
//                });
//            }

//            while (Interlocked.CompareExchange(ref running_tasks, 0, 0) > 0)
//            {
//                Thread.Sleep(100);
//            }
//        }

//        public int get_processed_task_count()
//        {
//            return processed_tasks;
//        }
//    }

//    static void Main()
//    {
//        TaskQueue task_queue = new TaskQueue(3);

//        for (int i = 1; i <= 10; i++)
//        {
//            int task_number = i;
//            task_queue.enqueue(() =>
//            {
//                Console.WriteLine($"Task {task_number} started");
//                Thread.Sleep(1000);
//                Console.WriteLine($"Task {task_number} completed");
//            });
//        }

//        task_queue.process_tasks();


//        Console.WriteLine($"Total tasks processed: {task_queue.get_processed_task_count()}");
//    }
//    */

//    //4
//    /*
//    class FileWriter
//    {
//        private readonly string file_path;
//        private readonly Mutex mutex = new Mutex();

//        public FileWriter(string file_path)
//        {
//            this.file_path = file_path;
//        }

//        public void write(string message)
//        {
//            mutex.WaitOne();
//            try
//            {
//                using (StreamWriter writer = new StreamWriter(file_path, true))
//                {
//                    writer.WriteLine(message);
//                }
//            }
//            finally
//            {
//                mutex.ReleaseMutex();
//            }
//        }
//    }

//    static void Main()
//    {
//        FileWriter file_writer = new FileWriter("file213213213.txt");
//        Thread[] threads = new Thread[5];
//        for (int i = 0; i < 5; i++)
//        {
//            int index = i + 1;
//            threads[i] = new Thread(() =>
//            {
//                file_writer.write($"Thread {index} writes");
//            });
//        }

//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }

//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }
//    }
//    */

//    //5
//    /*
//    class ArrayOperations
//    {
//        private int[] numbers;
//        private readonly object lock_obj = new object();

//        public ArrayOperations(int length)
//        {
//            Random random = new Random();
//            numbers = new int[length];
//            for (int i = 0; i < length; i++)
//            {
//                numbers[i] = random.Next(1, 100);
//            }
//        }

//        public void add(int value)
//        {
//            Monitor.Enter(lock_obj);
//            try
//            {
//                for (int i = 0; i < numbers.Length; i++)
//                {
//                    numbers[i] += value;
//                }
//            }
//            finally
//            {
//                Monitor.Exit(lock_obj);
//            }
//        }

//        public void subtract(int value)
//        {
//            Monitor.Enter(lock_obj);
//            try
//            {
//                for (int i = 0; i < numbers.Length; i++)
//                {
//                    numbers[i] -= value;
//                }
//            }
//            finally
//            {
//                Monitor.Exit(lock_obj);
//            }
//        }

//        public void multiply(int value)
//        {
//            Monitor.Enter(lock_obj);
//            try
//            {
//                for (int i = 0; i < numbers.Length; i++)
//                {
//                    numbers[i] *= value;
//                }
//            }
//            finally
//            {
//                Monitor.Exit(lock_obj);
//            }
//        }

//        public void divide(int value)
//        {
//            Monitor.Enter(lock_obj);
//            try
//            {
//                for (int i = 0; i < numbers.Length; i++)
//                {
//                    if (value != 0)
//                    {
//                        numbers[i] /= value;
//                    }
//                    else
//                    {
//                        Console.WriteLine("cannot divide by zero");
//                    }
//                }
//            }
//            finally
//            {
//                Monitor.Exit(lock_obj);
//            }
//        }

//        public void print_array()
//        {
//            Monitor.Enter(lock_obj);
//            try
//            {
//                Console.WriteLine(string.Join(", ", numbers));
//            }
//            finally
//            {
//                Monitor.Exit(lock_obj);
//            }
//        }
//    }

//    static void Main()
//    {
//        ArrayOperations array_operations = new ArrayOperations(10);

//        Thread[] threads =
//        {
//            new Thread(() => array_operations.add(5)),
//            new Thread(() => array_operations.subtract(3)),
//            new Thread(() => array_operations.multiply(3)),
//            new Thread(() => array_operations.divide(2))
//        };
//        foreach (Thread thread in threads)
//        {
//            thread.Start();
//        }
//        foreach (Thread thread in threads)
//        {
//            thread.Join();
//        }

//        array_operations.print_array();
//    }
//    */
//}