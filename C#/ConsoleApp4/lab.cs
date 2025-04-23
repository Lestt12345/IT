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