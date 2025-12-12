using Microsoft.Data.SqlClient;

namespace EF1;

internal class Program
{
    static void Main(string[] args)
    {
        //part1();
        //part2();
        part3();
        //part4();
        //EF();
    }

    static void EF()
    {
        using var db = new MyDbContext();

        // Read all
        var list = db.Customers.ToList();
        foreach (var cus in list)
            Console.WriteLine($"{cus.CustomerId}: {cus.ContactName} ({cus.City})");
    }
    static void part2()
    {
        string connString = "Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;;TrustServerCertificate=True";

        using (SqlConnection conn = new SqlConnection(connString))
        {
            conn.Open();
            Console.WriteLine("Connected!");

            string sql = "SELECT COUNT(*) FROM customers";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                int count = (int)cmd.ExecuteScalar();
                Console.WriteLine($"Rows: {count}");
            }

        }
    }
static void part3()
{
    string connString = "Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;;TrustServerCertificate=True";

    using (SqlConnection conn = new SqlConnection(connString))
    {
        conn.Open();
        Console.WriteLine("Connected!");

        string sql = "SELECT * FROM customers";
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            SqlDataReader reader =  cmd.ExecuteReader();
            while (reader.Read())
            {
                string city = reader["City"].ToString();
                Console.WriteLine($"{reader[0]} {reader[1]} {city}");
            }
        }
    }
}
static void part4()
{
    string connString = "Server=.\\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;;TrustServerCertificate=True";

    using (SqlConnection conn = new SqlConnection(connString))
    {
        conn.Open();
        Console.WriteLine("Connected!");

        string sql = "DELETE FROM customers WHERE CustomerID='zzzzz'";
        using (SqlCommand cmd = new SqlCommand(sql, conn))
        {
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine($"Number of row affected: {rowsAffected}");
            }
        }
    }
}

    static void part1()
    {
        using var db = new SchoolContext();
        db.Students.Add(new Student { Name = "Jonathan", Age = 43 });
        //db.Students.Remove(new Student { Id = 3 });
        db.SaveChanges();

        // Read
        var list = db.Students.ToList();
        foreach (var s in list)
            Console.WriteLine($"{s.Id}: {s.Name} ({s.Age})");

    }
}
