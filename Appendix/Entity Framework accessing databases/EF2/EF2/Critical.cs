using System;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("person.json");

        Person person = JsonSerializer.Deserialize<Person>(json)!;

        Console.WriteLine($"{person.Name} is {person.Age} years old.");
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}
