namespace EF2;

using System;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        // readData();
        // usingLINQ();
        using (Critical c = new Critical())
        {
            Console.WriteLine("In the using block");
        }
        Console.ReadLine();
    }
    static void usingLINQ()
    {
        using var db = new NorthwindContext();

        var customers = db.Customers
                          .OrderBy(c => c.CompanyName)
                          .Take(10)
                          .ToList();

        foreach (var c in customers)
            Console.WriteLine($"{c.CustomerID,-5} {c.CompanyName,-40} {c.City}");
    }

    static void readData()
    {
        using var db = new NorthwindContext();

        var customers = db.Customers.ToList();

        foreach (var c in customers)
            Console.WriteLine($"{c.CustomerID,-5} {c.CompanyName,-40} {c.City}");
    }

}

