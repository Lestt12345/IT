using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serilog;

/* cupe type

  capacity = 40 seats

   ____-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____#10__-____
  | [~] [~] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] |
  | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- |
-<| [~] [~] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] |>-
  | ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~ | ~~~~~~~ | ~~~~~~~ |
  |____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____|

  cupe example:
               [1] [2]
               [3] [4]

*/
/* plackart type

  capacity = 54 seats

   ____-_________-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____
  | [~] [~] | [~] [~] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] |
  | [~] [~] | [~] [~] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] | [3] [4] |
-<| ~~~~~~~~~~~~~~~~~~#10~~~~~~~#11~~~~~~~#12~~~~~~~#13~~~~~~~#14~~~~~~~#15~~~~~~~#16~~~~~~~#17~~~~~~~#18~~~~~~ |>-
  | ~~~~~~~~~~~~~~~~~~~ [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] | [1] [2] |
  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|

  plackart top example:
                           [1] [2]
                           [3] [4]
  plackart bottom example:
                           [1] [2]
*/
/* empty or not
true = empty
false = not empty
*/
/* vagon type
0 - compartment type
1 - platzkart type
 */

class Program
{
    class Bank_card
    {
        public long number { get; private set; }
        public int cvc { get; private set; }

        public Bank_card(long number, int cvc)
        {
            this.number = number;
            this.cvc = cvc;
        }

        public bool pay(int cvc)
        {
            return this.cvc == cvc;
        }
    }

    class Vagon_compartmentType
    {
        [JsonInclude]
        public bool[][] compartments = new bool[10][];

        public Vagon_compartmentType() { }

        public Vagon_compartmentType(int a)
        {
            for (int i = 0; i < 10; i++)
            {
                compartments[i] = new bool[4];
                for (int j = 0; j < 4; j++)
                {
                    compartments[i][j] = true;
                }
            }
        }

