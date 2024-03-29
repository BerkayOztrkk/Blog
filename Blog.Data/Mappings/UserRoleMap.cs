using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {

            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
               UserId=Guid.Parse("8BC8F0F5-3A0D-440D-B13B-EB6DACAFEDD2"),
              RoleId=Guid.Parse("24355066-6A34-483F-B192-78B6ADAF6E4E"),
            },
            new AppUserRole
            {
                UserId=Guid.Parse("366086F4-55A3-44C2-98FA-63C56775CDFB"),
                RoleId=Guid.Parse("6F60ED89-2A21-4B17-B5C9-E8C88BAC3C27"),

            }) ;
        }
    }
}
