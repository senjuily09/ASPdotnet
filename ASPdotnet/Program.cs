using Microsoft.AspNetCore.Builder;
using ASPdotnet.Data;
using Microsoft.EntityFrameworkCore;

namespace ASPdotnet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Enable Controllers
            builder.Services.AddControllers();


            builder.Services.AddDbContext<AppDbContext>(
            options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")
        )
);

            // Enable Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Enable Swagger UI
            app.UseSwagger();
            app.UseSwaggerUI();

            // Enable Controller Routes
            app.MapControllers();

            // Home Page
            app.MapGet("/", () => "hi");

            app.Run();
        }
    }
}