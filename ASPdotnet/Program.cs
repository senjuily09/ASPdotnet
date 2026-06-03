using System;
using System.Collections.Generic;
using System.Linq;

namespace ASPdotnet
{
    class student
    {
        public string name { get; set; }
        public int age { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<student> s = new List<student>();
            s.Add(new student { name = "s1", age = 20 });
            s.Add(new student { name = "s2", age = 21 });
            var result = s.Where(s => s.age >= 20);
            foreach(student s1 in result)
            {
                Console.WriteLine($"{s1.name} {s1.age}");
            }
            var result2 = s.FirstOrDefault(s => s.name == "s1");
            Console.WriteLine($"{result2.name} {result2.age}");

            // dictionary 
            Dictionary<int , string> d = new Dictionary<int, string>();
            d.Add(1, "one");
            d.Add(2,"two");
            Console.WriteLine(d[2]);

            var builder = WebApplication.CreateBuilder(args);

            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}