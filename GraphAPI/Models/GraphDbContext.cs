using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphAPI.Models
{
    public class GraphDbContext : DbContext
    {
        public GraphDbContext(DbContextOptions<GraphDbContext> options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Face> Faces { get; set; }
        public DbSet<Plate> Plates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().HasData(new Owner
            {
                Id = 1,
                Name = "Liem's Plate",
                PhoneNumber = "123456789",
                Address = "Da Nang",
                Email = "Liemnguyenx",
            }, new Owner
            {
                Id = 2,
                Name = "Liem's Plate",
                PhoneNumber = "123456789",
                Address = "Da Nang",
                Email = "Liemnguyenx",
            }
            );
            modelBuilder.Entity<Plate>().HasData(new Plate
            {
                Id = 1,
                OwnerId = 1,
                Location = "Da Nang123",
                Number = "43-K1-12346",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }, new Plate
            {
                Id = 2,
                OwnerId = 1,
                Number = "43-K1-12347",
                Location = "Ha Noi 123",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }, new Plate
            {
                Id = 3,
                OwnerId = 2,
                Number = "43-K1-12348",
                Location = "HCM123",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }
            );

            modelBuilder.Entity<Face>().HasData(new Face
            {
                Id = 1,
                OwnerId = 2,
                Location = "Nha Trang",
                Img = "img1",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }, new Face
            {
                Id = 2,
                OwnerId = 2,
                Location = "Quy Nhon",
                Img = "img1",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }, new Face
            {
                Id = 3,
                OwnerId = 1,
                Location = "Hue",
                Img = "img1",
                ModifyDate = DateTime.Now,
                LastFound = DateTime.Now,
                CreateAt = DateTime.Now
            }
            );
        }
    }
}
