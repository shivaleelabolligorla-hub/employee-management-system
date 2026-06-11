using Ems.Domain.Entities;
using EMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace EMS.Persistence.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<User> Users{ get; set; }
    public DbSet<Role> Roles { get; set; }

}