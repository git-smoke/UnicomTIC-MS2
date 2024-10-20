using BikeRentalManagementSystem.Models;
using System.Data.SqlClient;

namespace BikeRentalManagementSystem.Repository
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }


        public User GetUserByUserName(string userName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "SELECT * FROM Users WHERE UserName = @username";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", userName);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = (int)reader["Id"],
                                UserName = reader["UserName"].ToString(),
                                Email = reader["Email"].ToString(),
                                PasswordHash = reader["Password_Hash"].ToString(),
                                UserType = reader["UserType"].ToString(),
                                CreatedDate = (DateTime)reader["Created_Date"],
                                LastLogin = (DateTime)reader["Last_Login"]
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void AddUser(User user)
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var query = "INSERT INTO Users (UserName,Email,Password_Hash,User_Type,Created_Date) VALUES (@username,@email,@password,@usertype,@createdDate)";
                using(var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username",user.UserName);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue(@"password", user.PasswordHash);
                    command.Parameters.AddWithValue(@"usertype", user.UserType);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
