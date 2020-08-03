using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Question1.Models
{
    public class ApplicationDbContext:DbContext
    {
        //Database deal
        public ApplicationDbContext() : base("DefaultConnection") { }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        //How to find key column
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.CategoryId);
            modelBuilder.Entity<Category>().Property(c => c.CategoryId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Brand>().HasKey(c => c.BrandId);
            modelBuilder.Entity<Brand>().Property(c => c.BrandId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            modelBuilder.Entity<Product>().HasKey(c => c.ProductId);
            modelBuilder.Entity<Product>().Property(c => c.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Foreign Key : product Id
            modelBuilder.Entity<Product>().HasRequired(c => c.Brand).WithMany(b => b.Products).HasForeignKey(b=>b.BrandId);

            //Foreign Key : product Id
            modelBuilder.Entity<Product>().HasRequired(c => c.Category).WithMany(b => b.Products).HasForeignKey(b => b.CategoryId);

            base.OnModelCreating(modelBuilder);
        }
    }
}