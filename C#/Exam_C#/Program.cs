﻿using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Serilog;

/* cupe type
   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____
  | [~]+[~] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- | ------- |
-<| [~] [~] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] |>-
  | ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~ | ~~~~~~~ | ~~~~~~~ |
  |____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____|
  capacity = 40 seats
*/
/* plackart type
   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____
  | [~]+[~] | [~]+[~] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  | [~] [~] | [~] [~] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] |
-<| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ |>-
  | ~~~~~~~~~~~~~~~~~~~ [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|
  capacity = 54 seats
*/

/* empty or not
true = empty
false = not empty
*/
/* vagon type
0 - compartment type
1 - platzkart type
 */

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

    public void info_emptyOrNot()
    {
        Console.WriteLine("Compartment type");

        Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");

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

    public void info_indOrX()
    {
        int ind = 0;
        Console.WriteLine("Compartment type");

        Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");

        Console.Write("  | [~]+[~] |");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(" [");
            if (compartments[i][0] == true) Console.Write("O");
            else Console.Write("X");
            ind++;
            Console.Write("]+[");
            if (compartments[i][1] == true) Console.Write("O");
            else Console.Write("X");
            ind++;
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
            ind++;
            Console.Write("] [");
            if (compartments[i][3] == true) Console.Write("O");
            else Console.Write("X");
            ind++;
            Console.Write("] |");
        }
        Console.WriteLine(">-");

        Console.WriteLine("  | ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~   ~~~~~~~ | ~~~~~~~ | ~~~~~~~ |");

        Console.WriteLine("  |____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____|");
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

    public void info_emptyOrNot()
    {
        Console.WriteLine("Platzkart type");

        Console.WriteLine("   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____");

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

        Console.WriteLine("-<| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ |>-");

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
            if (String.IsNullOrWhiteSpace(route_name)) throw new Exception();
            Log.Information("operation 'Deserialize train' success");
        }
        catch (Exception ex)
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
        catch(Exception ex)
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
                it.info_emptyOrNot();
                Console.WriteLine();
            }
            Log.Information("Train composition compartment type displayed");
        }
        catch (Exception ex)
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
                it.info_emptyOrNot();
                Console.WriteLine();
            }
            Log.Information("Train composition compartment type displayed");
        }
        catch (Exception ex)
        {
            Log.Error("Error displaying compartment info");
        }
    }
}

class Ticket
{
    private string route_name;
    private int vagon_type;
    private int vagon_ind;
    private int seat_ind;
    private bool not_used;

    public Ticket(string route_name, int vagon_type, int vagon_ind, int seat_ind, bool not_used)
    {
        this.route_name = route_name;
        this.vagon_type = vagon_type;
        this.vagon_ind = vagon_ind;
        this.seat_ind = seat_ind;
        this.not_used = not_used;
    }

    public void make_ticket()
    {
        try
        {
            string path = $"tickets\\{route_name}.json";
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new System.Text.UTF8Encoding(true).GetBytes("");
                    fs.Write(info, 0, info.Length);
                }
            }
            Ticket ticket_data = new Ticket(route_name, vagon_type, vagon_ind, seat_ind, not_used);
            File.WriteAllText(path, JsonSerializer.Serialize(ticket_data));
            Ticket _ticket_data = JsonSerializer.Deserialize<Ticket>(File.ReadAllText(path));
            if (JsonSerializer.Serialize(ticket_data) != JsonSerializer.Serialize(_ticket_data)) throw new Exception();
            Log.Information($"Ticket successfully serialized to '{path}'");
        }
        catch (Exception ex)
        {
            Log.Error("Error in 'make_ticket' method");
        }
    }
}

class Program
{
    static Bank_card[] Cards =
    {
        new Bank_card(1111222233334444, 111),
        new Bank_card(5555666677778888, 222),
        new Bank_card(9999000099990000, 333)
    };

