// ОБЩИЙ ЗНАМЕНАТЕЛЬ

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


// УПРОСТИТЬ

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