
using MotorBikeRentalAPI.IRepositories;
using MotorBikeRentalAPI.Repositories;

namespace MotorBikeRentalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddSingleton<IAdminRepository>(provider => new AdminRepository(connectionString));
            builder.Services.AddSingleton<ICategoryRepository>(provider => new CategoryRepository(connectionString));
            builder.Services.AddSingleton<ICustomerRepository>(provider => new CustomerRepository(connectionString));
            builder.Services.AddSingleton<IMaintenanceRepository>(provider => new MaintenanceRepository(connectionString));
            builder.Services.AddSingleton<IMotorBikeRepository>(provider => new MotorBikeRepository(connectionString));
            builder.Services.AddSingleton<IRentalRepository>(provider => new RentalRepository(connectionString));
            builder.Services.AddSingleton<IReviewRepository>(provider => new  ReviewRepository(connectionString));
            builder.Services.AddSingleton<IUserRepository>(provider => new UserRepository(connectionString));
            builder.Services.AddSingleton<IWaitListRepository>(provider => new WaitListRepository(connectionString));


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
