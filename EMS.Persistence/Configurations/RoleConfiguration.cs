using EMS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EMS.Persistence.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.RoleName)
               .IsRequired()
               .HasMaxLength(50);
        builder.HasData(
            new Role
            {
                Id = 1,
                RoleName = "Admin"
            },
            new Role
            {
                Id = 2,
                RoleName = "HR"
            },
            new Role
            {
                Id = 3,
                RoleName = "Employee"
            });
            

    }
}