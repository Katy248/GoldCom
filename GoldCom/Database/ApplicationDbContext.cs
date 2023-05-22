using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoldCom.Domain.Interfaces;
using GoldCom.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GoldCom.Database;
public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        Database.EnsureCreated();
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
