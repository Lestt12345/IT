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