//using Microsoft.EntityFrameworkCore;

//public class Team // task 1
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string City { get; set; }
//    public int Wins { get; set; }
//    public int Losses { get; set; }
//    public int Draws { get; set; }
//    public int GoalsScored { get; set; }  // task 4
//    public int GoalsConceded { get; set; } // task 4
//}


//public class AppDbContext : DbContext // task 2
//{
//    public DbSet<Team> Teams { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//    {
//        optionsBuilder.UseSqlServer("Server=.; Database=SpanishFootball; Trusted_Connection=True; TrustServerCertificate=True");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        using (var context = new AppDbContext())
//        {
//            // task 3
//            var team1 = new Team { Name = "Real Madrid", City = "Madrid", Wins = 10, Losses = 2, Draws = 3, GoalsScored = 25, GoalsConceded = 10 };
//            var team2 = new Team { Name = "Barcelona", City = "Barcelona", Wins = 8, Losses = 4, Draws = 3, GoalsScored = 22, GoalsConceded = 12 };
//            context.Teams.Add(team1);
//            context.Teams.Add(team2);
//            context.SaveChanges();

//            var teams = context.Teams.ToList();
//            foreach (var team in teams)
//            {
//                Console.WriteLine($"ID: {team.Id}, Name: {team.Name}, City: {team.City}, Wins: {team.Wins}, Losses: {team.Losses}, Draws: {team.Draws}, GoalsScored: {team.GoalsScored}, GoalsConceded: {team.GoalsConceded}");
//            }
//        }
//    }
//}