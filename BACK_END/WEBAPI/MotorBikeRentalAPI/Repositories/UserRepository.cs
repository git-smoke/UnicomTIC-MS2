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

        public async Task<User> GetUserByUsernameAndPasswordAsync(string username, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var Userquery = "SELECT * FROM Users WHERE UserName = @UserName AND Password_Hash = @PasswordHash";
                var command = new SqlCommand(Userquery, connection);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@PasswordHash", password); // Assume password is already hashed

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        return new User
                        {
                            Id = (int)reader["Id"],
                            UserName = reader["UserName"].ToString(),
                            User_Type = reader["User_Type"].ToString(),
                            Last_Login = (DateTime)reader["Last_Login"],
                            Is_Active = (bool)reader["Is_Active"]
                        };
                    }
                }
            }
            return null;
        }

        public async Task<bool> RecordLoginAsync(int userId, DateTime loginTime)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "UPDATE USERS SET Last_Login = @LoginTime WHERE Id = @UserId";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@LoginTime", loginTime);
                command.Parameters.AddWithValue("@UserId", userId);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync() > 0;
            }
        }

        public async Task<bool> RecordLogoutAsync(int userId, DateTime logoutTime)
        {
            // Implement logout time update if needed, similar to RecordLoginAsync
            return true; // Just a placeholder
        }

        public async Task<int> CreateUserAsync(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO USERS (UserName, Password_Hash, Email, User_Type, Created_Date, Is_Active) " +
                            "VALUES (@UserName, @PasswordHash, @Email, @UserType, @CreatedDate, @IsActive); " +
                            "SELECT SCOPE_IDENTITY()";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", user.UserName);
                command.Parameters.AddWithValue("@PasswordHash", user.Password_Hash);
                command.Parameters.AddWithValue("@Email", user.Email);
                command.Parameters.AddWithValue("@UserType", user.User_Type);
                command.Parameters.AddWithValue("@CreatedDate", user.Created_Date);
                command.Parameters.AddWithValue("@IsActive", user.Is_Active);

                await connection.OpenAsync();
                return Convert.ToInt32(await command.ExecuteScalarAsync());
            }
        }

        public async Task<int> CreateCustomerAsync(Customer customer)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO CUSTOMERS (Nic_Number, Users_Id, First_Name, Last_Name, Phone_Number, Address, City, Country, Postal_Code, Date_Of_Birth, Driving_License_Number, Driving_License_Expiry, Registration_Date, Is_BlackListed) " +
                            "VALUES (@NicNumber, @UsersId, @FirstName, @LastName, @PhoneNumber, @Address, @City, @Country, @PostalCode, @DateOfBirth, @DrivingLicenseNumber, @DrivingLicenseExpiry, @RegistrationDate, @IsBlackListed)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NicNumber", customer.Nic_Number);
                command.Parameters.AddWithValue("@UsersId", customer.Users_Id);
                command.Parameters.AddWithValue("@FirstName", customer.First_Name);
                command.Parameters.AddWithValue("@LastName", customer.Last_Name);
                command.Parameters.AddWithValue("@PhoneNumber", customer.Phone_Number);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@City", customer.City);
                command.Parameters.AddWithValue("@Country", customer.Country);
                command.Parameters.AddWithValue("@PostalCode", customer.Postal_Code);
                command.Parameters.AddWithValue("@DateOfBirth", customer.Date_Of_Birth);
                command.Parameters.AddWithValue("@DrivingLicenseNumber", customer.Driving_License_Number);
                command.Parameters.AddWithValue("@DrivingLicenseExpiry", customer.Driving_License_Expiry);
                command.Parameters.AddWithValue("@RegistrationDate", customer.Registration_Date);
                command.Parameters.AddWithValue("@IsBlackListed", customer.Is_BlackListed);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }

        public async Task<int> CreateAdminAsync(Admin admin)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var query = "INSERT INTO ADMINS (Users_Id, First_Name, Last_Name, Phone_Number, Emergency_Contact, Hire_Date, Position, Salary) " +
                            "VALUES (@UsersId, @FirstName, @LastName, @PhoneNumber, @EmergencyContact, @HireDate, @Position, @Salary)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UsersId", admin.Users_Id);
                command.Parameters.AddWithValue("@FirstName", admin.First_Name);
                command.Parameters.AddWithValue("@LastName", admin.Last_Name);
                command.Parameters.AddWithValue("@PhoneNumber", admin.Phone_Number);
                command.Parameters.AddWithValue("@EmergencyContact", admin.Emergency_Contact);
                command.Parameters.AddWithValue("@HireDate", admin.Hire_Date);
                command.Parameters.AddWithValue("@Position", admin.Position);
                command.Parameters.AddWithValue("@Salary", admin.Salary);

                await connection.OpenAsync();
                return await command.ExecuteNonQueryAsync();
            }
        }
    }

}
