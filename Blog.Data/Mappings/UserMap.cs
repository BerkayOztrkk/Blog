using Blog.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Data.Mappings
{
    internal class UserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);

            // Indexes for "normalized" username and email, to allow efficient lookups
            builder.HasIndex(u => u.NormalizedUserName).HasName("UserNameIndex").IsUnique();
            builder.HasIndex(u => u.NormalizedEmail).HasName("EmailIndex");

            // Maps to the AspNetUsers table
            builder.ToTable("AspNetUsers");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(u => u.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.UserName).HasMaxLength(256);
            builder.Property(u => u.NormalizedUserName).HasMaxLength(256);
            builder.Property(u => u.Email).HasMaxLength(256);
            builder.Property(u => u.NormalizedEmail).HasMaxLength(256);

            // The relationships between User and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each User can have many UserClaims
            builder.HasMany<AppUserClaim>().WithOne().HasForeignKey(uc => uc.UserId).IsRequired();

            // Each User can have many UserLogins
            builder.HasMany<AppUserLogin>().WithOne().HasForeignKey(ul => ul.UserId).IsRequired();

            // Each User can have many UserTokens
            builder.HasMany<AppUserToken>().WithOne().HasForeignKey(ut => ut.UserId).IsRequired();

            // Each User can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            var superadmin = new AppUser
            {
                Id=Guid.Parse("8BC8F0F5-3A0D-440D-B13B-EB6DACAFEDD2"),
                UserName="superadmin@gmail.com",
                NormalizedUserName="SUPERADMIN@GMAIL.COM",
                Email="superadmin@gmail.com",
                NormalizedEmail="SUPERADMIN@GMAIL.COM",
                PhoneNumber="+905439999999",
                FirstName="Berkay",
                LastName="Ozturk",
                PhoneNumberConfirmed=true,
                EmailConfirmed=true,
                SecurityStamp=Guid.NewGuid().ToString(),
                ImageId=Guid.Parse("8546782B-AC8C-41A8-8DCE-851C8BE76CC0"),

            };
            superadmin.PasswordHash=CreatePasswordHash(superadmin,"112233");
            var admin = new AppUser
            {
                Id=Guid.Parse("366086F4-55A3-44C2-98FA-63C56775CDFB"),
                UserName="admin@gmail.com",
                NormalizedUserName="ADMIN@GMAIL.COM",
                Email="admin@gmail.com",
                NormalizedEmail="ADMIN@GMAIL.COM",
                PhoneNumber="+905431111111",
                FirstName="Admin",
                LastName="User",
                PhoneNumberConfirmed=false,
                EmailConfirmed=false,
                SecurityStamp=Guid.NewGuid().ToString(),
                ImageId=Guid.Parse("0742DD33-C4AC-4591-B245-F36AED3621E9"),

            };
           admin.PasswordHash=CreatePasswordHash(admin, "334455");
            builder.HasData(superadmin,admin);
        }
        private string CreatePasswordHash(AppUser user, string password)
        {
            var passwordhasher = new PasswordHasher<AppUser>();
            return passwordhasher.HashPassword(user, password);

        }
    }
}
