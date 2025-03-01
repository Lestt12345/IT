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

using Microsoft.Data.SqlClient;
using Mysqlx.Crud;
using System.Text;
const string connectionString = "Server=localhost;Database=lab 01.03.2025;Integrated Security=True; TrustServerCertificate=True;";
Console.OutputEncoding = Encoding.UTF8;

string query;
while (true)
{
    Console.Clear();
    Console.WriteLine("1. Отримати усю інформацію з таблиці.");
    Console.WriteLine("2. Отримати ПІБ студентів.");
    Console.WriteLine("3. Отримати ПІБ студентів з мінімальною оцінкою, більшою, ніж зазначена.");
    Console.WriteLine("4. Показати назви усіх предметів із мінімальними середніми оцінками. Назви предметів мають бути унікальними.");
    Console.WriteLine("5. Показати мінімальну середню оцінку.");
    Console.WriteLine("6. Показати кількість студентів з мінімальною середньою оцінкою з географії.");
    Console.Write("Введи щось: ");
    int answer = int.Parse(Console.ReadLine());
    Console.WriteLine();
    try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            switch (answer)
            {
                case 1:
                    query = "select * from StudentGrades";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Усі студенті:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Name: {reader["PIB"]}, " +
                                $"Group: {reader["GroupName"]}, " +
                                $"Average Grade: {reader["AvgGradeForYear"]}");
                        }
                    }
                    break;
                case 2:
                    query = "select * from StudentGrades";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine($"ПІБ усіх студентів:");
                        while (reader.Read())
                        {
                            Console.WriteLine($"Name: {reader["PIB"]}");
                        }
                    }
                    break;
                case 3:
                    Console.Write("оцінка: ");
                    int grade = int.Parse(Console.ReadLine());
                    query = "SELECT PIB FROM StudentGrades WHERE AvgGradeForYear > @grade";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@grade", grade);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine($"ПІБ студентів з мінімальною оцінкою, більшою, ніж {grade}:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Name: {reader["PIB"]}");
                            }
                        }
                    }
                    break;
                case 4:
                    query = "SELECT DISTINCT MinAvgGroupGradeName FROM StudentGrades";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine($"Назви усіх предметів із мінімальними середніми оцінками:");
                            while (reader.Read())
                            {
                                Console.WriteLine($"Назва предмету: {reader["MinAvgGroupGradeName"]}");
                            }
                        }
                    }
                    break;
                case 5:
                    query = "SELECT MIN(AvgGradeForYear) AS MinGrade FROM StudentGrades";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            Console.WriteLine($"Мінімальна оцінка");
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader["MinGrade"]}");
                            }
                        }
                    }
                    break;
                case 6:
                    query = "SELECT MIN(AvgGradeForYear) AS MinGeoGrade FROM StudentGrades WHERE MinAvgGroupGradeName = 'Географія'";
                    double minGeoGrade = 0;
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                minGeoGrade = reader.GetDouble(reader.GetOrdinal("MinGeoGrade"));
                            }
                        }
                    }
                    query = "SELECT COUNT(*) AS StudentCount FROM StudentGrades WHERE MinAvgGroupGradeName = 'Географія' AND AvgGradeForYear = @minGeoGrade";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@minGeoGrade", minGeoGrade);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine($"Кількість студентів з мінімальною середньою оцінкою з географії: {reader["StudentCount"]}");
                            }
                        }
                    }
                    break;
                case 0:
                    Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("I dont know");
                    break;
            }
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Невдалося =(");
    }
    Console.ReadKey();
}