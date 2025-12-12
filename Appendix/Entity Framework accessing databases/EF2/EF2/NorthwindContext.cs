using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2;

using Microsoft.EntityFrameworkCore;

public class NorthwindContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
}