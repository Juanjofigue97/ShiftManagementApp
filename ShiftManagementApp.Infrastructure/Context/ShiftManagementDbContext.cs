using Microsoft.EntityFrameworkCore;
using ShiftManagementApp.Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftManagementApp.Infrastructure.Context;

public class ShiftManagementDbContext : DbContext
{
    public ShiftManagementDbContext(DbContextOptions<ShiftManagementDbContext> options)
            : base(options)
    {
    }

    public DbSet<Person> Persons { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<ServiceLocation> ServiceLocations { get; set; }
    public DbSet<ShiftControl> ShiftControls { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ShiftControl>()
            .HasOne(sc => sc.Person)
            .WithMany()
            .HasForeignKey(sc => sc.PersonID);

        modelBuilder.Entity<ShiftControl>()
            .HasOne(sc => sc.Service)
            .WithMany()
            .HasForeignKey(sc => sc.ServiceID);

        modelBuilder.Entity<ShiftControl>()
            .HasOne(sc => sc.ServiceLocation)
            .WithMany()
            .HasForeignKey(sc => sc.ServiceLocationID);


        modelBuilder.Entity<ServiceLocation>()
            .HasOne(sl => sl.Service)
            .WithMany()
            .HasForeignKey(sl => sl.ServiceID);
    }

}
