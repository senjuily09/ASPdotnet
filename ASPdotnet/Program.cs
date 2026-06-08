using Microsoft.AspNetCore.Builder;
namespace ASPdotnet
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            var app = builder.Build();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.MapGet("/", () => "hjk");
            app.MapControllers();
            app.Run();
        }
    }
}