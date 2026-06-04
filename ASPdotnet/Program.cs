using Microsoft.AspNetCore.Builder;

namespace ASPdotnot
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 }
            };

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Name} {person.Age}");
            }

            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}