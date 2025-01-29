using System.IO;
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
*/
/* plackart type
   ____-_________-_________-_________-_________-_________-_________-_________-_________-_________-_________-____
  | [~]+[~] | [~]+[~] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  | [~] [~] | [~] [~] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] | [2] [3] |
-<| ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ |>-
  | ~~~~~~~~~~~~~~~~~~~ [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] | [0]+[1] |
  |________________________-_________-_________-_________-_________-_________-_________-_________-_________-____|
*/

/* empty or not
true = empty
false = not empty
*/
/* vagon type
0 - compartment type
1 - platzkart type
 */

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
    public List<Vagon_compartmentType> vagons_compartmentType { get; set; } = new List<Vagon_compartmentType>();
    [JsonInclude]
    public List<Vagon_platzkartType> vagons_platzkartType { get; set; } = new List<Vagon_platzkartType>();

    public Train_composition()
    {
        route_name = "none";
        vagons_compartmentType.Add(new Vagon_compartmentType(1));
        vagons_compartmentType.Add(new Vagon_compartmentType(1));
        vagons_compartmentType.Add(new Vagon_compartmentType(1));
        vagons_platzkartType.Add(new Vagon_platzkartType(1));
        vagons_platzkartType.Add(new Vagon_platzkartType(1));
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
    static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("Log file.log")
            .CreateLogger();
        Log.Information("_________________LOGGING WORK SUCCESSFULLY_________________");

        Train_composition tc2 = new Train_composition("asd.json");
        //tc2.trainComposition_info();
    }
}