        public void info_emptyOrNot(bool with_compartmentIndex)
        {
            Console.WriteLine("Compartment type");

            if (with_compartmentIndex)
            {
                Console.WriteLine("   ____-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____#10__-____");
            }
            else
            {
                Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");
            }

            Console.Write("  | [~] [~] |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" [");
                if (compartments[i][0] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] [");
                if (compartments[i][1] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] |");
            }
            Console.WriteLine();

            Console.WriteLine("  | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- |");

            Console.Write("-<| [~] [~] |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" [");
                if (compartments[i][2] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] [");
                if (compartments[i][3] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] |");
            }
            Console.WriteLine(">-");

            Console.WriteLine("  | ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~ | ~~~~~~~ | ~~~~~~~ |");

            Console.WriteLine("  |____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____|");
        }

        public void info_compartment(int compartment)
        {
            Console.Write("[");
            if (compartments[compartment - 1][0] == true)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("X");
            }
            Console.Write("] [");
            if (compartments[compartment - 1][1] == true)
            {
                Console.Write("2");
            }
            else
            {
                Console.Write("X");
            }
            Console.WriteLine("]");

            Console.Write("[");
            if (compartments[compartment - 1][2] == true)
            {
                Console.Write("3");
            }
            else
            {
                Console.Write("X");
            }
            Console.Write("] [");
            if (compartments[compartment - 1][3] == true)
            {
                Console.Write("4");
            }
            else
            {
                Console.Write("X");
            }
            Console.WriteLine("]");
        }
    }

    class Vagon_platzkartType
    {
        [JsonInclude]
        public bool[][] platzkarts_top = new bool[9][];
        [JsonInclude]
        public bool[][] platzkarts_bottom = new bool[9][];

        public Vagon_platzkartType() { }

        public Vagon_platzkartType(int a)
        {
            for (int i = 0; i < 9; i++)
            {
                platzkarts_top[i] = new bool[4];
                platzkarts_bottom[i] = new bool[2];
                for (int j = 0; j < 4; j++)
                {
                    platzkarts_top[i][j] = true;
                }
                for (int j = 0; j < 2; j++)
                {
                    platzkarts_bottom[i][j] = false;
                }
            }
        }

        public void info_emptyOrNot(bool with_platzkartIndex)
        {
            Console.WriteLine("Platzkart type");

            if (with_platzkartIndex)
            {
                Console.WriteLine("   ____-_________-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____");
            }
            else
            {
                Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");
            }

            Console.Write("  | [~] [~] | [~] [~] |");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(" [");
                if (platzkarts_top[i][0] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] [");
                if (platzkarts_top[i][1] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] |");
            }
            Console.WriteLine();

            Console.Write("  | [~] [~] | [~] [~] |");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(" [");
                if (platzkarts_top[i][2] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] [");
                if (platzkarts_top[i][3] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] |");
            }
            Console.WriteLine("");

            if (with_platzkartIndex)
            {
                Console.WriteLine("-<| ~~~~~~~~~~~~~~~~~~#10~~~~~~~#11~~~~~~~#12~~~~~~~#13~~~~~~~#14~~~~~~~#15~~~~~~~#16~~~~~~~#17~~~~~~~#18~~~~~~ |>-");
            }
            else
            {
                Console.WriteLine("-<| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ |>-");
            }

            Console.Write("  | ~~~~~~~~~~~~~~~~~~~");
            for (int i = 0; i < 9; i++)
            {
                Console.Write(" [");
                if (platzkarts_bottom[i][0] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] [");
                if (platzkarts_bottom[i][1] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("] |");
            }
            Console.WriteLine();

            Console.WriteLine("  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|");
        }

        public void info_platzkart(int platzkart)
        {
            if (platzkart <= 9)
            {
                Console.Write("[");
                if (platzkarts_top[platzkart - 1][0] == true)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("X");
                }
                Console.Write("] [");
                if (platzkarts_top[platzkart - 1][1] == true)
                {
                    Console.Write("2");
                }
                else
                {
                    Console.Write("X");
                }
                Console.WriteLine("]");

                Console.Write("[");
                if (platzkarts_top[platzkart - 1][2] == true)
                {
                    Console.Write("3");
                }
                else
                {
                    Console.Write("X");
                }
                Console.Write("] [");
                if (platzkarts_top[platzkart - 1][3] == true)
                {
                    Console.Write("4");
                }
                else
                {
                    Console.Write("X");
                }
                Console.WriteLine("]");
            }
            else
            {
                Console.Write("[");
                if (platzkarts_bottom[platzkart - 9 - 1][0] == true)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write("X");
                }
                Console.Write("] [");
                if (platzkarts_bottom[platzkart - 9 - 1][1] == true)
                {
                    Console.Write("2");
                }
                else
                {
                    Console.Write("X");
                }
                Console.WriteLine("]");
            }
        }
    }

    class Train_composition
    {
        [JsonInclude]
        public string route_name;
        [JsonInclude]
        public List<Vagon_compartmentType> vagons_compartmentType { get; set; }
        [JsonInclude]
        public List<Vagon_platzkartType> vagons_platzkartType { get; set; }

        public Train_composition()
        {
            route_name = "none";
            vagons_compartmentType = new List<Vagon_compartmentType>();
            vagons_platzkartType = new List<Vagon_platzkartType>();
        }

        public Train_composition(string route_name, List<Vagon_compartmentType> vagons_compartmentType, List<Vagon_platzkartType> vagons_platzkartType)
        {
            this.route_name = route_name;
            this.vagons_compartmentType = vagons_compartmentType;
            this.vagons_platzkartType = vagons_platzkartType;
        }

        public Train_composition(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Log.Error($"File not found: {path}");
                    throw new FileNotFoundException($"The file at {path} was not found.");
                }
                string json = File.ReadAllText(path);
                var trainComposition_data = JsonSerializer.Deserialize<Train_composition>(json);
                route_name = trainComposition_data.route_name;
                vagons_compartmentType = trainComposition_data.vagons_compartmentType;
                vagons_platzkartType = trainComposition_data.vagons_platzkartType;
                if (trainComposition_data == null || String.IsNullOrWhiteSpace(route_name) || vagons_compartmentType == null || vagons_platzkartType == null) throw new Exception();
                Log.Information("operation 'Deserialize train' success");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "operation 'Deserialize train' failed");
                route_name = " ";
            }
        }

