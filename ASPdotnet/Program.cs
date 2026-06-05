using Microsoft.AspNetCore.Builder;

namespace ASPdotnet
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            app.MapControllers();
            app.MapGet("/", () => "hi");
            app.Run();

        }
    }
}