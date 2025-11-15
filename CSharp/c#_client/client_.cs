using Newtonsoft.Json;

namespace Client
{
    class Program
    {
        static readonly string API_key = "128b2a9cf0ab4b608b1133298600fe11";
        static readonly string save_file = "saved_news.json";

        class News_response
        {
            public string status { get; set; }
            public int total_results { get; set; }
            public List<Article> articles { get; set; }
        }

        class Article
        {
            public string title { get; set; }
            public string description { get; set; }
            public string url { get; set; }
            public string published_at { get; set; }
        }

        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("NewsReader Menu:");
                Console.WriteLine("1. View top news by category");
                Console.WriteLine("2. Search news by keyword");
                Console.WriteLine("3. View saved articles");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        await View_by_category();
                        break;
                    case "2":
                        await View_by_keyword();
                        break;
                    case "3":
                        View_saved_articles();
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void Display_articles(List<Article> articles, bool save_option)
        {
            if (articles == null || articles.Count == 0)
            {
                Console.WriteLine("No articles found.");
                Console.Write("To main menu press enter...");
                Console.ReadLine();
                Console.Clear();
                return;
            }

            int i = 0;
            foreach (var article in articles)
            {
                Console.WriteLine($"Article {++i}:");
                Console.WriteLine($"Title: {article.title}");
                Console.WriteLine($"Description: {article.description}");
                Console.WriteLine($"URL: {article.url}");
                Console.WriteLine($"Published At: {article.published_at}");
                Console.WriteLine("-----------------------------------");
                if (i % 5 == 0)
                {
                    while (true)
                    {
                        Console.WriteLine("1. See more news");
                        if (save_option) Console.WriteLine("2. Save articles");
                        Console.WriteLine("3. To main menu");
                        Console.Write("Choose an option: ");
                        string option = Console.ReadLine();
                        switch (option)
                        {
                            case "1":
                                continue;
                            case "2":
                                if (!save_option)
                                {
                                    Console.WriteLine("Invalid input. Please try again.");
                                    continue;
                                }
                                List<Article> articles_to_save = new List<Article>();
                                while (true)
                                {
                                    Console.Write("Enter the indexes of articles you want to save (1,2,4 or 1): ");
                                    string choiced_indices = Console.ReadLine();
                                    string[] indices = choiced_indices.Split(',');
                                    try
                                    {
                                        if (indices.Length == 0) throw new Exception();
                                        int[] indices_int = Array.ConvertAll(indices, int.Parse);
                                        if (indices_int.Any(ind => ind < 1 || ind > articles.Count)) throw new Exception();
                                        foreach (int index in indices_int) articles_to_save.Add(articles[index - 1]);
                                        break;
                                    }
                                    catch (Exception ex)
                                    {
                                        //ClearLastLine
                                        int currentLineCursor1 = Console.CursorTop;
                                        Console.SetCursorPosition(0, currentLineCursor1 - 1);
                                        Console.Write(new string(' ', Console.WindowWidth));
                                        Console.SetCursorPosition(0, currentLineCursor1 - 1);
                                        //ClearLastLine

                                        Console.WriteLine($"Ivalid input.");
                                    }
                                }
                                Save_articles(articles_to_save);
                                break;
                            case "3":
                                return;
                            default:
                                Console.WriteLine("Invalid input. Please try again.");
                                break;
                        }
                        //clear menu
                        int currentLineCursor = Console.CursorTop;
                        for (int j = 0; j < 4; j++)
                        {
                            if (currentLineCursor - j - 1 >= 0) // Проверяем, чтобы не выйти за пределы консоли
                            {
                                Console.SetCursorPosition(0, currentLineCursor - j - 1);
                                Console.Write(new string(' ', Console.WindowWidth));
                            }
                        }
                        Console.SetCursorPosition(0, Math.Max(0, currentLineCursor - 4));
                        //clear menu
                    }
                }
            }
            Console.Write("To main menu press enter...");
            Console.ReadLine();
            Console.Clear();
        }

        static async Task Save_articles(List<Article> articles)
        {
            var saved_articles = Load_saved_articles();
            foreach (var article in articles)
            {
                saved_articles.Add(article);
            }
            using StreamWriter writer = new StreamWriter(save_file, false);
            {
                await writer.WriteLineAsync(JsonConvert.SerializeObject(saved_articles));
            };
        }

        static List<Article> Load_saved_articles()
        {
            if (File.Exists(save_file))
            {
                var content = File.ReadAllText(save_file);
                return JsonConvert.DeserializeObject<List<Article>>(content) ?? new List<Article>();
            }

            return new List<Article>();
        }

        static void View_saved_articles()
        {
            var savedArticles = Load_saved_articles();
            Display_articles(savedArticles, false);
        }

        static async Task View_by_category()
        {
            Console.Clear();
            Console.Write("Enter category: ");
            string category = Console.ReadLine();
            string url = $"https://newsapi.org/v2/top-headlines?category={category}&from={DateTime.Now.AddMonths(-6).ToString("yyyy-MM-dd")}&apiKey={API_key}";
            Console.Clear();
            try
            {
                using HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(url);
                var news = JsonConvert.DeserializeObject<News_response>(response);
                Console.Clear();
                Display_articles(news?.articles, true);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                Task.Delay(3000).Wait();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Task.Delay(3000).Wait();
                Console.Clear();
            }
        }

        static async Task View_by_keyword()
        {
            Console.Clear();
            Console.Write("Enter a keyword to search for: ");
            string keyword = Console.ReadLine();
            Console.Clear();
            string url = $"https://newsapi.org/v2/everything?q={keyword}&from={DateTime.Now.AddMonths(-6).ToString("yyyy-MM-dd")}&apiKey={API_key}";

            try
            {
                using HttpClient client = new HttpClient();
                var response = await client.GetStringAsync(url);
                var news = JsonConvert.DeserializeObject<News_response>(response);
                Display_articles(news?.articles, true);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
                Task.Delay(3000).Wait();
                Console.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Task.Delay(3000).Wait();
                Console.Clear();
            }
        }
    }
}