using Microsoft.AspNetCore.Builder;

namespace ASPdotnet{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.MapControllers();
            app.MapGet("/", () => "hello world ");
            app.Run();

        }
    }
}

