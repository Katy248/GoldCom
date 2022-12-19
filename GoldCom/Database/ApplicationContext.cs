using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.Models;
using Microsoft.EntityFrameworkCore;

namespace GoldCom.Database;
public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=GoldComDB.db");
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<DeliveryReport> DeliveryReports { get; set; }
    public DbSet<ShipmentReport> ShipmentReports { get; set; }
    public DbSet<MaterialType> MaterialTypes { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<StockUnit> StockUnits { get; set; }
    public DbSet<User> Users { get; set; }
}
