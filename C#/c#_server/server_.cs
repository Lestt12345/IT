using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        class Player
        {
            private Dictionary<string, int> Cells;
            public string name;
            public int port;
            private char[][] own_area; // - = empty, O = ship, X = destroyed
            private char[][] enemy_area;// - = empty, X = destroyed

            public Player(int port)
            {
                Cells = new Dictionary<string, int>()
                {
                    { "A", 1 },
                    { "B", 2 },
                    { "C", 3 },
                    { "D", 4 },
                    { "E", 5 },
                    { "F", 6 },
                    { "G", 7 },
                    { "H", 8 },
                    { "I", 9 },
                    { "J", 10 }
                };
                this.port = port;
                enemy_area = new char[10][];
                own_area = new char[10][];
                for (int i = 0; i < 10; i++)
                {
                    enemy_area[i] = new char[10];
                    own_area[i] = new char[10];
                    for (int j = 0; j < 10; j++)
                    {
                        own_area[i][j] = '-';
                        enemy_area[i][j] = '-';
                    }
                }
            }

            public async Task fillArea_Async(IPAddress RemoteIPAddress)
            {
                string[] parts_coordinates, parts_cord1, parts_cord2;
                bool invalid_coordinates = false;

                // разбил на методы, так проще для понимания и читабельней
                bool is_placementValid(int x1, int y1, int x2, int y2)
                {
                    if (x1 < 0 || x2 < 0 || y1 < 0 || y2 < 0 || x1 >= 10 || x2 >= 10 || y1 >= 10 || y2 >= 10) return false;

                    int start_x = Math.Min(x1, x2);
                    int end_x = Math.Max(x1, x2);
                    int start_y = Math.Min(y1, y2);
                    int end_y = Math.Max(y1, y2);

                    for (int i = start_y - 1; i <= end_y + 1; i++)
                    {
                        for (int j = start_x - 1; j <= end_x + 1; j++)
                        {
                            if (i >= 0 && i < 10 && j >= 0 && j < 10 && own_area[i][j] == 'O')
                                return false; //ne ok
                        }
                    }

                    return true; //ok
                }

                void place_ship(int x1, int y1, int x2, int y2)
                {
                    int start_x = Math.Min(x1, x2);
                    int end_x = Math.Max(x1, x2);
                    int start_y = Math.Min(y1, y2);
                    int end_y = Math.Max(y1, y2);

                    for (int i = start_y; i <= end_y; i++)
                    {
                        for (int j = start_x; j <= end_x; j++)
                        {
                            own_area[i][j] = 'O';
                        }
                    }
                }

                async Task process_with_client(int ship_size, string ship_name)
                {
                    while (true)
                    {
                        SendAsync($"true/{(invalid_coordinates ? "Invalid coordinates\n" : "")}{print_areas(true)} Choose your {ship_name} ship coordinates (A|1-A|{ship_size}): ", RemoteIPAddress, port);
                        invalid_coordinates = false;

                        try
                        {
                            parts_coordinates = (await ReceiveAsync(port)).Trim().Split('-');
                            Console.WriteLine($"Parts: {string.Join(", ", parts_coordinates)}");
                            parts_cord1 = parts_coordinates[0].Trim().Split('|');
                            parts_cord2 = parts_coordinates[1].Trim().Split('|');
                            Console.WriteLine($"Parsed: {parts_cord1[0]} {parts_cord1[1]}, {parts_cord2[0]} {parts_cord2[1]}");

                            int y1 = Cells[parts_cord1[0].ToUpper()] - 1;
                            int x1 = int.Parse(parts_cord1[1]) - 1;
                            int y2 = Cells[parts_cord2[0].ToUpper()] - 1;
                            int x2 = int.Parse(parts_cord2[1]) - 1;

                            Console.WriteLine($"Coordinates: x1={x1}, y1={y1}, x2={x2}, y2={y2}");

                            if ((x1 == x2 && Math.Abs(y1 - y2) == ship_size - 1) || (y1 == y2 && Math.Abs(x1 - x2) == ship_size - 1))
                            {
                                if (is_placementValid(x1, y1, x2, y2))
                                {
                                    place_ship(x1, y1, x2, y2);
                                    Console.WriteLine("Ship placed successfully.");
                                    return;
                                }
                            }
                            invalid_coordinates = true;
                            Console.WriteLine("Invalid placement.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error: {ex.Message}");
                            invalid_coordinates = true;
                        }
                    }
                }

                await process_with_client(4, "quad");
                for (int i = 0; i < 2; i++) await process_with_client(3, $"triple #{i + 1}");
                for (int i = 0; i < 3; i++) await process_with_client(2, $"double #{i + 1}");
                for (int i = 0; i < 4; i++) await process_with_client(1, $"single #{i + 1}");

                SendAsync($"false/{print_areas(true)}\n Waiting for another player...", RemoteIPAddress, port);
            }

            public string print_areas(bool own_only)
            {
                string resault = "";
                resault += "Your area:\n";
                resault += "   1 2 3 4 5 6 7 8 9 10\n";
                for (int i = 0; i < 10; i++)
                {
                    resault += $" {Cells.Where(c => c.Value == i + 1).First().Key} ";
                    for (int j = 0; j < 10; j++) resault += $"{own_area[i][j]} ";
                    resault += "\n";
                }
                if (!own_only)
                {
                    resault += "\n";
                    resault += "Enemy`s area:\n";
                    resault += "   1 2 3 4 5 6 7 8 9 10\n";
                    for (int i = 0; i < 10; i++)
                    {
                        resault += $" {Cells.Where(c => c.Value == i + 1).First().Key}  ";
                        for (int j = 0; j < 10; j++) resault += $"{enemy_area[i][j]} ";
                        resault += "\n";
                    }
                }
                return resault;
            }

            public char is_hit(int x, int y)
            {
                if (own_area[y][x] == 'O')
                {
                    own_area[y][x] = 'X';
                    return 'O';
                }
                else return own_area[y][x];
            }

            public string fire(string coordinates, Player enemy, ref int player_hits)
            {
                if (string.IsNullOrWhiteSpace(coordinates))
                    return "Invalid coordinates";

                string[] parts = coordinates.Split('|');
                if (parts.Length != 2)
                    return "Invalid coordinates";

                if (!Cells.TryGetValue(parts[0].ToString(), out int y) ||
                    !int.TryParse(parts[1], out int x) ||
                    x < 1 || x > 10)
                {
                    return "Invalid coordinates";
                }

                x--;
                y--;

                char resault = enemy.is_hit(x, y);

                if (resault == 'O')
                {
                    enemy_area[y][x] = 'X';
                    Console.WriteLine($"[{DateTime.Now}] Player {name} hit the {enemy.name}`s ship on the {y} column, {x} row");
                    player_hits++;
                    return "Hit";
                }
                else if (resault == 'X')
                {
                    Console.WriteLine($"[{DateTime.Now}] Player {name} already hit the {enemy.name}`s ship on the {x} row, {y} column");
                    return "Already hit";
                }
                else
                {
                    Console.WriteLine($"[{DateTime.Now}] Player {name} missed the on the {enemy.name}`s area at {x} row, {y} column");
                    return "Miss";
                }
            }
        }

        class Game
        {
            private int LocalPort;
            private IPAddress RemoteIPAddress;
            private Player Player1;
            private Player Player2;

            public Game(int LocalPort, IPAddress RemoteIPAddress, int port1, int port2)
            {
                this.LocalPort = LocalPort;
                this.RemoteIPAddress = RemoteIPAddress;
                Player1 = new Player(port1);
                Player2 = new Player(port2);
            }

            public async Task startGames_Async()
            {
                try
                {
                    int[] player_ports = {
                        Convert.ToInt32(await ReceiveAsync(LocalPort)),
                        Convert.ToInt32(await ReceiveAsync(LocalPort))
                    };

                    bool player1_connected = player_ports[0] == Player1.port || player_ports[1] == Player1.port;
                    bool player2_connected = player_ports[0] == Player2.port || player_ports[1] == Player2.port;

                    if (player1_connected && player2_connected)
                    {
                        Console.WriteLine($"[{DateTime.Now}] Both players connected successfully.");
                    }

                    await SendAsync("start", RemoteIPAddress, Player1.port);
                    await SendAsync("start", RemoteIPAddress, Player2.port);

                    int player1_hits = 0, player2_hits = 0; // need 20 to win
                    bool player1_wants_to_go = true, player2_wants_to_go = true;
                    Console.WriteLine($"[{DateTime.Now}] Player 1 port: {Player1.port}, Player 2 port: {Player2.port}, Local port: {LocalPort}");
                    string response;
                    bool player1_move;
                    while (player1_wants_to_go && player2_wants_to_go)
                    {
                        player1_hits = 0; player2_hits = 0;
                        // Player 1 answer
                        await SendAsync("true/You want start new game?: ", RemoteIPAddress, Player1.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"true/You want start new game?: \" to Player 1");

                        await SendAsync("false/Waiting for Player 1", RemoteIPAddress, Player2.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 1\" to Player 2");

                        response = await ReceiveAsync(LocalPort);
                        if (response.ToLower().Contains("ye")/*ye, yes, yep, yea, yeah...*/) player1_wants_to_go = true;
                        else player1_wants_to_go = false;

                        // Player 2 answer
                        await SendAsync("true/You want start new game?: ", RemoteIPAddress, Player2.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"true/You want start new game?: \" to Player 2");

                        await SendAsync("false/Waiting for Player 2", RemoteIPAddress, Player1.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 2\" to Player 1");

                        response = await ReceiveAsync(LocalPort);
                        if (response.ToLower().Contains("ye")) player2_wants_to_go = true;
                        else player2_wants_to_go = false;

                        // chek
                        if (!player1_wants_to_go || !player2_wants_to_go)
                        {
                            await SendAsync("q", RemoteIPAddress, Player1.port);
                            Console.WriteLine($"[{DateTime.Now}] Sent \"q\" to Player 1");
                            await SendAsync("q", RemoteIPAddress, Player2.port);
                            Console.WriteLine($"[{DateTime.Now}] Sent \"q\" to Player 2");
                            break;
                        }

                        //ask for names
                        // Player 1
                        await SendAsync("true/Enter your name: ", RemoteIPAddress, Player1.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"true/Enter your name: \" to Player 1");

                        await SendAsync("false/Waiting for Player 1 ", RemoteIPAddress, Player2.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 1: \" to Player 2");

                        Player1.name = await ReceiveAsync(LocalPort);
                        Console.WriteLine($"[{DateTime.Now}] Player 1 name: {Player1.name}");
                        // Player 2
                        await SendAsync("true/Enter your name: ", RemoteIPAddress, Player2.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"true/Enter your name: \" to Player 2");

                        await SendAsync("false/Waiting for Player 2 ", RemoteIPAddress, Player1.port);
                        Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 2: \" to Player 1");

                        Player2.name = await ReceiveAsync(LocalPort);
                        Console.WriteLine($"[{DateTime.Now}] Player 2 name: {Player2.name}");

                        Console.WriteLine($"Player 1 name: {Player1.name}, Player 2 name: {Player2.name}");

                        // players fill areas
                        var player1_area = Task.Run(() => Player1.fillArea_Async(RemoteIPAddress));
                        var player2_area = Task.Run(() => Player2.fillArea_Async(RemoteIPAddress));
                        await Task.WhenAll(player1_area, player2_area);
                        Console.WriteLine($"[{DateTime.Now}] Areas filled by players");

                        if (new Random().Next(1) == 1) player1_move = true;
                        else player1_move = false;

                        Console.WriteLine($"[{ DateTime.Now}] {(player1_move ? "Player 1 move first" : "Player 2 move first")}");

                        //game
                        Console.WriteLine("Start game");
                        while (player1_hits < 20 && player2_hits < 20)
                        {
                            if (player1_move)
                            {
                                SendAsync($"false/Waiting for {Player1.name}: ", RemoteIPAddress, Player2.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 1: \" to Player 2");

                                SendAsync($"true/{Player1.print_areas(false)}Your turn: ", RemoteIPAddress, Player1.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"true/Player1.print_areas(false)Your turn: \" to Player 1");

                                string result = Player1.fire(await ReceiveAsync(LocalPort), Player2, ref player1_hits);
                                while (result == "Invalid input")
                                {
                                    await SendAsync($"true/{Player1.print_areas(false)}Invalid input, try again: ", RemoteIPAddress, Player1.port);
                                    Console.WriteLine($"[{DateTime.Now}] Sent \"true/Player1.print_areas(false)Invalid input, try again: \" to Player 1");
                                    result = Player1.fire(await ReceiveAsync(LocalPort), Player2, ref player1_hits);
                                }
                                SendAsync($"false/{result}\nWaiting for {Player2.name}: ", RemoteIPAddress, Player1.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"false/result Waiting for Player 2: \" to Player 1");
                            }
                            else
                            {
                                SendAsync($"false/Waiting for {Player2.name}: ", RemoteIPAddress, Player1.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"false/Waiting for Player 2: \" to Player 1");

                                SendAsync($"true/{Player2.print_areas(false)}Your turn: ", RemoteIPAddress, Player2.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"true/Player2.print_areas(false)Your turn: \" to Player 2");

                                string result = Player2.fire(await ReceiveAsync(LocalPort), Player1, ref player2_hits);
                                while (result == "invalid input")
                                {
                                    await SendAsync($"true/{Player2.print_areas(false)}Invalid input, try again: ", RemoteIPAddress, Player2.port);
                                    Console.WriteLine($"[{DateTime.Now}] Sent \"true/Player2.print_areas(false)Invalid input, try again: \" to Player 2");
                                    result = Player1.fire(await ReceiveAsync(LocalPort), Player1, ref player2_hits);
                                }
                                SendAsync($"[{DateTime.Now}] false/{result}\nWaiting for {Player1.name}: ", RemoteIPAddress, Player2.port);
                                Console.WriteLine($"[{DateTime.Now}] Sent \"false/result Waiting for Player 1: \" to Player 2");
                            }

                            if (player1_hits == 20 && player2_hits == 20)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    SendAsync($"false/Nobody`s win\nContinue in {3 - i}...", RemoteIPAddress, Player1.port);
                                    SendAsync($"false/Nobody`s win\nContinue in {3 - i}...", RemoteIPAddress, Player2.port);
                                    await Task.Delay(1000);
                                }
                                Console.WriteLine($"[{DateTime.Now}] Nobody`s win");
                            }
                            else if (player1_hits == 20)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    SendAsync($"false/You win\nContinue in {3 - i}...", RemoteIPAddress, Player1.port);
                                    SendAsync($"false/You lose\nContinue in {3 - i}...", RemoteIPAddress, Player2.port);
                                    await Task.Delay(1000);
                                }
                                Console.WriteLine($"[{DateTime.Now}] {Player1.name} win");
                            }
                            else if (player2_hits == 20)
                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    SendAsync($"false/You lose\nContinue in {3 - i}...", RemoteIPAddress, Player1.port);
                                    SendAsync($"false/You win\nContinue in {3 - i}...", RemoteIPAddress, Player2.port);
                                    await Task.Delay(1000);
                                }
                                Console.WriteLine($"[{DateTime.Now}] {Player2.name} win");
                            }
                        }
                    }
                }
                // ну а вдруг))
                catch (OperationCanceledException ex)
                {
                    Console.WriteLine($"[{DateTime.Now}] Oops... big super massice fatal error)):\n{ex.Message}");
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"[{DateTime.Now}] Oops... big super massice fatal error)):\n{ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[{DateTime.Now}] Oops... big super massice fatal error)):\n{ex.Message}");
                }
                finally
                {
                    await SendAsync("q", RemoteIPAddress, Player1.port);
                    Console.WriteLine($"[{DateTime.Now}] Sent \"q\" to Player 1");
                    await SendAsync("q", RemoteIPAddress, Player2.port);
                    Console.WriteLine($"[{DateTime.Now}] Sent \"q\" to Player 2");
                }
            }
        }

        static async Task Main(string[] args)
        {
            int LocalPort = 7777;
            int Player1Port = 8001, Player2Port = 8002;
            IPAddress RemoteIPAddress = IPAddress.Parse("127.0.0.1");
            await new Game(LocalPort, RemoteIPAddress, Player1Port, Player2Port).startGames_Async();
            Console.WriteLine("Game over");
        }

        static async Task<string> ReceiveAsync(int port)
        {
            UdpClient udpClient = new UdpClient(port);
            try
            {
                var response = await udpClient.ReceiveAsync();
                udpClient.Close();
                string result = Encoding.Unicode.GetString(response.Buffer);
                Console.WriteLine($"[{DateTime.Now}] Received \"{result}\" from {response.RemoteEndPoint}");
                return result;
            }
            catch (OperationCanceledException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                udpClient.Close();
                udpClient.Dispose();
            }
            return "Error";
        }

        static async Task SendAsync(string message, IPAddress ip_address, int port)
        {
            UdpClient udpClient = new UdpClient();
            IPEndPoint iPEndPoint = new IPEndPoint(ip_address, port);
            try
            {
                byte[] bytes = Encoding.Unicode.GetBytes(message);
                await udpClient.SendAsync(bytes, bytes.Length, iPEndPoint);
            }
            catch (SocketException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                udpClient.Close();
                udpClient.Dispose();
            }
        }
    }
}
