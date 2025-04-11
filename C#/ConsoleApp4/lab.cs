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