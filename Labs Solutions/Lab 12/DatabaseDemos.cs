using System;
using System.Collections.Generic;
using System.Data.SqlClient;

public class DatabaseDemos
{
    static void Start()
    {
        databaseDemo_Select();
        databaseDemo_Update();
        databaseDemo_Insert();
        databaseDemo_Delete();
    }

    private static void databaseDemo_Delete()
    {
        SqlConnection connection = getConnection();
        SqlCommand command =
            new SqlCommand("DELETE customers WHERE CustomerID='ID888'", connection);

        connection.Open();
        int Res = command.ExecuteNonQuery();
        connection.Close();

        Console.WriteLine(Res + " rows deleted");
    }

    private static void databaseDemo_Insert()
    {
        string query = @"INSERT INTO Customers (ID, company, name, city) VALUES ('ID888', 'QA', 'Mike B', 'London')";

        SqlConnection connection = getConnection();

        SqlCommand command = new SqlCommand(query, connection);

        connection.Open();
        int Res = command.ExecuteNonQuery();
        connection.Close();

        Console.WriteLine(Res + " rows inserted");
    }

    private static void databaseDemo_Update()
    {
        SqlConnection connection = getConnection();

        SqlCommand Com = new SqlCommand(@"UPDATE customers SET Region='DC' WHERE CustomerID='ALFKI'", connection);

        connection.Open();
        int Res = Com.ExecuteNonQuery();
        connection.Close();

        Console.WriteLine(Res + " rows updated");
    }

    private static SqlConnection getConnection()
    {
        return  new SqlConnection(
      @"Data Source=.\sqlexpress;Initial Catalog=Northwind;Integrated Security=True;TrustServerCertificate=True");
    }
    private static void databaseDemo_Select()
    {
        SqlConnection connection = getConnection();
        SqlCommand Com = new SqlCommand("SELECT * FROM customers", connection);
        connection.Open();

        SqlDataReader Dr = Com.ExecuteReader();
        while (Dr.Read())
        {
            Console.WriteLine(Dr[0] + " - " + Dr["contactName"]);
        }
        connection.Close();
    }
}


