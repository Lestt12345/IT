/* REQUIRED
 Install-Package BCrypt.Net-Next
*/

using System.Data;

class Program
{
    static async Task Main()
    {
        // Строка подключения к вашей базе данных (SQL Server)
        string connection_string = "Server=localhost;Database=EmployeeDB;Trusted_Connection=True;";

        var ems = new EmployeeManagementSystem(connection_string);

        // Регистрация нового пользователя с хешированием пароля
        string username = "testuser";
        string plain_password = "MyStrongPassword123!";
        string password_hash = BCrypt.Net.BCrypt.HashPassword(plain_password);

        try
        {
            int user_id = await ems.AddUserAsync(
                username,
                password_hash,
                is_admin: false,
                full_name: "Ivan Ivanov",
                date_of_birth: new DateTime(1990, 5, 10),
                contact_info: "ivan.ivanov@example.com"
            );

            Console.WriteLine($"User created with ID: {user_id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error creating user: " + ex.Message);
        }

        // Аутентификация пользователя
        var (is_admin, user_id_auth) = await ems.AuthenticateUserAsync(username, plain_password);

        if (user_id_auth != -1)
        {
            Console.WriteLine($"User authenticated. Is admin: {is_admin}, User ID: {user_id_auth}");
        }
        else
        {
            Console.WriteLine("Authentication failed.");
        }

        bool _is_admin = true; // проверка в реальной программе должна быть из авторизации

        if (_is_admin)
        {
            // 1. Получить список всех сотрудников
            DataTable employees = await ems.GetEmployeesAsync();
            Console.WriteLine("List of employees:");
            foreach (DataRow row in employees.Rows)
            {
                Console.WriteLine($"ID: {row["EmployeeId"]}, Name: {row["FullName"]}, DOB: {row["DateOfBirth"]}, Contact: {row["ContactInfo"]}");
            }

            // 2. Обновить сотрудника с EmployeeId = 1 (пример)
            await ems.UpdateEmployeeAsync(1, "Ivan Updated", new DateTime(1990, 1, 1), "new.email@example.com");
            Console.WriteLine("Employee updated.");

            // 3. Удалить сотрудника с EmployeeId = 2 (пример)
            await ems.DeleteEmployeeAsync(2);
            Console.WriteLine("Employee deleted.");
        }
        else
        {
            Console.WriteLine("Access denied. You are not an administrator.");
        }
    }
}
