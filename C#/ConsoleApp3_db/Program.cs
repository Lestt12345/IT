//using Microsoft.Data.SqlClient;

//const string ConnectionString = "Server=localhost; Database=TIPAOLX; Integrated Security=True; TrustServerCertificate=True";
//SqlConnection connection = new SqlConnection(ConnectionString);

//string query = "select * from Users";

//connection.Open();

//using (SqlCommand command = new SqlCommand(query, connection))
//using(SqlDataReader reader = command.ExecuteReader())
//{
//    while (reader.Read())
//    {
//        int id = reader.GetInt32(0);
//        string email = reader.GetString(1);
//        var password = reader.GetSqlBinary(2);
//        var datetime = reader.GetDateTime(3);
//        Console.WriteLine($"ID: {id}, Email: {email}, Password: {password}, DateOfRegistration: {datetime}");
//    }
//}

//connection.Close();



//using Microsoft.Data.SqlClient;

//const string ConnectionString = "Server=localhost; Database=TIPAOLX; Integrated Security=True; TrustServerCertificate=True";
//using (SqlConnection connection = new SqlConnection(ConnectionString))
//{
//    connection.Open();

//    string query = @"
//                        create table Apples
//                        (
//                            ID int primary key identity(1, 1),
//                            Name nvarchar(100),
//                            Color nvarchar(50)
//                        );

//                        INSERT INTO Apples (Name, Color) VALUES ('Golden', 'Yellow');
//                        INSERT INTO Apples (Name, Color) VALUES ('Granny Smith', 'Green');
//                        INSERT INTO Apples (Name, Color) VALUES ('Fuji', 'Red');
//                        INSERT INTO Apples (Name, Color) VALUES ('Pink Lady', 'Pink');
//                    ";
//    using (SqlCommand command = new SqlCommand(query, connection))
//    {
//        command.ExecuteNonQuery();
//        Console.WriteLine("Додано нові записи");
//    }
//    GetApples(connection);
//}

//void GetApples(SqlConnection connection)
//{
//    string query = @"SELECT * FROM Apples";

//    using (SqlCommand command = new SqlCommand(query, connection))
//    using (SqlDataReader reader = command.ExecuteReader())
//    {
//        while (reader.Read())
//        {
//            int id = reader.GetInt32(0);
//            string Name = reader.GetString(1);
//            string Color = reader.GetString(2);

//            Console.WriteLine($"ID: {id}, Name: {Name}, Color: {Color}");
//        }

//    }
//}

//using Microsoft.Data.SqlClient;
//using System.Text;
//const string connectionString = "Server=localhost;Database=lab 01.03.2025;Integrated Security=True; TrustServerCertificate=True;";
//Console.OutputEncoding = Encoding.UTF8;

