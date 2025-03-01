using Microsoft.Data.SqlClient;
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
    Console.WriteLine("7. Показати кількість студентів у кожній групі.");
    Console.WriteLine("8. Показати середню оцінку групи.");
    Console.WriteLine("0. Вихід.");
    Console.Write("\nВведи щось: ");
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
                case 7:
                    Console.WriteLine("Кількість студентів у кожній групі:");
                    query = "SELECT GroupName, COUNT(*) AS StudentCount FROM StudentGrades GROUP BY GroupName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Група: {reader["GroupName"]}, Кількість студентів: {reader["StudentCount"]}");
                            }
                        }
                    }
                    break;
                case 8:
                    Console.WriteLine("Середня оцінка групи:");
                    query = "SELECT GroupName, AVG(AvgGradeForYear) AS AvgGrade FROM StudentGrades GROUP BY GroupName";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"Група: {reader["GroupName"]}, Середня оцінка: {reader["AvgGrade"]}");
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
    catch (Exception)
    {
        Console.WriteLine("Невдалося =(");
    }
    Console.ReadKey();
}