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
            List<student> students = new List<student>();
            students.Add(new student { name = "Alice", age = 20 });
            students.Add(new student { name = "Bob", age = 22 });

            foreach (student s1 in students)
            {
                Console.WriteLine($"Name: {s1.name}, Age: {s1.age}");

            }
            var adults = students.Where(s => s.age >= 21);
            foreach(student s in adults)
            {
                Console.WriteLine($"{s.name}{s.age}");
            }
        }
    }
}