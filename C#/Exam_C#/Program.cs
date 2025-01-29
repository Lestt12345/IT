using System.Text.Json;
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

class Vagon_compartmentType
{
    private bool[][] compartments = new bool[10][];

    public Vagon_compartmentType()
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
}

class Vagon_platzkartType
{
    private bool[][] platzkarts_top = new bool[9][];
    private bool[][] platzkarts_bottom = new bool[9][];

    public Vagon_platzkartType()
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
                platzkarts_bottom[i][j] = true;
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
}

class Train_composition
{
    public string route_name;
    public List<Vagon_compartmentType> vagons_compartmentType { get; set; }
    public List<Vagon_platzkartType> vagons_platzkartType { get; set; }

    public Train_composition(string json)
    {
        try
        {
            var trainComposition_data = JsonSerializer.Deserialize<Train_composition>(json);
            route_name = trainComposition_data.route_name;
            vagons_compartmentType = trainComposition_data.vagons_compartmentType;
            vagons_platzkartType = trainComposition_data.vagons_platzkartType;
        }
        catch (Exception ex)
        {
            Log.Error("operation 'Deserialize' failed");
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
        Log.Information("Logging work successfully");
        Vagon_compartmentType v1 = new Vagon_compartmentType();
        v1.info_emptyOrNot();
        Console.WriteLine();
        Vagon_platzkartType v2 = new Vagon_platzkartType();
        v2.info_emptyOrNot();
        Train_composition tc1 = new Train_composition("asd.json");
    }
}