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