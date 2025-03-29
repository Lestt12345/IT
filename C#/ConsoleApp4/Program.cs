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