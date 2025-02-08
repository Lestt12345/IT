using System.Text.Json;
using System.Text.Json.Serialization;
using Serilog;

/* cupe type

  capacity = 40 seats

   ____-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____#10__-____
  | [~]+[~] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- |
-<| [~] [~] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] |>-
  | ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~ | ~~~~~~~ | ~~~~~~~ |
  |____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____|

  cupe example:
               [1]+[2]
               [3] [4]

*/
/* plackart type

  capacity = 54 seats

   ____-_________-____#01__-____#02__-____#03__-____#04__-____#05__-____#06__-____#07__-____#08__-____#09__-____
  | [~]+[~] | [~]+[~] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  | [~] [~] | [~] [~] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] |
-<| ~~~~~~~~~~~~~~~~~~#10~~~~~~~#11~~~~~~~#12~~~~~~~#13~~~~~~~#14~~~~~~~#15~~~~~~~#16~~~~~~~#17~~~~~~~#18~~~~~~ |>-
  | ~~~~~~~~~~~~~~~~~~~ [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|

  plackart top example:
                           [1]+[2]
                           [3] [4]
  plackart bottom example:
                           [1]+[2]
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
        public long number;
        public int cvc;

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

            Console.Write("  | [~]+[~] |");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" [");
                if (compartments[i][0] == true) Console.Write("O");
                else Console.Write("X");
                Console.Write("]+[");
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
            if (compartments[compartment][0] == true)
            {
                Console.Write("1");
            }
            else
            {
                Console.Write("X");
            }
            Console.Write("]+[");
            if (compartments[compartment][1] == true)
            {
                Console.Write("2");
            }
            else
            {
                Console.Write("X");
            }
            Console.WriteLine("]");
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

                Console.Write("  | [~]+[~] | [~]+[~] |");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(" [");
                    if (platzkarts_top[i][0] == true) Console.Write("O");
                    else Console.Write("X");
                    Console.Write("]+[");
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
                    Console.Write("]+[");
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
                    Console.Write("]+[");
                    if (platzkarts_bottom[i][1] == true) Console.Write("O");
                    else Console.Write("X");
                    Console.Write("] |");
                }
                Console.WriteLine();

                Console.WriteLine("  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|");
            }

            public void info_indOrX()
            {
                int ind = 0;

                Console.WriteLine("Platzkart type");

                Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");

                Console.Write("  | [~]+[~] | [~]+[~] |");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(" [");
                    if (platzkarts_top[i][0] == true) Console.Write(ind);
                    else Console.Write("X");
                    ind++;
                    Console.Write("]+[");
                    if (platzkarts_top[i][1] == true) Console.Write(ind);
                    else Console.Write("X");
                    ind++;
                    Console.Write("] |");
                }
                Console.WriteLine();

                Console.Write("  | [~] [~] | [~] [~] |");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(" [");
                    if (platzkarts_top[i][2] == true) Console.Write("O");
                    else Console.Write("X");
                    ind++;
                    Console.Write("]+[");
                    if (platzkarts_top[i][3] == true) Console.Write("O");
                    else Console.Write("X");
                    ind++;
                    Console.Write("] |");
                }
                Console.WriteLine("");

                Console.WriteLine("-<| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ |>-");

                Console.Write("  | ~~~~~~~~~~~~~~~~~~~");
                for (int i = 0; i < 9; i++)
                {
                    Console.Write(" [");
                    if (platzkarts_bottom[i][0] == true) Console.Write("O");
                    else Console.Write("X");
                    ind++;
                    Console.Write("]+[");
                    if (platzkarts_bottom[i][1] == true) Console.Write("O");
                    else Console.Write("X");
                    ind++;
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
                    if (platzkarts_top[platzkart][0] == true)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                    Console.Write("]+[");
                    if (platzkarts_top[platzkart][1] == true)
                    {
                        Console.Write("2");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                    Console.WriteLine("]");

                    Console.Write("[");
                    if (platzkarts_top[platzkart][2] == true)
                    {
                        Console.Write("3");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                    Console.Write("] [");
                    if (platzkarts_top[platzkart][3] == true)
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
                    if (platzkarts_bottom[platzkart][0] == true)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                    Console.Write("]+[");
                    if (platzkarts_bottom[platzkart][1] == true)
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
                    if (String.IsNullOrWhiteSpace(route_name) || vagons_compartmentType == null || vagons_platzkartType == null) throw new Exception();
                    Log.Information("operation 'Deserialize train' success");
                }
                catch (Exception)
                {
                    Log.Error("operation 'Deserialize train' failed");
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
                    Log.Information($"Train composition successfully serialized to '{path}'");
                }
                catch (Exception)
                {
                    Log.Error("Error in 'trainComposition_serialize' method");
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
                catch (Exception)
                {
                    Log.Error("Error displaying compartment type info");
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
                catch (Exception)
                {
                    Log.Error("Error displaying compartment info");
                }
            }
        }

        class Ticket
        {
            [JsonInclude]
            public string route_name;
            [JsonInclude]
            public int vagon_ind;
            [JsonInclude]
            public int vagon_type;
            [JsonInclude]
            bool is_compartment;
            [JsonInclude]
            int compartmentOrPlatzkart_ind;
            [JsonInclude]
            public int seat_ind;

            public Ticket(string route_name, int vagon_ind, int vagon_type, bool is_compartment, int compartmentOrPlatzkart_ind, int seat_ind)
            {
                this.route_name = route_name;
                this.vagon_ind = vagon_ind;
                this.vagon_type = vagon_type;
                this.is_compartment = is_compartment;
                this.compartmentOrPlatzkart_ind = compartmentOrPlatzkart_ind;
                this.seat_ind = seat_ind;
            }

            public int make_ticket(string route)
            {
                int id = 0;
                string directory = "tickets";
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                List<int> used_ids = new List<int>();
                foreach (string file in Directory.GetFiles(directory))
                {
                    string file_name = Path.GetFileNameWithoutExtension(file);
                    string[] parts = file_name.Split(' ');
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
                string path = $"{directory}\\{route} {id}_.json";
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
                    Log.Information($"Ticket successfully serialized to '{path}'");
                    return id;
                }
                catch (Exception)
                {
                    Log.Error("Error in 'make_ticket' method");
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
                .WriteTo.File("Log file.log")
                .CreateLogger();
            Log.Information("_________________LOGGING WORK SUCCESSFULLY_________________");

            Menu();

            Log.Information("Program ends");
        }

        static void Menu()
        {
            //for ticket
            int stage = 1;
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
            while (!payed)
            {
                Console.Clear();
                switch (stage)
                {
                    case 1:
                        Log.Information("Switched to case 1");
                        err_loop = 0;
                        Console.WriteLine("Select a route:");
                        var routes = Directory.GetFiles("routs", "*.json");
                        for (int i = 0; i < routes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1} - {Path.GetFileNameWithoutExtension(routes[i])}");
                        }
                        Console.WriteLine("0 - Exit");
                        Console.Write("Choose: ");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Error("Invalid symbol in route selection");
                            Console.WriteLine("Invalid symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        if (ch == 0) return;
                        if (ch < 1 || ch > routes.Length)
                        {
                            Console.WriteLine("Invalid choice, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        route_name = Path.GetFileNameWithoutExtension(routes[ch - 1]);
                        train_composition1 = new Train_composition($"routs\\{route_name}.json");
                        if (train_composition1 == null)
                        {
                            Log.Error("Train composition is null");
                            Console.WriteLine("Ops, some thing wrong, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        Log.Information("Route selected: " + route_name);
                        stage++;

                        break;

                    case 2:
                        Log.Information("Switched to case 2");
                        err_loop = 0;
                        Console.WriteLine("Select a vagon type:");
                        Console.WriteLine($"1 - Compartment ({train_composition1.vagons_compartmentType.Count})");
                        Console.WriteLine($"2 - Platzkart ({train_composition1.vagons_platzkartType.Count})");
                        Console.WriteLine("0 - Back");
                        Console.Write("Choose (0 - back): ");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Error("Invalid symbol in vagon type selection");
                            Console.WriteLine("Invalid symbol, press any button to continue...");
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
                            Console.WriteLine("Invalid choice, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        if ((ch == 1 && train_composition1.vagons_compartmentType.Count == 0) || (ch == 2 && train_composition1.vagons_platzkartType.Count == 0))
                        {
                            Console.WriteLine("No vagons of this type, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        vagon_type = ch - 1;
                        Log.Information("Vagon type selected");
                        stage++;

                        break;

                    case 3:
                        Log.Information("Switched to case 3");
                        err_loop = 0;
                        if (vagon_type == 0)
                        {
                            train_composition1.trainComposition_compartmentType_info();
                            Console.Write("\nChoose (0 - back): #");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in compartment selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Console.WriteLine("Invalid choice, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }

                            vagon_ind = ch - 1;
                            Log.Information("Compartment vagon selected: " + vagon_ind);
                            stage++;
                        }
                        else if (vagon_type == 1)
                        {
                            train_composition1.trainComposition_platzkartType_info();
                            Console.Write("\nChoose (0 - back): #");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in platzkart selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Console.WriteLine("Invalid choice, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            vagon_ind = ch - 1;
                            Log.Information($"Platzkart vagon selected: " + vagon_ind);
                            stage++;
                        }
                        break;

                    case 4:
                        Log.Information("Switched to case 4");
                        err_loop = 0;
                        if (vagon_type == 0)
                        {
                            train_composition1.vagons_compartmentType[vagon_ind].info_emptyOrNot(true);
                            Console.Write("\nChoose compartment (0 - back): ");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in compartment selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Log.Error("Invalid index in compartment selection");
                                Console.WriteLine("Invalid index, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            compartment_ind = ch;
                            Log.Information("Compartment selected: {compartment_ind}", compartment_ind);
                        }
                        else if (vagon_type == 1)
                        {
                            train_composition1.vagons_platzkartType[vagon_ind].info_emptyOrNot(true);
                            Console.Write("\nChoose platzkart (0 - back): ");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in platzkart selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Console.WriteLine("Invalid index, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            platzkart_ind = ch;
                            Log.Information("Platzkart selected: {platzkart_ind}", platzkart_ind);
                        }
                        stage++;
                        break;

                    case 5:
                        Log.Information("Switched to case 5");
                        err_loop = 0;
                        if (vagon_type == 0)
                        {
                            train_composition1.vagons_compartmentType[vagon_ind].info_compartment(compartment_ind);
                            Console.Write("\nChoose seat (0 - back): ");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in compartment seat selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Log.Error("Invalid index in compartment seat selection");
                                Console.WriteLine("Invalid index, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            if (train_composition1.vagons_compartmentType[vagon_ind].compartments[compartment_ind - 1][seat_ind - 1] == false)
                            {
                                Console.WriteLine("Seat is not empty, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            seat_ind = ch;
                            Log.Information($"Seat selected in compartment: {compartment_ind}", compartment_ind);
                        }
                        else if (vagon_type == 1)
                        {
                            train_composition1.vagons_platzkartType[vagon_ind].info_indOrX();
                            Console.Write("\nChoose platzkart (0 - back): ");
                            try
                            {
                                ch = int.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Log.Error("Invalid symbol in platzkart selection");
                                Console.WriteLine("Invalid symbol, press any button to continue...");
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
                                Console.WriteLine("Invalid index, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            if (platzkart_ind <= 9)
                            {
                                if (train_composition1.vagons_platzkartType[vagon_ind].platzkarts_top[platzkart_ind - 1][seat_ind - 1] == false)
                                {
                                    Console.WriteLine("Seat is not empty, press any button to continue...");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                            else
                            {
                                if (train_composition1.vagons_platzkartType[vagon_ind].platzkarts_top[platzkart_ind - 9 - 1][seat_ind - 1] == false)
                                {
                                    Console.WriteLine("Seat is not empty, press any button to continue...");
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
                        Log.Information("Switched to case 6");
                        try
                        {

                            Console.Write("Card number: ");
                            number = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Error("Invalid symbol in card number");
                            Console.WriteLine("Invalid symbol in card number, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        try
                        {
                            Console.Write("CVC: ");
                            cvc = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Log.Error("Invalid symbol in CVC");
                            Console.WriteLine("Invalid symbol in CVC, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        foreach (var it in Cards)
                        {
                            if (number == it.number)
                            {
                                if (cvc == it.cvc)
                                {
                                    Ticket ticket = new Ticket(route_name, vagon_ind, vagon_type, vagon_type == 0, vagon_type == 0 ? compartment_ind : platzkart_ind, seat_ind);
                                    if (ticket == null)
                                    {
                                        Log.Error("Ticket is null");
                                        Console.WriteLine("Ops, some thing wrong, press any button to continue...");
                                        Console.ReadKey();
                                        continue;
                                    }
                                    int id = ticket.make_ticket(route_name);
                                    if (id == 0)
                                    {
                                        Console.WriteLine("Ops, some thing wrong, press any button to continue...");
                                        Console.ReadKey();
                                        continue;
                                    }
                                    if (vagon_type == 0)
                                    {
                                        train_composition1.vagons_compartmentType[vagon_ind].compartments[compartment_ind - 1][seat_ind - 1] = false;
                                    }
                                    else if (vagon_type == 1 && platzkart_ind <= 9)
                                    {
                                        train_composition1.vagons_platzkartType[vagon_ind].platzkarts_top[platzkart_ind - 1][seat_ind - 1] = false;
                                    }
                                    else if (vagon_type == 1 && platzkart_ind >= 10)
                                    {
                                        train_composition1.vagons_platzkartType[vagon_ind].platzkarts_bottom[platzkart_ind - 9 - 1][seat_ind - 1] = false;
                                    }
                                    payed = true;
                                    Console.WriteLine("Sueccessful, your ID is: " + id);
                                    Log.Information("Sueccessful maked ticked with id: {id}", id);
                                }
                            }
                        }
                        if (payed == false)
                        {
                            Log.Error("Incorrect number or cvc");
                            Console.WriteLine("Incorrect number or cvc, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        return;

                    default:
                        err_loop++;
                        Log.Warning("Switched to default {err_loop} times", err_loop);
                        if (err_loop >= 5)
                        {
                            Console.WriteLine("The program stopped incorrectly :(");
                            Log.Error("Program stopped: many enters to incorrect case");
                            return;
                        }
                        break;
                }
            }
        }
    }
}