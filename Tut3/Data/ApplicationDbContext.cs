using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tut3.Models;

namespace Tut3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Tut3.Models.Brand> Brand { get; set; }
        public DbSet<Tut3.Models.Laptop> Laptop { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seed data for User & Role
            SeedUserRole(builder);
        }

        private void SeedUserRole(ModelBuilder builder)
        {
            //add data for "user"
            var admin = new IdentityUser
            {
                Id = "admin-account",
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true
            };
            var user = new IdentityUser
            {
                Id = "user-account",
                UserName = "user@gmail.com",
                Email = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                NormalizedEmail = "USER@GMAIL.COM",
                EmailConfirmed = true
            };
            //set password for accounts
            var hasher = new PasswordHasher<IdentityUser>();
            admin.PasswordHash = hasher.HashPassword(admin, "123456");
            user.PasswordHash = hasher.HashPassword(user, "123456");
            //add account to db
            builder.Entity<IdentityUser>().HasData(admin, user);

            //add data for "role"
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "admin-role",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "user-role",
                    Name = "User",
                    NormalizedName = "USER"
                });
            //assign role to user
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "admin-account",
                    RoleId = "admin-role"
                },
                new IdentityUserRole<string>
                {
                    UserId = "user-account",
                    RoleId = "user-role"
                }
                );
        }
    }
}
