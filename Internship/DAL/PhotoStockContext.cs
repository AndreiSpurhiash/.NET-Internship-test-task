using Internship.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Internship.DAL
{
    public class PhotoStockContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Photo> Photos { get; set; }
        public virtual DbSet<Text> Texts { get; set; }

        public PhotoStockContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=internship;Username=postgres;Password=1234;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.ToTable("Authors");
                entity.HasKey(x => x.Id).HasName("Id");
                entity.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("text").IsRequired();
                entity.Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("text").IsRequired();
                entity.Property(x => x.DateOfBirth).HasColumnName(@"DateOfBirth").HasColumnType("date").IsRequired();
                entity.Property(x => x.DateOfRegistration).HasColumnName(@"DateOfRegistration").HasColumnType("timestamp").IsRequired();
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photos");
                entity.HasKey(x => x.Id).HasName("Id1");
                entity.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("text").IsRequired();
                entity.Property(x => x.Link).HasColumnName(@"Link").HasColumnType("text").IsRequired();
                entity.Property(x => x.DateOfCreation).HasColumnName(@"DateOfCreation").HasColumnType("timestamp").IsRequired();
                entity.Property(x => x.Coast).HasColumnName(@"Coast").HasColumnType("decimal").IsRequired();
                entity.Property(x => x.NumberOfSales).HasColumnName(@"NumberOfSales").HasColumnType("int").IsRequired();
                entity.Property(x => x.Raiting).HasColumnName(@"Raiting").HasColumnType("float8").IsRequired();
                entity.Property(x => x.OriginalSize).HasColumnName(@"OriginalSize").HasColumnType("text").IsRequired();

                entity.HasOne(a => a.Author).WithMany(b => b.Photos).HasForeignKey(c => c.AuthorId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Text>(entity =>
            {
                entity.ToTable("Texts");
                entity.HasKey(x => x.Id).HasName("Id2");
                entity.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("text").IsRequired();
                entity.Property(x => x.text).HasColumnName(@"text").HasColumnType("text").IsRequired();
                entity.Property(x => x.DateOfCreation).HasColumnName(@"DateOfCreation").HasColumnType("timestamp").IsRequired();
                entity.Property(x => x.Coast).HasColumnName(@"Coast").HasColumnType("decimal").IsRequired();
                entity.Property(x => x.NumberOfSales).HasColumnName(@"NumberOfSales").HasColumnType("int").IsRequired();

                entity.HasOne(a => a.Author).WithMany(b => b.Texts).HasForeignKey(c => c.AuthorId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Author>().HasData(
                new Author[]
                {
                    new Author("Andrew", "Ivanov", "Pushkin", new DateTime(1994, 02, 03),
                     new DateTime(2022, 03, 15)),
                    new Author("Jhon", "Simons", "Simon", new DateTime(1975, 08, 12),
                     new DateTime(2019, 10, 10)),
                    new Author("Mike", "Luis", "Lu", new DateTime(1995, 11, 21),
                     new DateTime(2021, 09, 19)),
                    new Author("Piter", "Brown", "Pity", new DateTime(1989, 05, 12),
                     new DateTime(2020, 07, 08)),
                    new Author("Frenck", "Olsen", "Olsen", new DateTime(1979, 11, 25),
                     new DateTime(2017, 11, 14)),
                });

            modelBuilder.Entity<Photo>().HasData(
                new Photo[]
                {
                    new Photo("Colors", "ddddddddddddddd", new DateTime(2010, 02, 03), Author sim,
                     100_000, 5, "100x100"),
                });
        }
    }
}
