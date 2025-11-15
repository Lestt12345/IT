
using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeManagementSystem
{
    internal class EmployeeManagementSystem
    {
        private readonly string CONNECTION_STRING;

        public EmployeeManagementSystem(string connection_string)
        {
            CONNECTION_STRING = connection_string;
        }

        // Добавление нового пользователя с айди на информацию про себя (из таблицы employees)
        public async Task<int /*user id*/> AddUserAsync(string username, string password_hash /*bcrypt*/, bool is_admin, string full_name, DateTime date_of_birth, string contact_info, string job_position, byte[] photo)
        {
            const string check_user_query = @"
            SELECT COUNT(1) FROM Users WHERE Username = @Username;
        ";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();

                using (var check_user_command = new SqlCommand(check_user_query, connection))
                {
                    check_user_command.Parameters.AddWithValue("@Username", username);
                    var existing_count = (int)await check_user_command.ExecuteScalarAsync();
                    if (existing_count > 0)
                    {
                        throw new Exception("Username already exists.");
                    }
                }

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        const string insert_employee_query = @"
                        INSERT INTO Employees (FullName, DateOfBirth, ContactInfo, JobPosition, Photo)
                        VALUES (@FullName, @DateOfBirth, @ContactInfo, @JobPosition, @Photo);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                        ";

                        int user_id;
                        int employee_id;
                        using (var insert_employee_command = new SqlCommand(insert_employee_query, connection, transaction))
                        {
                            insert_employee_command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = full_name;
                            insert_employee_command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = date_of_birth;
                            insert_employee_command.Parameters.Add("@ContactInfo", SqlDbType.NVarChar).Value = contact_info;
                            insert_employee_command.Parameters.Add("@JobPosition", SqlDbType.NVarChar).Value = job_position;
                            insert_employee_command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = photo ?? (object)DBNull.Value;

                            var result = await insert_employee_command.ExecuteScalarAsync();
                            employee_id = Convert.ToInt32(result);
                        }

                        const string insert_user_query = @"
                        INSERT INTO Users (Username, PasswordHash, IsAdmin, EmployeeId)
                        VALUES (@Username, @PasswordHash, @IsAdmin, @EmployeeId);
                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                    ";

                        using (var insert_user_command = new SqlCommand(insert_user_query, connection, transaction))
                        {
                            insert_user_command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;
                            insert_user_command.Parameters.Add("@PasswordHash", SqlDbType.NVarChar).Value = password_hash;
                            insert_user_command.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = is_admin;
                            insert_user_command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employee_id;

                            var result = await insert_user_command.ExecuteScalarAsync();
                            user_id = Convert.ToInt32(result);
                        }

                        transaction.Commit();

                        return user_id;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        // Авторизация пользователя с возвратом роли и логированием попытки
        public async Task<(bool /*is_admin*/, int /*user id*/)> AuthenticateUserAsync(string username, string plain_password /*bcrypt*/)
        {
            const string query = @"
        SELECT UserId, PasswordHash, IsAdmin
        FROM Users
        WHERE Username = @Username;
        ";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.NVarChar).Value = username;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            int user_id = reader.GetInt32(0);
                            string stored_hash = reader.GetString(1);
                            bool is_admin = reader.GetBoolean(2);

                            bool is_valid = BCrypt.Net.BCrypt.Verify(plain_password, stored_hash);

                            await LogAuthAttemptAsync(user_id, is_valid);

                            if (is_valid)
                                return (is_admin, user_id);
                        }
                    }
                }
            }

            await LogAuthAttemptAsync(-1, false);
            return (false /* fail */, -1);
        }

        // Логирование попытки авторизации
        public async Task LogAuthAttemptAsync(int user_id, bool success)
        {
            const string query = @"
            INSERT INTO AuthLogs (UserId, LoginTimestamp, Success)
            VALUES (@UserId, @LoginTimestamp, @Success);
        ";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    //command.Parameters.Add("@UserId", SqlDbType.Int).Value = user_id;
                    command.Parameters.Add("@UserId", SqlDbType.Int).Value =
                                        user_id != -1 ? user_id : (object)DBNull.Value;
                    command.Parameters.Add("@LoginTimestamp", SqlDbType.DateTime).Value = DateTime.UtcNow;
                    command.Parameters.Add("@Success", SqlDbType.Bit).Value = success;

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        // Редактирование сотрудника (только администратор)
        public async Task UpdateEmployeeAsync(int employee_id, string NEW_full_name, DateTime NEW_date_of_birth, string NEW_contact_info, string NEW_job_position, byte[] NEW_photo)
        {
            const string query = @"
            UPDATE Employees
            SET FullName = @FullName, DateOfBirth = @DateOfBirth, ContactInfo = @ContactInfo, JobPosition = @JobPosition
            WHERE EmployeeId = @EmployeeId;
        ";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employee_id;
                    command.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = NEW_full_name;
                    command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = NEW_date_of_birth;
                    command.Parameters.Add("@ContactInfo", SqlDbType.NVarChar).Value = NEW_contact_info;
                    command.Parameters.Add("@JobPosition", SqlDbType.NVarChar).Value = NEW_job_position;
                    command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = NEW_photo ?? (object)DBNull.Value;

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        // Удаление сотрудника (только администратор)
        public async Task DeleteEmployeeAsync(int employee_id)
        {
            const string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId;";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employee_id;

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        // Получение данных сотрудников
        public async Task<DataTable> GetEmployeesAsync()
        {
            const string query = "SELECT * FROM Employees;";
            var data_table = new DataTable();

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                using (var reader = await command.ExecuteReaderAsync())
                {
                    data_table.Load(reader);
                }
            }

            return data_table;
        }


        // Получение личных данных сотрудника
        public async Task<(DataRow, byte[] /*photo*/)> GetPersonalDataAsync(int employee_id)
        {
            const string query = "SELECT * FROM Employees WHERE EmployeeId = @EmployeeId;";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employee_id;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (reader.HasRows)
                        {
                            var data_table = new DataTable();
                            data_table.Load(reader);
                            var row = data_table.Rows[0];
                            byte[] photo = row["Photo"] as byte[];
                            return (row, photo);
                        }
                    }
                }
            }

            throw new Exception("Співробітника з таким ID не знайдено.");
        }

        // Получение айди сотрудника по айди користувача
        public async Task<int> GetEmployeeIdByUserIdAsync(int user_id)
        {
            const string query = "SELECT EmployeeId FROM Users WHERE UserId = @UserId;";

            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@UserId", SqlDbType.Int).Value = user_id;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            return reader.GetInt32(0);
                        }
                    }
                }
            }

            throw new Exception("Користувача з таким ID не знайдено.");
        }

    }
}