//string query;
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("1. Отримати усю інформацію з таблиці.");
//    Console.WriteLine("2. Отримати ПІБ студентів.");
//    Console.WriteLine("3. Отримати ПІБ студентів з мінімальною оцінкою, більшою, ніж зазначена.");
//    Console.WriteLine("4. Показати назви усіх предметів із мінімальними середніми оцінками. Назви предметів мають бути унікальними.");
//    Console.WriteLine("5. Показати мінімальну середню оцінку.");
//    Console.WriteLine("6. Показати кількість студентів з мінімальною середньою оцінкою з географії.");
//    Console.WriteLine("7. Показати кількість студентів у кожній групі.");
//    Console.WriteLine("8. Показати середню оцінку групи.");
//    Console.WriteLine("0. Вихід.");
//    Console.Write("\nВведи щось: ");
//    int answer = int.Parse(Console.ReadLine());
//    Console.WriteLine();
//    try
//    {
//        using (SqlConnection connection = new SqlConnection(connectionString))
//        {
//            connection.Open();
//            switch (answer)
//            {
//                case 1:
//                    query = "select * from StudentGrades";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine("Усі студенті:");
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Name: {reader["PIB"]}, " +
//                                $"Group: {reader["GroupName"]}, " +
//                                $"Average Grade: {reader["AvgGradeForYear"]}");
//                        }
//                    }
//                    break;
//                case 2:
//                    query = "select * from StudentGrades";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        Console.WriteLine($"ПІБ усіх студентів:");
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Name: {reader["PIB"]}");
//                        }
//                    }
//                    break;
//                case 3:
//                    Console.Write("оцінка: ");
//                    int grade = int.Parse(Console.ReadLine());
//                    query = "SELECT PIB FROM StudentGrades WHERE AvgGradeForYear > @grade";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        command.Parameters.AddWithValue("@grade", grade);
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            Console.WriteLine($"ПІБ студентів з мінімальною оцінкою, більшою, ніж {grade}:");
//                            while (reader.Read())
//                            {
//                                Console.WriteLine($"Name: {reader["PIB"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 4:
//                    query = "SELECT DISTINCT MinAvgGroupGradeName FROM StudentGrades";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            Console.WriteLine($"Назви усіх предметів із мінімальними середніми оцінками:");
//                            while (reader.Read())
//                            {
//                                Console.WriteLine($"Назва предмету: {reader["MinAvgGroupGradeName"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 5:
//                    query = "SELECT MIN(AvgGradeForYear) AS MinGrade FROM StudentGrades";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            Console.WriteLine($"Мінімальна оцінка");
//                            while (reader.Read())
//                            {
//                                Console.WriteLine($"{reader["MinGrade"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 6:
//                    query = "SELECT MIN(AvgGradeForYear) AS MinGeoGrade FROM StudentGrades WHERE MinAvgGroupGradeName = 'Географія'";
//                    double minGeoGrade = 0;
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                minGeoGrade = reader.GetDouble(reader.GetOrdinal("MinGeoGrade"));
//                            }
//                        }
//                    }
//                    query = "SELECT COUNT(*) AS StudentCount FROM StudentGrades WHERE MinAvgGroupGradeName = 'Географія' AND AvgGradeForYear = @minGeoGrade";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        command.Parameters.AddWithValue("@minGeoGrade", minGeoGrade);
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                Console.WriteLine($"Кількість студентів з мінімальною середньою оцінкою з географії: {reader["StudentCount"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 7:
//                    Console.WriteLine("Кількість студентів у кожній групі:");
//                    query = "SELECT GroupName, COUNT(*) AS StudentCount FROM StudentGrades GROUP BY GroupName";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            while (reader.Read())
//                            {
//                                Console.WriteLine($"Група: {reader["GroupName"]}, Кількість студентів: {reader["StudentCount"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 8:
//                    Console.WriteLine("Середня оцінка групи:");
//                    query = "SELECT GroupName, AVG(AvgGradeForYear) AS AvgGrade FROM StudentGrades GROUP BY GroupName";
//                    using (SqlCommand command = new SqlCommand(query, connection))
//                    {
//                        using (SqlDataReader reader = command.ExecuteReader())
//                        {
//                            while (reader.Read())
//                            {
//                                Console.WriteLine($"Група: {reader["GroupName"]}, Середня оцінка: {reader["AvgGrade"]}");
//                            }
//                        }
//                    }
//                    break;
//                case 0:
//                    Environment.Exit(1);
//                    break;
//                default:
//                    Console.WriteLine("I dont know");
//                    break;
//            }
//        }
//    }
//    catch (Exception e)
//    {
//        Console.WriteLine("Невдалося =(");
//    }
//    Console.ReadKey();
//}

//using Microsoft.Data.SqlClient;
//using System.Text;
//Console.OutputEncoding = Encoding.UTF8;

//const string connectionString = "Server=localhost;Database=veg_and_fruits;Integrated Security=True; TrustServerCertificate=True;";
//SqlConnection connection = new SqlConnection(connectionString);

//const string query1 = @"
//    CREATE TABLE veg_and_fruits (
//        ID INT PRIMARY KEY IDENTITY(1,1),
//        Name_ NVARCHAR(50) NOT NULL,
//        Type_ NVARCHAR(20) NOT NULL,
//        Color NVARCHAR(20) NOT NULL,
//        Kalorijnist DECIMAL(10, 2) NOT NULL
//    );
//";
//const string query2 = @"
//    INSERT INTO veg_and_fruits (Name_, Type_, Color, Kalorijnist)
//    VALUES
//        ('Помідор', 'овоч', 'червоний', 20.50),
//        ('Яблуко', 'фрукт', 'зелене', 52.20),
//        ('Огірок', 'овоч', 'зелене', 15.60),
//        ('Банан', 'фрукт', 'жовтий', 105.00);
//";
////using (connection)
////{
////    connection.Open();
////    using (SqlCommand command = new SqlCommand(query2, connection))
////    {
////        command.ExecuteNonQuery();
////    }
////}

//string query;
//decimal kalorijnist;
//while (true)
//{
//    Console.Clear();
//    Console.WriteLine("1. Підключитися до бази даних");
//    Console.WriteLine("2. Від'єднатися від бази даних");
//    Console.WriteLine("3. Відобразити інформацію з таблиці");
//    Console.WriteLine("4. Відобразити всі назви овочів і фруктів");
//    Console.WriteLine("5. Відобразити всі кольори");
//    Console.WriteLine("6. Показати максимальну калорійність");
//    Console.WriteLine("7. Показати мінімальну калорійність");
//    Console.WriteLine("8. Показати середню калорійність");
//    Console.WriteLine("9. Показати кількість овочів");
//    Console.WriteLine("10. Показати кількість фруктів");
//    Console.WriteLine("11. Показати кількість овочів і фруктів заданого кольору");
//    Console.WriteLine("12. Показати кількість овочів і фруктів кожного кольору");
//    Console.WriteLine("13. Показати овочі та фрукти з калорійністю нижче вказаної");
//    Console.WriteLine("14. Показати овочі та фрукти з калорійністю вище вказаної");
//    Console.WriteLine("15. Показати овочі та фрукти з калорійністю у вказаному діапазоні");
//    Console.WriteLine("16. Показати усі овочі та фрукти жовтого або червоного кольору");
//    Console.WriteLine("0. Вихід");

//    Console.Write("\nВиберіть пункт меню: ");
//    int ch = int.Parse(Console.ReadLine());
//    Console.Clear();

//    switch (ch)
//    {
//        case 1:
//            try
//            {
//                connection.Open();
//                Console.WriteLine("Підключення до бази даних успішне!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 2:
//            try
//            {
//                connection.Close();
//                Console.WriteLine("Від'єднання від бази даних успішне!");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка від'єднання від бази даних: " + ex.Message);
//            }
//            break;
//        case 3:
//            try
//            {
//                query = "SELECT * FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine(reader["Name_"] + " - " + reader["Type_"] + " - " + reader["Color"] + " - " + reader["Kalorijnist"]);
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка відображення даних: " + ex.Message);
//            }
//            break;
//        case 4:
//            try
//            {
//                query = "SELECT Name_ FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine(reader["Name_"]);
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка відображення даних: " + ex.Message);
//            }
//            break;
//        case 5:
//            try
//            {
//                query = "SELECT Color FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine(reader["Color"]);
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка відображення даних: " + ex.Message);
//            }
//            break;
//        case 6:
//            try
//            {
//                Console.WriteLine("Максимальна калорійність:");
//                query = "SELECT MAX(Kalorijnist) AS MaxKalorijnist FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Максимальна калорійність: {reader["MaxKalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 7:
//            try
//            {
//                Console.WriteLine("Мінімальна калорійність:");
//                query = "SELECT MIN(Kalorijnist) AS MinKalorijnist FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Мінімальна калорійність: {reader["MinKalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 8:
//            try
//            {
//                Console.WriteLine("Середня калорійність:");
//                query = "SELECT AVG(Kalorijnist) AS AvgKalorijnist FROM veg_and_fruits";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Середня калорійність: {reader["AvgKalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 9:
//            try
//            {
//                Console.WriteLine("Кількість овочів:");
//                query = "SELECT COUNT(*) AS CountOvoci FROM veg_and_fruits WHERE Type_ = 'овоч'";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Кількість овочів: {reader["CountOvoci"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 10:
//            try
//            {
//                Console.WriteLine("Кількість фруктів:");
//                query = "SELECT COUNT(*) AS CountFrukty FROM veg_and_fruits WHERE Type_ = 'фрукт'";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Кількість фруктів: {reader["CountFrukty"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 11:
//            try
//            {
//                Console.WriteLine("Кількість овочів і фруктів заданого кольору:");
//                Console.Write("Введіть колір: ");
//                string color = Console.ReadLine();
//                query = "SELECT COUNT(*) AS Count FROM veg_and_fruits WHERE Color = @color";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddWithValue("@color", color);
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Кількість овочів і фруктів заданого кольору: {reader["Count"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 12:
//            try
//            {
//                Console.WriteLine("Кількість овочів і фруктів кожного кольору:");
//                query = "SELECT Color, COUNT(*) AS Count FROM veg_and_fruits GROUP BY Color";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Колір: {reader["Color"]}, Кількість: {reader["Count"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 13:
//            try
//            {
//                Console.WriteLine("Овочі та фрукти з калорійністю нижче вказаної:");
//                Console.Write("Введіть калорійність: ");
//                kalorijnist = decimal.Parse(Console.ReadLine());
//                query = "SELECT * FROM veg_and_fruits WHERE Kalorijnist < @kalorijnist";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddWithValue("@kalorijnist", kalorijnist);
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Назва: {reader["Name_"]}, Тип: {reader["Type_"]}, Колір: {reader["Color"]}, Калорійність: {reader["Kalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 14:
//            try
//            {
//                Console.WriteLine("Показати овочі та фрукти з калорійністю вище вказаної:");
//                Console.Write("Введіть калорійність: ");
//                kalorijnist = decimal.Parse(Console.ReadLine());
//                query = "SELECT * FROM veg_and_fruits WHERE Kalorijnist > @kalorijnist";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddWithValue("@kalorijnist", kalorijnist);
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Назва: {reader["Name_"]}, Тип: {reader["Type_"]}, Колір: {reader["Color"]}, Калорійність: {reader["Kalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 15:
//            try
//            {
//                Console.WriteLine("Показати овочі та фрукти з калорійністю у вказаному діапазоні:");
//                Console.Write("Введіть мінімальну калорійність: ");
//                decimal minKalorijnist = decimal.Parse(Console.ReadLine());
//                Console.Write("Введіть максимальну калорійність: ");
//                decimal maxKalorijnist = decimal.Parse(Console.ReadLine());
//                query = "SELECT * FROM veg_and_fruits WHERE Kalorijnist BETWEEN @minKalorijnist AND @maxKalorijnist";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    command.Parameters.AddWithValue("@minKalorijnist", minKalorijnist);
//                    command.Parameters.AddWithValue("@maxKalorijnist", maxKalorijnist);
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Назва: {reader["Name_"]}, Тип: {reader["Type_"]}, Колір: {reader["Color"]}, Калорійність: {reader["Kalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 16:
//            try
//            {
//                Console.WriteLine("Показати усі овочі та фрукти жовтого або червоного кольору:");
//                query = "SELECT * FROM veg_and_fruits WHERE Color IN ('жовтий', 'червоний')";
//                using (SqlCommand command = new SqlCommand(query, connection))
//                {
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Console.WriteLine($"Назва: {reader["Name_"]}, Тип: {reader["Type_"]}, Колір: {reader["Color"]}, Калорійність: {reader["Kalorijnist"]}");
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Помилка підключення до бази даних: " + ex.Message);
//            }
//            break;
//        case 0:
//            Environment.Exit(1);
//            break;
//        default:
//            Console.WriteLine("error");
//            break;
//    }
//    Console.ReadKey();
//}

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

class User
{
    [Key]
    public int Id { get; set; }
    public Profile Profile { get; set; }
    public string Nickname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}

class Profile
{
    [Key]
    [ForeignKey("User")]
    public int Id { get; set; }
    public User User { get; set; }
    public string VisibleName { get; set; }
    public string Avatar { get; set; }
    public string Bio { get; set; }

    public virtual ICollection<Post> Posts { get; set; } = new List<Post>();
    public virtual ICollection<Group> Groups { get; set; } = new List<Group>();
}

class Post
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Image { get; set; }
    public Profile Profile { get; set; }

    [ForeignKey("Profile")]
    public int ProfileId { get; set; }

}

class Group
{
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }

    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}

class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Profile> Profiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=Fluent; Trusted_Connection=True; TrustServerCertificate=True");
    }
}

class Program
{
    public static void Main()
    {
        using (var context = new AppDbContext())
        {



        }
    }
}