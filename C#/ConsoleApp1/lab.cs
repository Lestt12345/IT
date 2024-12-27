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