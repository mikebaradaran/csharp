using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;

namespace DbContextDemo;

public class Program
{
    static void Main(string[] args)
    {
        List<String> names = new List<String>
        {
            "Petras, Magda",
            "Harris Leadbeater",
            "Ahmed, Shahjahan",
            "Marshall, Andrew",
            "Richmond, Tyler",
            "Terry, George",
            "Smith, Callum",
            "Motara, Abraarul-haqq",
            "Kian, Ali",
            "Elizbarashvili, Luka"
        };

        using var db = new SchoolContext();

        foreach (String name in names)
        {
            Student student = new Student(name, 21);
            db.Students.Add(student);
            db.SaveChanges();
            Console.WriteLine($"Saved student with ID: {student.Id}");
        }


        // Verify by reading all students
        var allStudents = db.Students.ToList();
        foreach (var s in allStudents)
        {
            Console.WriteLine($"{s.Id}: {s.Name} ({s.Age})");
        }
    }
}

public class Student
{
    public Student( string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int Id { get; set; }      // Primary key
    public string Name { get; set; }
    public int Age { get; set; }
}

public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer("Server=.\\sqlexpress;Database=SchoolDB;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=True;");
}
