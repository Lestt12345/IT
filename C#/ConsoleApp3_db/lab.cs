using Microsoft.Data.SqlClient;

const string ConnectionString = "Server=localhost; Database=asd; Integrated Security=True; TrustServerCertificate=True";
using (SqlConnection connection = new SqlConnection(ConnectionString))
{
    connection.Open();

    string query1 = @"
                        create table Apples
                        (
                            ID int primary key identity(1, 1),
                            DishName NVARCHAR(50),
                            Cook NVARCHAR(50),
                            Client NVARCHAR(50)
                        );
                    ";
    string query2 = @"
                        INSERT INTO Dishes (DishName, Cook, Client) VALUES ('Pasta', 'John', 'Alice');
                        INSERT INTO Dishes (DishName, Cook, Client) VALUES ('Pizza', 'Emma', 'Bob');
                        INSERT INTO Dishes (DishName, Cook, Client) VALUES ('Salad', 'Mike', 'Chris');
                    ";

    using (SqlCommand command = new SqlCommand(query1, connection))
    {
        command.ExecuteNonQuery();
    }

    GetDishes(connection);
}

void GetDishes(SqlConnection connection)
{
    string query = @"SELECT * FROM Dishes";
    using (SqlCommand command = new SqlCommand(query, connection))
    using (SqlDataReader reader = command.ExecuteReader())
    {
        while (reader.Read())
        {
            Console.WriteLine
                ($"ID: {reader.GetInt32(0)}, DishName: {reader.GetString(1)}, Cook: {reader.GetString(2)}, Client: {reader.GetString(3)}");
        }
    }
}