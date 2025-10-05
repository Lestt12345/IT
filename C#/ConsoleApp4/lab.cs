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