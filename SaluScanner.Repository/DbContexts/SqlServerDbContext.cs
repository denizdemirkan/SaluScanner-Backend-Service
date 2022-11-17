﻿using Microsoft.EntityFrameworkCore;
using SaluScanner.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SaluScanner.Repository.DbContexts
{
    public class SqlServerDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Allergen> Allergens { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Nutrition> Nutritions { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }

        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Search "Configurations" in the current Assembly (application)
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}