using Microsoft.Data.SqlClient;
using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.Models;
using System;

namespace MotorBikeRentalAPI.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public int AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string addQuery = "INSERT INTO Users (UserName, Password_hash, Email, User_Type, Created_Data, Is_Active) " +
                           "OUTPUT INSERTED.Id " +
                           "VALUES (@Username, @PasswordHash, @Email, @UserType, @CreatedAt, @IsActive)";
                SqlCommand command = new SqlCommand(addQuery, connection);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@Password_hash", user.Password_Hash);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@UserType", user.User_Type);
                command.Parameters.AddWithValue("@CreatedAt", user.Created_Date);
                command.Parameters.AddWithValue("@IsActive", user.Is_Active);
                connection.Open();
                int userId = (int)command.ExecuteScalar();
                return userId;
            }
        }

        public User GetUserByUsername(string username)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string getQuery = "SELECT * FROM Users WHERE UserName = @Username";
                SqlCommand command = new SqlCommand(getQuery, connection);
                command.Parameters.AddWithValue("@Username", username);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        Id = (int)reader["Id"],
                        UserName = (string)reader["UserName"],
                        Password_Hash = (string)reader["Password_hash"],
                        Email = (string)reader["Email"],
                        User_Type = (string)reader["User_Type"],
                        Created_Date = (DateTime)reader["Created_Data"],
                        Last_Login = (DateTime)reader["Last_Login"],
                        Is_Active = (bool)reader["Is_Active"]
                    };
                }
                return null;
            }
        }

        public void UpdateLastLogin(int userId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string updateQuery = "UPDATE Users SET Last_Login = @LastLogin WHERE Id = @UserId";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@LastLogin", DateTime.Now);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
