using System.Net.Sockets;
using System.Reflection.PortableExecutable;

namespace SocketClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient();
            await tcpClient.ConnectAsync("127.0.0.1", 5000);
            Console.WriteLine("Connected to Server");

            using (NetworkStream stream = tcpClient.GetStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    using (StreamWriter writer = new StreamWriter(stream) { AutoFlush = true })
                    {
                        int ch = -1;
                        string message = "";
                        while (ch != 0)
                        {
                            Console.WriteLine("\nMenu:");
                            Console.WriteLine("1: Search by ID");
                            Console.WriteLine("2: Search by Price Range");
                            Console.WriteLine("3: Search by Brand and Model");
                            Console.WriteLine("4: Make Unavailable");
                            Console.WriteLine("5: Add to Available");
                            Console.WriteLine("6: Sell Car");
                            Console.WriteLine("7: Edit Car");
                            Console.WriteLine("0: Exit\n");

                            Console.Write("Enter your choice: ");
                            ch = int.Parse(Console.ReadLine());

                            switch (ch)
                            {
                                case 1:
                                    Console.Write("Enter ID: ");
                                    int id = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{id}");
                                    break;
                                case 2:
                                    Console.Write("Enter min price: ");
                                    int min = int.Parse(Console.ReadLine());
                                    Console.Write("Enter max price: ");
                                    int max = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{min}_{max}");
                                    break;
                                case 3:
                                    Console.Write("Enter brand: ");
                                    string brand = Console.ReadLine();
                                    Console.Write("Enter model: ");
                                    string model = Console.ReadLine();
                                    await writer.WriteLineAsync($"{ch}|{brand}_{model}");
                                    break;
                                case 4:
                                    Console.Write("Enter ID: ");
                                    int id_ = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{id_}");
                                    break;
                                case 5:
                                    Console.Write("Enter ID: ");
                                    int id__ = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{id__}");
                                    break;
                                case 6:
                                    Console.Write("Enter ID: ");
                                    int id___ = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{id___}");
                                    break;
                                case 7:
                                    Console.Write("Enter ID: ");
                                    int id____ = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new brand: ");
                                    string brand_ = Console.ReadLine();
                                    Console.Write("Enter new model: ");
                                    string model_ = Console.ReadLine();
                                    Console.Write("Enter new price: ");
                                    int price = int.Parse(Console.ReadLine());
                                    Console.Write("Enter new availability: ");
                                    bool is_available = true;
                                    Console.Write("Enter new quantity: ");
                                    int quantity = int.Parse(Console.ReadLine());
                                    await writer.WriteLineAsync($"{ch}|{id____}_{brand_}_{model_}_{price}_{is_available}_{quantity}");
                                    break;
                                case 0:
                                    return;
                                default:
                                    Console.WriteLine("Invalid choice.");
                                    break;
                            }
                            string response = await reader.ReadLineAsync();
                            Console.WriteLine(response);
                        }
                    }
                }
            }
        }
    }
}