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

            //Seed data for Brand & Laptop
            //Note: must add "brand" data first
            SeedBrand(builder);
            SeedLaptop(builder);
        }

        private void SeedBrand(ModelBuilder builder)
        {
            builder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Gaming" },
                new Brand { Id = 2, Name = "Business" },
                new Brand { Id = 3, Name = "Ultrabook" },
                new Brand { Id = 4, Name = "Convertible" },
                new Brand { Id = 5, Name = "Workstation" },
                new Brand { Id = 6, Name = "Budget" },
                new Brand { Id = 7, Name = "Chromebook" },
                new Brand { Id = 8, Name = "2-in-1" },
                new Brand { Id = 9, Name = "Performance" },
                new Brand { Id = 10, Name = "Gaming Ultra" }
            );
        }

        private void SeedLaptop(ModelBuilder builder)
        {
            builder.Entity<Laptop>().HasData(
                new Laptop { Id = 1, Model = "Asus TUF Gaming F15", Color = "Black", Quantity = 10, Price = 999, Image = "https://example.com/asus-tuf-f15.jpg", BrandId = 1 },
                new Laptop { Id = 2, Model = "Dell XPS 13", Color = "Silver", Quantity = 8, Price = 1399, Image = "https://example.com/dell-xps-13.jpg", BrandId = 3 },
                new Laptop { Id = 3, Model = "HP Envy x360", Color = "Silver", Quantity = 6, Price = 1149, Image = "https://example.com/hp-envy-x360.jpg", BrandId = 4 },
                new Laptop { Id = 4, Model = "Lenovo ThinkPad X1 Carbon", Color = "Black", Quantity = 5, Price = 1699, Image = "https://example.com/thinkpad-x1-carbon.jpg", BrandId = 2 },
                new Laptop { Id = 5, Model = "Apple MacBook Air M2", Color = "Space Gray", Quantity = 12, Price = 1199, Image = "https://example.com/macbook-air-m2.jpg", BrandId = 3 },
                new Laptop { Id = 6, Model = "Microsoft Surface Laptop 5", Color = "Platinum", Quantity = 7, Price = 1299, Image = "https://example.com/surface-laptop-5.jpg", BrandId = 8 },
                new Laptop { Id = 7, Model = "Razer Blade 15", Color = "Black", Quantity = 4, Price = 2499, Image = "https://example.com/razer-blade-15.jpg", BrandId = 1 },
                new Laptop { Id = 8, Model = "Acer Swift 3", Color = "Silver", Quantity = 9, Price = 799, Image = "https://example.com/acer-swift-3.jpg", BrandId = 6 },
                new Laptop { Id = 9, Model = "LG Gram 17", Color = "White", Quantity = 3, Price = 1799, Image = "https://example.com/lg-gram-17.jpg", BrandId = 9 },
                new Laptop { Id = 10, Model = "Asus ROG Zephyrus G14", Color = "Gray", Quantity = 5, Price = 1599, Image = "https://example.com/rog-zephyrus-g14.jpg", BrandId = 1 },
                new Laptop { Id = 11, Model = "Dell Inspiron 15", Color = "Black", Quantity = 8, Price = 699, Image = "https://example.com/dell-inspiron-15.jpg", BrandId = 6 },
                new Laptop { Id = 12, Model = "HP Pavilion 15", Color = "Gold", Quantity = 10, Price = 749, Image = "https://example.com/hp-pavilion-15.jpg", BrandId = 6 },
                new Laptop { Id = 13, Model = "Lenovo IdeaPad 5", Color = "Gray", Quantity = 6, Price = 849, Image = "https://example.com/lenovo-ideapad-5.jpg", BrandId = 3 },
                new Laptop { Id = 14, Model = "Samsung Galaxy Book 3", Color = "Silver", Quantity = 4, Price = 1249, Image = "https://example.com/galaxy-book-3.jpg", BrandId = 8 },
                new Laptop { Id = 15, Model = "MSI Katana GF66", Color = "Black", Quantity = 6, Price = 1049, Image = "https://example.com/msi-katana-gf66.jpg", BrandId = 1 },
                new Laptop { Id = 16, Model = "Asus VivoBook S14", Color = "Green", Quantity = 7, Price = 749, Image = "https://example.com/vivobook-s14.jpg", BrandId = 6 },
                new Laptop { Id = 17, Model = "Apple MacBook Pro 14", Color = "Silver", Quantity = 10, Price = 1999, Image = "https://example.com/macbook-pro-14.jpg", BrandId = 3 },
                new Laptop { Id = 18, Model = "Alienware m15 R7", Color = "Black", Quantity = 4, Price = 2299, Image = "https://example.com/alienware-m15-r7.jpg", BrandId = 1 },
                new Laptop { Id = 19, Model = "Chromebook Spin 713", Color = "Silver", Quantity = 9, Price = 629, Image = "https://example.com/chromebook-spin-713.jpg", BrandId = 7 },
                new Laptop { Id = 20, Model = "Gigabyte Aero 16", Color = "Black", Quantity = 3, Price = 2399, Image = "https://example.com/gigabyte-aero-16.jpg", BrandId = 9 }
            );
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