        public void trainComposition_serialize()
        {
            try
            {
                string path = $"routs\\{route_name}.json";
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
                        fs.Write(info, 0, info.Length);
                    }
                }
                Train_composition trainComposition_data = new Train_composition(route_name, vagons_compartmentType, vagons_platzkartType);
                File.WriteAllText(path, JsonSerializer.Serialize(trainComposition_data));
                Train_composition _trainComposition_data = JsonSerializer.Deserialize<Train_composition>(File.ReadAllText(path));
                if (JsonSerializer.Serialize(trainComposition_data) != JsonSerializer.Serialize(_trainComposition_data)) throw new Exception();
                Log.Information("Train composition successfully serialized to '{path}'", path);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in 'trainComposition_serialize' method");
            }
        }

        public void trainComposition_compartmentType_info()
        {
            try
            {
                int i = 0;
                foreach (var it in vagons_compartmentType)
                {
                    i++;
                    Console.Write(i + "# ");
                    it.info_emptyOrNot(false);
                    Console.WriteLine();
                }
                Log.Information("Train composition compartment type displayed");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error displaying compartment type info");
            }
        }

        public void trainComposition_platzkartType_info()
        {
            try
            {
                int i = 0;
                foreach (var it in vagons_platzkartType)
                {
                    i++;
                    Console.Write(i + "# ");
                    it.info_emptyOrNot(false);
                    Console.WriteLine();
                }
                Log.Information("Train composition compartment type displayed");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error displaying compartment info");
            }
        }
    }

    class Ticket
    {
        [JsonInclude]
        public string route_name;
        [JsonInclude]
        public int? vagon_ind;
        [JsonInclude]
        public int? vagon_type;
        [JsonInclude]
        bool? is_compartment;
        [JsonInclude]
        int? compartmentOrPlatzkart_ind;
        [JsonInclude]
        public int? seat_ind;
        [JsonInclude]
        public bool? is_fake;

        public Ticket() { }

        public Ticket(string route_name, int vagon_ind, int vagon_type, bool is_compartment, int compartmentOrPlatzkart_ind, int seat_ind, bool is_fake)
        {
            this.route_name = route_name;
            this.vagon_ind = vagon_ind;
            this.vagon_type = vagon_type;
            this.is_compartment = is_compartment;
            this.compartmentOrPlatzkart_ind = compartmentOrPlatzkart_ind;
            this.seat_ind = seat_ind;
            this.is_fake = is_fake;
        }

        public Ticket(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    Log.Error($"File not found: {path}");
                    throw new FileNotFoundException($"The file at {path} was not found.");
                }
                string json = File.ReadAllText(path);
                var ticket_data = JsonSerializer.Deserialize<Ticket>(json);
                route_name = ticket_data.route_name;
                vagon_ind = ticket_data.vagon_ind;
                vagon_type = ticket_data.vagon_type;
                is_compartment = ticket_data.is_compartment;
                compartmentOrPlatzkart_ind = ticket_data.compartmentOrPlatzkart_ind;
                seat_ind = ticket_data.seat_ind;
                is_fake = ticket_data.is_fake;
                if (String.IsNullOrEmpty(route_name) ||
                    !vagon_ind.HasValue ||
                    !vagon_type.HasValue ||
                    !is_compartment.HasValue ||
                    !compartmentOrPlatzkart_ind.HasValue ||
                    !seat_ind.HasValue ||
                    !is_fake.HasValue) throw new Exception();
                Log.Information("operation 'Deserialize ticket' success");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "operation 'Deserialize ticket' failed");
                route_name = string.Empty;
                vagon_ind = null;
                vagon_type = null;
                is_compartment = null;
                compartmentOrPlatzkart_ind = null;
                seat_ind = null;
                is_fake = null;
            }
        }

        public int make_ticket(string route)
        {
            int id = 0;
            string directory = "tickets";
            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                List<int> used_ids = new List<int>();
                foreach (string file in Directory.GetFiles(directory))
                {
                    string file_name = Path.GetFileNameWithoutExtension(file);
                    string[] parts = file_name.Split('_');
                    if (parts[0] == route)
                    {
                        used_ids.Add(int.Parse(parts[1]));
                    }
                }
                while (true)
                {
                    id++;
                    if (!used_ids.Contains(id))
                    {
                        break;
                    }
                }
                Log.Information("Ticket ids successfully finded");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in ticket ids finder");
            }

            string path = $"{directory}\\{route}_{id}.json";
            try
            {
                if (!File.Exists(path))
                {
                    using (FileStream fs = File.Create(path))
                    {
                        byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
                        fs.Write(info, 0, info.Length);
                    }
                }
                File.WriteAllText(path, JsonSerializer.Serialize(this));
                Ticket _ticket_data = JsonSerializer.Deserialize<Ticket>(File.ReadAllText(path));
                if (JsonSerializer.Serialize(this) != JsonSerializer.Serialize(_ticket_data)) throw new Exception();
                Log.Information("Ticket successfully serialized to '{path}'", path);
                return id;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Error in 'make_ticket' method");
                return 0;
            }
        }
    }

    static Bank_card[] Cards =
    {
    new Bank_card(1111222233334444, 111),
    new Bank_card(5555666677778888, 222),
    new Bank_card(9999000099990000, 333)
    };

    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .WriteTo.File("Log file.log")
            .CreateLogger();
        Log.Information("_________________LOGGING WORK SUCCESSFULLY_________________");

        Menu();

        Log.Information("Program ends");
    }

    static void Menu()
    {
        Log.Debug("Menu function is running");
        int stage = 1;
        int case2_stage = 1;
        int err_loop = 0;
        int err_loop_case2 = 0;

        int ch = -1;
        while (true)
        {
            Console.Clear();
            switch (stage)
            {
                case 1:
                    err_loop = 0;
                    Log.Information("Switched to case 1 in \"Menu\"");
                    Console.WriteLine("Menu:\n1 - Get ticket\n2 - Enter to the train\n");
                    Console.Write("Choose (0 - exit): ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Log.Warning("Invalid symbol in menu case 1");
                        Console.WriteLine("\nInvalid symbol, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (ch == 0) return;
                    if (ch < 1 || ch > 2)
                    {
                        Log.Warning("Invalid choice in menu case 1");
                        Console.WriteLine("\nInvalid choice, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    stage = ch + 1;
                    break;

                case 2:
                    err_loop = 0;
                    Log.Information("Switched to case 2 in \"Menu\"");
                    Console.WriteLine("Menu:\n1 - buy ticket\n2 - make fake ticket");
                    Console.Write("Choose (0 - back): ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Log.Warning("Invalid symbol in menu case 2");
                        Console.WriteLine("\nInvalid symbol, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (ch == 0)
                    {
                        stage = 1;
                        continue;
                    }
                    if (ch < 1 || ch > 2)
                    {
                        Log.Warning("Invalid choice in menu case 2");
                        Console.WriteLine("\nInvalid choice, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    Get_ticket(Convert.ToBoolean(ch - 1));
                    stage = 1;
                    break;

                case 3:
                    err_loop = 0;
                    Log.Information("Switched to case 3 in \"Menu\"");
                    Console.WriteLine("Menu:\n1 - use ticket\n2 - try enter to the train without ticket :)");
                    Console.Write("Choose (0 - back): ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Log.Warning("Invalid symbol in menu");
                        Console.WriteLine("\nInvalid symbol, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (ch == 0)
                    {
                        stage = 1;
                        continue;
                    }
                    if (ch < 1 || ch > 2)
                    {
                        Log.Warning("Invalid choice in menu case 3");
                        Console.WriteLine("\nInvalid choice, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    Random random = new Random();
                    if (ch == 1)
                    {
                        int ch_;
                        if (!Directory.EnumerateFileSystemEntries("tickets").Any())
                        {
                            Console.Clear();
                            Log.Warning("No tickets in 'tickets'");
                            Console.WriteLine("There no tickets, press any button to continue...");
                            Console.ReadKey();
                            stage = 1;
                            continue;
                        }
                        var tickets = Directory.GetFiles("tickets", "*.json");
                        while (true)
                        {
                            Console.Clear();
                            for (int i = 0; i < tickets.Length; i++)
                            {
                                Console.WriteLine(i + 1 + " - " + Path.GetFileNameWithoutExtension(tickets[i]));
                            }
                            Console.Write("\nChoose (0 - back): ");
                            try
                            {
                                ch_ = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Warning("Invalid symbol in ticket selection");
                                Console.WriteLine("\nInvalid symbol, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            if (ch_ == 0)
                            {
                                break;
                            }
                            if (ch_ < 1 || ch_ > tickets.Length)
                            {
                                Log.Warning("Invalid choice in menu case 3");
                                Console.WriteLine("\nInvalid choice, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            var routes = Directory.GetFiles("routs", "*.json");
                            string ticket_name = Path.GetFileNameWithoutExtension(tickets[ch_ - 1]).Split('_')[0];
                            bool route_exists = false;
                            foreach (var route in routes)
                            {
                                if (Path.GetFileNameWithoutExtension(route) == ticket_name)
                                {
                                    route_exists = true;
                                    break;
                                }
                            }
                            if (!route_exists)
                            {
                                Console.WriteLine("Ticket is expired, do you want delete ticket?\npress 'y' if you want");
                                ConsoleKeyInfo key = Console.ReadKey();
                                if (key.KeyChar == 'y' || key.KeyChar == 'Y') File.Delete(tickets[ch_ - 1]);
                                continue;
                            }
                            Ticket ticket = new Ticket(tickets[ch_ - 1]);
                            if (ticket == null || String.IsNullOrEmpty(ticket.route_name))
                            {
                                Log.Error("Ticket is null");
                                Console.WriteLine("\nOops... Some thing wrong, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            string ticket_file_name = Path.GetFileNameWithoutExtension(tickets[ch_ - 1]).Split('_')[0];
                            if (ticket.is_fake == true && random.Next(2) == 0)
                            {
                                Log.Information("Enter to the train with fake ticket '{ticket_file_name}'", ticket_file_name);
                                Console.WriteLine("You in the train, press any button to return to the menu...");
                                File.Delete(tickets[ch_ - 1]);
                                Console.ReadKey();
                                stage = 1;
                                break;
                            }
                            else if (ticket.is_fake == true && random.Next(2) != 0)
                            {
                                Log.Information("Not enter to the train with fake ticket '{ticket_file_name}'", ticket_file_name);
                                Console.WriteLine("You unlucky, press any button to return to the menu...");
                                File.Delete(tickets[ch_ - 1]);
                                Console.ReadKey();
                                stage = 1;
                                break;
                            }
                            Log.Information("Enter to the train with real ticket '{ticket_file_name}'", ticket_file_name);
                            Console.WriteLine("You in the train, press any button to return to the menu...");
                            File.Delete(tickets[ch_ - 1]);
                            Console.ReadKey();
                            stage = 1;
                            break;
                        }
                    }
                    if (ch == 2 && random.Next(3) == 2)
                    {
                        Log.Information("Enter to the train without ticket");
                        Console.WriteLine("You in the train, press any button to return to the menu...");
                        Console.ReadKey();
                        stage = 1;
                        continue;
                    }
                    else if (ch == 2 && random.Next(3) != 2)
                    {
                        Log.Information("Not enter to the train without ticket");
                        Console.WriteLine("You unlucky, press any button to return to the menu...");
                        Console.ReadKey();
                        stage = 1;
                        continue;
                    }
                    break;

                default:
                    err_loop++;
                    Log.Warning("Switched to default in \"Menu\" {err_loop} times", err_loop);
                    if (err_loop >= 5)
                    {
                        Console.WriteLine("The program stopped incorrectly :(");
                        Log.Error("Program stopped: many enters to incorrect case in \"Menu\"");
                        return;
                    }
                    break;
            }
        }
    }

    static void Get_ticket(bool fake)
    {
        Log.Debug("Get_ticket function is running");
        if (!Directory.EnumerateFileSystemEntries("routs").Any())
        {
            Console.Clear();
            Log.Warning("No routs in 'routs'");
            Console.WriteLine("There no routs, press any button to continue...");
            Console.ReadKey();
            return;
        }
        int stage = 1;
        //for ticket
        string route_name = "";
        int vagon_type = -1;
        int vagon_ind = -1;
        int compartment_ind = -1;
        int platzkart_ind = -1;
        int seat_ind = -1;
        bool payed = false;
        //for pay
        long number = -1;
        int cvc = -1;
        //for break error loop
        int err_loop = 0;
        //sostav
        Train_composition train_composition1 = null;

        int ch;
        while (true)
        {
            Console.Clear();
            switch (stage)
            {
                case 1:
                    Log.Information("Switched to case 1 in \"Get_ticket\"");
                    err_loop = 0;
                    Console.WriteLine("Select a route:");
                    var routes = Directory.GetFiles("routs", "*.json");
                    for (int i = 0; i < routes.Length; i++)
                    {
                        Console.WriteLine(i + 1 + "-" + Path.GetFileNameWithoutExtension(routes[i]));
                    }
                    Console.Write("\nChoose (0 - back): ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Log.Warning("Invalid symbol in route selection");
                        Console.WriteLine("\nInvalid symbol, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (ch == 0) return;
                    if (ch < 1 || ch > routes.Length)
                    {
                        Log.Warning("Invalid choice in get_ticket case 1");
                        Console.WriteLine("\nInvalid choice, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    route_name = Path.GetFileNameWithoutExtension(routes[ch - 1]);
                    train_composition1 = new Train_composition($"routs\\{route_name}.json");
                    if (train_composition1 == null)
                    {
                        Log.Error("Train composition is null");
                        Console.WriteLine("\nOops... Some thing wrong, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    Log.Information("Route selected: " + route_name);
                    stage++;
                    break;

                case 2:
                    Log.Information("Switched to case 2 in \"Get_ticket\"");
                    err_loop = 0;
                    Console.WriteLine("Select a vagon type:");
                    Console.WriteLine($"1 - Compartment ({train_composition1.vagons_compartmentType.Count})");
                    Console.WriteLine($"2 - Platzkart ({train_composition1.vagons_platzkartType.Count})");
                    Console.Write("\nChoose (0 - back): ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Log.Warning("Invalid symbol in vagon type selection");
                        Console.WriteLine("\nInvalid symbol, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (ch == 0)
                    {
                        stage--;
                        continue;
                    }
                    if (ch < 1 || ch > 2)
                    {
                        Log.Warning("Invalid choice in get_ticket case 2");
                        Console.WriteLine("\nInvalid choice, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if ((ch == 1 && train_composition1.vagons_compartmentType.Count == 0) || (ch == 2 && train_composition1.vagons_platzkartType.Count == 0))
                    {
                        Console.WriteLine("\nNo vagons of this type, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    vagon_type = ch - 1;
                    Log.Information("Vagon type selected");
                    stage++;
                    break;

                case 3:
                    Log.Information("Switched to case 3 in \"Get_ticket\"");
                    err_loop = 0;
                    if (vagon_type == 0)
                    {
                        train_composition1.trainComposition_compartmentType_info();
                        Console.Write("Choose (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in compartment selection");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > train_composition1.vagons_compartmentType.Count)
                        {
                            Log.Warning("Invalid choice in get_ticket case 3");
                            Console.WriteLine("\nInvalid choice, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        vagon_ind = ch;
                        Log.Information("Compartment vagon selected: " + vagon_ind);
                        stage++;
                    }
                    else if (vagon_type == 1)
                    {
                        train_composition1.trainComposition_platzkartType_info();
                        Console.Write("Choose (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in platzkart selection");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > train_composition1.vagons_platzkartType.Count)
                        {
                            Log.Warning("Invalid choice in get_ticket case 3");
                            Console.WriteLine("\nInvalid choice, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        vagon_ind = ch;
                        Log.Information($"Platzkart vagon selected: " + vagon_ind);
                        stage++;
                    }
                    break;

                case 4:
                    Log.Information("Switched to case 4 in \"Get_ticket\"");
                    err_loop = 0;
                    if (vagon_type == 0)
                    {
                        train_composition1.vagons_compartmentType[vagon_ind - 1].info_emptyOrNot(true);
                        Console.Write("\nChoose compartment (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in compartment selection");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 10)
                        {
                            Log.Warning("Invalid index in compartment selection");
                            Console.WriteLine("\nInvalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        compartment_ind = ch;
                        Log.Information("Compartment selected: {compartment_ind}", compartment_ind);
                    }
                    else if (vagon_type == 1)
                    {
                        train_composition1.vagons_platzkartType[vagon_ind - 1].info_emptyOrNot(true);
                        Console.Write("\nChoose platzkart (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in platzkart selection");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 18)
                        {
                            Log.Warning("Invalid choice in get_ticket case 4");
                            Console.WriteLine("\nInvalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        platzkart_ind = ch;
                        Log.Information("Platzkart selected: {platzkart_ind}", platzkart_ind);
                    }
                    stage++;
                    break;

                case 5:
                    Log.Information("Switched to case 5 in \"Get_ticket\"");
                    err_loop = 0;
                    if (vagon_type == 0)
                    {
                        train_composition1.vagons_compartmentType[vagon_ind - 1].info_compartment(compartment_ind);
                        Console.Write("\nChoose seat (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in compartment seat selection");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 4)
                        {
                            Log.Warning("Invalid choice in get_ticket case 5");
                            Console.WriteLine("\nInvalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (train_composition1.vagons_compartmentType[vagon_ind - 1].compartments[compartment_ind - 1][ch - 1] == false)
                        {
                            Log.Warning("Try choose not empty seat");
                            Console.WriteLine("\nSeat is not empty, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        seat_ind = ch;
                        Log.Information($"Seat selected in compartment: {compartment_ind}", compartment_ind);
                    }
                    else if (vagon_type == 1)
                    {
                        train_composition1.vagons_platzkartType[vagon_ind - 1].info_platzkart(platzkart_ind);
                        Console.Write("\nChoose seat (0 - back): #");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in get_ticket case 1");
                            Console.WriteLine("\nInvalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 4 && platzkart_ind <= 9 || ch > 2 && platzkart_ind >= 10)
                        {
                            Log.Warning("Invalid choice in get_ticket case 5");
                            Console.WriteLine("\nInvalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (platzkart_ind <= 9)
                        {
                            if (train_composition1.vagons_platzkartType[vagon_ind - 1].platzkarts_top[platzkart_ind - 1][ch - 1] == false)
                            {
                                Console.WriteLine("\nSeat is not empty, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                        }
                        else
                        {
                            if (train_composition1.vagons_platzkartType[vagon_ind - 1].platzkarts_bottom[platzkart_ind - 9 - 1][ch - 1] == false)
                            {
                                Log.Warning("Try choose not empty seat");
                                Console.WriteLine("\nSeat is not empty, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                        }
                        seat_ind = ch;
                        Log.Information($"Seat selected in platzkart: {platzkart_ind}", platzkart_ind);
                    }
                    stage++;
                    break;

                case 6:
                    Log.Information("Switched to case 6 in \"Get_ticket\"");
                    if (!fake)
                    {
                        try
                        {
                            Console.Write("Card number (0 - back): ");
                            number = long.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in get_ticket case 6");
                            Console.WriteLine("\nInvalid symbol in card number, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if (number == 0)
                        {
                            stage--;
                            continue;
                        }
                        try
                        {
                            Console.Write("CVC: ");
                            cvc = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Warning("Invalid symbol in get_ticket case 6");
                            Console.WriteLine("\nInvalid symbol in CVC, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        foreach (var it in Cards)
                        {
                            if (number == it.number)
                            {
                                if (cvc == it.cvc) payed = true;
                            }
                        }
                        if (payed == false)
                        {
                            Log.Warning("Incorrect number or cvc");
                            Console.WriteLine("\nIncorrect number or cvc, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    Ticket ticket = new Ticket
                        (
                        route_name,
                        vagon_ind,
                        vagon_type,
                        vagon_type == 0,
                        vagon_type == 0 ? compartment_ind : platzkart_ind,
                        seat_ind,
                        fake ? true : false
                        );
                    if (ticket == null)
                    {
                        Log.Error("Ticket is null");
                        Console.WriteLine("\nOops... Some thing wrong, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    int id = ticket.make_ticket(route_name);
                    if (id == 0)
                    {
                        Console.WriteLine("\nOops... Some thing wrong, press any button to continue...");
                        Console.ReadKey();
                        continue;
                    }
                    if (vagon_type == 0)
                    {
                        train_composition1.vagons_compartmentType[vagon_ind - 1].compartments[compartment_ind - 1][seat_ind - 1] = false;
                    }
                    else if (vagon_type == 1 && platzkart_ind <= 9)
                    {
                        train_composition1.vagons_platzkartType[vagon_ind - 1].platzkarts_top[platzkart_ind - 1][seat_ind - 1] = false;
                    }
                    else if (vagon_type == 1 && platzkart_ind >= 10)
                    {
                        train_composition1.vagons_platzkartType[vagon_ind - 1].platzkarts_bottom[platzkart_ind - 9 - 1][seat_ind - 1] = false;
                    }
                    train_composition1.route_name = route_name;
                    train_composition1.trainComposition_serialize();
                    if (!fake)
                    {
                        Console.Clear();
                        Console.WriteLine("Sueccessful, your ID is: " + id);
                        Log.Information("Sueccessful maked ticked with id: {id}", id);
                    }
                    else
                    {
                        Console.WriteLine("Sueccessful, your fake ID is: " + id);
                        Log.Information("Sueccessful maked ticked with fake id: {id}", id);
                    }
                    return;

                default:
                    err_loop++;
                    Log.Warning("Switched to default in \"Get_ticket\" {err_loop} times", err_loop);
                    if (err_loop >= 5)
                    {
                        Console.WriteLine("The program stopped incorrectly :(");
                        Log.Error("Program stopped: many enters to incorrect case in \"Get_ticket\"");
                        return;
                    }
                    break;
            }
        }
    }
}