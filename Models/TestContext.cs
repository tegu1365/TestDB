using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDatabase.Models
{
    public class TestContext : DbContext
    {
        public TestContext()
        {

        }

        public TestContext(DbContextOptions options):base(options) 
        {

        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<File> Files { get; set; }
        public DbSet<Profile> Profiles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profile>()
                .HasMany(p => p.Contents)
                .WithOne(c => c.Uploader);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Contents)
                .WithOne(c => c.Category);

            modelBuilder.Entity<Content>()
                .HasOne<File>(c => c.File)
                .WithOne(f => f.Content)
                .HasForeignKey<File>(f => f.ContentId);
        }
    }
}