    static void Menu()
    {
        //for ticket
        int stage = 1;
        string route_name = "";
        int vagon_type = -1;
        int vagon_ind = -1;
        int seat_ind = -1;
        bool payed = false;
        //for pay
        long number = -1;
        int cvc = -1;


        int ch;
        while (payed == false)
        {
            Console.Clear();
            switch (stage)
            {
                case 1:
                    Console.WriteLine("Select a route:");
                    var routes = Directory.GetFiles("routs", "*.txt");
                    for (int i = 0; i < routes.Length; i++)
                    {
                        Console.WriteLine($"{i + 1} - {Path.GetFileNameWithoutExtension(routes[i])}");
                    }
                    Console.WriteLine("0 - Exit");
                    Console.Write("Choose: ");
                    try
                    {
                        ch = int.Parse(Console.ReadLine()); // vpadlu convert (dolgo)
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid (you) symbol, press any button to continue...");
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
                    Train_composition train_composition1 = new Train_composition("tickets\\" + route_name + ".txt");
                    stage++;

                    break;

                case 2:
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
                        Console.WriteLine("Invalid (you) symbol, press any button to continue...");
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
                    stage++;

                    break;

                case 3:
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
                            Console.WriteLine("Invalid (you) symbol, press any button to continue...");
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
                            Console.WriteLine("Invalid (you) symbol, press any button to continue...");
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
                    }

                    break;

                case 4:
                    if (vagon_type == 0)
                    {
                        train_composition1.vagons_compartmentType[vagon_ind].info_indOrX();
                        Console.Write("\nChoose (0 - back): ");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid (you) symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 40)
                        {
                            Console.WriteLine("Invalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        seat_ind = ch - 1;
                        int compartment = 1;
                        while (ch > 4)
                        {
                            if (ch < 4)
                            {
                                ch -= 4;
                                compartment++;
                            }
                        }
                        if (train_composition1.vagons_compartmentType[vagon_ind].compartments[compartment - 1][ch - 1] == false)
                        {
                            Console.WriteLine("Seat is not empty, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (vagon_type == 1)
                    {
                        train_composition1.vagons_platzkartType[vagon_ind].info_indOrX();
                        Console.Write("\nChoose (0 - back): ");
                        try
                        {
                            ch = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid (you) symbol, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }

                        if (ch == 0)
                        {
                            stage--;
                            continue;
                        }
                        if (ch < 1 || ch > 54)
                        {
                            Console.WriteLine("Invalid index, press any button to continue...");
                            Console.ReadKey();
                            continue;
                        }
                        seat_ind = ch - 1;
                        int platzkart = 1;
                        if (ch > 36)
                        {
                            ch -= 36;
                            while (ch > 2)
                            {
                                ch -= 2;
                                platzkart++;
                            }
                            if (train_composition1.vagons_platzkartType[vagon_ind].platzkarts_bottom[platzkart - 1][ch - 1] == false)
                            {
                                Console.WriteLine("Seat is not empty, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.Write("Card number: ");
                                number = int.Parse(Console.ReadLine());
                                foreach (var it in Cards)
                                {
                                    if (number == it.number)
                                    {
                                        if (cvc == it.cvc)
                                        {
                                            Ticket ticket = new Ticket(route_name, vagon_type, vagon_ind, seat_ind, true);
                                            train_composition1.vagons_platzkartType[vagon_ind].platzkarts_bottom[platzkart - 1][ch - 1] = false;
                                            payed = true;
                                        }
                                    }
                                }
                                if (payed == false)
                                {
                                    Console.WriteLine("Incorrect number or cvc, press any button to continue...");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                        }
                        else if (ch <= 36)
                        {
                            while (ch > 4)
                            {
                                ch -= 4;
                                platzkart++;
                            }
                            if (train_composition1.vagons_platzkartType[vagon_ind].platzkarts_top[platzkart - 1][ch - 1] == false)
                            {
                                Console.WriteLine("Seat is not empty, press any button to continue...");
                                Console.ReadKey();
                                continue;
                            }
                            else
                            {
                                Console.Write("Card number: ");
                                number = int.Parse(Console.ReadLine());
                                foreach (var it in Cards)
                                {
                                    if (number == it.number)
                                    {
                                        if (cvc == it.cvc)
                                        {
                                            Ticket ticket = new Ticket(route_name, vagon_type, vagon_ind, seat_ind, true);
                                            train_composition1.vagons_platzkartType[vagon_ind].platzkarts_top[platzkart - 1][ch - 1] = false;
                                            payed = true;
                                        }
                                    }
                                }
                                if (payed == false)
                                {
                                    Console.WriteLine("Incorrect number or cvc, press any button to continue...");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                        }
                    }
                    break;
            }
        }
    }

    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("Log file.log")
            .CreateLogger();
        Log.Information("_________________LOGGING WORK SUCCESSFULLY_________________");

        Menu();
    }
}