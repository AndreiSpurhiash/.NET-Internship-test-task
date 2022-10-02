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
                entity.Property(x => x.DateOfRegistration).HasColumnName(@"DateOfRegistration").HasColumnType("date").IsRequired();
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.ToTable("Photos");
                entity.HasKey(x => x.Id).HasName("Id1");
                entity.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("text").IsRequired();
                entity.Property(x => x.Link).HasColumnName(@"Link").HasColumnType("text").IsRequired();
                entity.Property(x => x.DateOfCreation).HasColumnName(@"DateOfCreation").HasColumnType("date").IsRequired();
                entity.Property(x => x.Coast).HasColumnName(@"Coast").HasColumnType("decimal").IsRequired();
                entity.Property(x => x.NumberOfSales).HasColumnName(@"NumberOfSales").HasColumnType("int").IsRequired();
                entity.Property(x => x.OriginalSize).HasColumnName(@"OriginalSize").HasColumnType("text").IsRequired();
                entity.Property(x => x.NumberOfRaiting).HasColumnName(@"NumberOfRaiting").HasColumnType("int");
                entity.Property(x => x.AmountOfRaiting).HasColumnName(@"AmountOfRaiting").HasColumnType("int");

                entity.HasOne(a => a.Author).WithMany(b => b.Photos).HasForeignKey(c => c.AuthorId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Text>(entity =>
            {
                entity.ToTable("Texts");
                entity.HasKey(x => x.Id).HasName("Id2");
                entity.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x.Name).HasColumnName(@"Name").HasColumnType("text").IsRequired();
                entity.Property(x => x.text).HasColumnName(@"text").HasColumnType("text").IsRequired();
                entity.Property(x => x.DateOfCreation).HasColumnName(@"DateOfCreation").HasColumnType("date").IsRequired();
                entity.Property(x => x.Coast).HasColumnName(@"Coast").HasColumnType("decimal").IsRequired();
                entity.Property(x => x.NumberOfSales).HasColumnName(@"NumberOfSales").HasColumnType("int").IsRequired();

                entity.HasOne(a => a.Author).WithMany(b => b.Texts).HasForeignKey(c => c.AuthorId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Author>().HasData(
                new Author[]
                {
                    new Author(Guid.Parse("14d5363b-0889-4b3d-aaa7-f456d7b0f195"), "Andrew", "Ivanov", "Pushkin", new DateTime(1994, 02, 03),
                     new DateTime(2022, 03, 15)),
                    new Author(Guid.Parse("f51cccd8-4c11-4c96-aff3-24b1b4922de7"), "Jhon", "Simons", "Simon", new DateTime(1975, 08, 12),
                     new DateTime(2019, 10, 10)),
                    new Author(Guid.Parse("1395039e-c3d8-4afb-811e-6a69ab3245bd"), "Mike", "Luis", "Lu", new DateTime(1995, 11, 21),
                     new DateTime(2021, 09, 19)),
                    new Author(Guid.Parse("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47"),"Piter", "Brown", "Pity", new DateTime(1989, 05, 12),
                     new DateTime(2020, 07, 08)),
                    new Author(Guid.Parse("b5f39d3b-4b8f-454b-8d20-a28be6271a40"),"Frenck", "Olsen", "Olsen", new DateTime(1979, 11, 25),
                     new DateTime(2017, 11, 14)),
                });

            modelBuilder.Entity<Photo>().HasData(
                new Photo[]
                {
                    new Photo("Sunflowers", "en.wikipedia.org/wiki/Sunflowers_(Van_Gogh_series)#/media/File:Vincent_Willem_van_Gogh_127.jpg",
                    new DateTime(2010, 02, 03), Guid.Parse("14d5363b-0889-4b3d-aaa7-f456d7b0f195"),100_000, 5, "100x100"),
                    new Photo("Riding Donkeys on the Beach", "en.wikipedia.org/wiki/Isaac_Isra%C3%ABls#/media/File:Isaac_Israels_-_Donkeyride.jpg",
                    new DateTime(2015, 11, 23), Guid.Parse("f51cccd8-4c11-4c96-aff3-24b1b4922de7"),200_000, 10, "1000x1000"),
                    new Photo("Gewonde KNIL-militair door", "en.wikipedia.org/wiki/Portrait_of_a_Wounded_KNIL_Soldier#/media/File:Gewonde_KNIL-militair_door_Isaac_Israels.jpg",
                    new DateTime(2015, 11, 23), Guid.Parse("1395039e-c3d8-4afb-811e-6a69ab3245bd"),500_000, 2, "1000x1500"),
                });

            modelBuilder.Entity<Text>().HasData(
              new Text[]
              {
                    new Text("Your Wounds", "Time doesn’t heal wounds\r\nto make you forget.",
                    new DateTime(2017, 01, 13),10_000, 5, Guid.Parse("ac898bde-ecc6-43c1-8f4b-a0d54dc17d47")),
                    new Text("Camouflaged", "In all chaotic beauty lies a wounded work of art.\r\nBeautiful but torn, wreaking havoc on my heart.\r\n\r\nSource: https://www.familyfriendpoems.com/poem/camouflaged",
                    new DateTime(2020, 09, 27),5_000, 50, Guid.Parse("b5f39d3b-4b8f-454b-8d20-a28be6271a40")),
              });
        }
    }
}
