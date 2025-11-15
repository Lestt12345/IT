using db_project2.Models;

class Program
{
    static void Main(string[] args)
    {
        using (TipaolxContext context = new TipaolxContext())
        {
            var users = context.Users.ToList();
            foreach (var user in users)
            {
                Console.WriteLine(user.Email);
            }
        }
    }
}