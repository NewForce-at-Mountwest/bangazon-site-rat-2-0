using System;
using System.Collections.Generic;
using System.Text;
using BangazonSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BangazonSite.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Create User
            ApplicationUser user = new ApplicationUser
            {
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                SecurityStamp = "7f434309-a4d9-48e9-9ebb-8803db794577",
                Id = "00000000-ffff-ffff-ffff-ffffffffffff",
                FirstName = "Stinky",
                LastName = "Piere",
                StreetAddress = "123 tra la la Lane",
                PhoneNumber = "123-456-7890",
                AccountCreated = new DateTime(2020, 01, 01),
                LastActive = new DateTime(2020, 01, 01)
            };

            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin123!");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            // Create four Orders
            modelBuilder.Entity<Order>().HasData(
                new Order()
                {
                    Id = 1,
                    PaymentTypeId = 1,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    DateCreated = new DateTime(2020, 01, 01),
                    DateCompleted = null
                },
                new Order()
                {
                    Id = 2,
                    PaymentTypeId = 2,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    DateCreated = new DateTime(2020, 01, 02),
                    DateCompleted = null
                },
                 new Order()
                 {
                     Id = 3,
                     PaymentTypeId = 3,
                     UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     DateCreated = new DateTime(2020, 01, 03),
                     DateCompleted = null
                 },
                new Order()
                {
                    Id = 4,
                    PaymentTypeId = 1,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    DateCreated = new DateTime(2020, 01, 04),
                    DateCompleted = null
                }
                );

            // Create four OrderProducts
            modelBuilder.Entity<OrderProduct>().HasData(
                new OrderProduct()
                {
                    OrderProductId = 1,
                    OrderId = 1,
                    ProductId = 1
                },
                new OrderProduct()
                {
                    OrderProductId = 2,
                    OrderId = 2,
                    ProductId = 2
                },
                 new OrderProduct()
                 {
                     OrderProductId = 3,
                     OrderId = 3,
                     ProductId = 3
                 },
                new OrderProduct()
                {
                    OrderProductId = 4,
                    OrderId = 4,
                    ProductId = 4
                }
            );

            // Create four paymentTypes
            modelBuilder.Entity<PaymentType>().HasData(
                    new PaymentType()
                    {
                        Id = 1,
                        CardNumber = "4560857498651258",
                        Name = "Chase Visa",
                        UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                        DateCreated = new DateTime(2020, 01, 01),
                        IsActive = true
                    },
                        new PaymentType()
                        {
                            Id = 2,
                            CardNumber = "8599665525897845",
                            Name = "Mastercard",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            DateCreated = new DateTime(2020, 01, 02),
                            IsActive = true
                        },
                        new PaymentType()
                        {
                            Id = 3,
                            CardNumber = "8500451278453287",
                            Name = "American Express",
                            UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                            DateCreated = new DateTime(2020, 01, 03),
                            IsActive = true
                        },
                         new PaymentType()
                         {
                             Id = 4,
                             CardNumber = "8700450012005487",
                             Name = "Visa",
                             UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                             DateCreated = new DateTime(2020, 01, 04),
                             IsActive = true
                         }
                     );

            // Create four products
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    ProductTypeId = 3,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    DateCreated = new DateTime(2020, 01, 01),
                    Description = "Aluminum",
                    Title = "Baseball bat",
                    Quantity = 50,
                    Price = 30.00,
                    LocalDelivery = false,
                    City = "Ashland",
                    Archived = false
                },
                new Product()
                {
                    Id = 2,
                    ProductTypeId = 1,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    Description = "To infinity and beyond",
                    DateCreated = new DateTime(2020, 01, 02),
                    Title = "Buzz Lightyear",
                    Quantity = 50,
                    Price = 20.00,
                    LocalDelivery = false,
                    City = "Huntington",
                    Archived = false
                },
                 new Product()
                 {
                     Id = 3,
                     DateCreated = new DateTime(2020, 01, 03),
                     ProductTypeId = 2,
                     UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                     Description = "Washes dishes",
                     Title = "Dishwasher",
                     Quantity = 50,
                     Price = 250.00,
                     LocalDelivery = false,
                     City = "Ironton",
                     Archived = false
                 },
                new Product()
                {
                    Id = 4,
                    DateCreated = new DateTime(),
                    ProductTypeId = 4,
                    UserId = "00000000-ffff-ffff-ffff-ffffffffffff",
                    Description = "Looks fierce, but will not bite",
                    Title = "Bear rug",
                    Quantity = 32,
                    Price = 200.00,
                    LocalDelivery = false,
                    City = "Argillite",
                    Archived = false
                }
           );

            // Create four ProductTypes
            modelBuilder.Entity<ProductType>().HasData(
                new ProductType()
                {
                    Id = 1,
                    Category = "Toys",
                    Quantity = 101
                },
                new ProductType()
                {
                    Id = 2,
                    Category = "Appliances",
                    Quantity = 52
                },
                new ProductType()
                {
                    Id = 3,
                    Category = "Sporting Goods",
                    Quantity = 80
                },
                new ProductType()
                {
                    Id = 4,
                    Category = "Home Decor",
                    Quantity = 82
                }
            );

            modelBuilder.Entity<Order>().HasMany(Order => Order.OrderProducts)
            .WithOne(OrderProducts => OrderProducts.Order)
            .OnDelete(DeleteBehavior.Restrict);

            // Restrict deletion of related product when OrderProducts entry is removed
            modelBuilder.Entity<Product>()
                .HasMany(Order => Order.OrderProducts)
                .WithOne(OrderProducts => OrderProducts.Product)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Product>()
                .Property(D => D.DateCreated)
                .HasDefaultValueSql("GETDATE()");
        }
    }
}
