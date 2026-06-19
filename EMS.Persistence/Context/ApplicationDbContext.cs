using EMS.Domain.Entities;
using EMS.Persistence.Configurations;
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
       /* modelBuilder.ApplyConfiguration(
        new RoleConfiguration());
        modelBuilder.ApplyConfiguration(
        new UserConfiguration());
        modelBuilder.ApplyConfiguration(
        new EmployeeConfiguration());*/
    
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<User> Users{ get; set; }
    public DbSet<Role> Roles { get; set; }

}