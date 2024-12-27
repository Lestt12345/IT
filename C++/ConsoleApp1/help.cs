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

