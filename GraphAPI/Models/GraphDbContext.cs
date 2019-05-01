using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toolbelt.ComponentModel.DataAnnotations;

namespace GraphAPI.Models
{
    public class GraphDbContext : DbContext
    {
        public GraphDbContext(DbContextOptions<GraphDbContext> options)
            : base(options)
        {
        }
        public DbSet<Mast> Masts { get; set; }
        public DbSet<ConfigurationType> ConfigurationTypes { get; set; }
        public DbSet<GlobalConfiguration> GlobalConfigurations { get; set; }
        public DbSet<MastConfiguration> MastConfigurations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GraphDbContext>();
            new GraphDbContext(optionsBuilder.Options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.BuildIndexesFromAnnotations();

            #region multiple key in mast configuration
            modelBuilder.Entity<MastConfiguration>().HasKey(k => new
            {
                k.MastId,
                k.ConfigTypeId
            });
            #endregion

            #region seed data Configuration Type
            modelBuilder.Entity<ConfigurationType>().HasData(
                new ConfigurationType
                {
                    Id = new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"),
                    Name = "HeightThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("8c8132ce-b561-4925-96bb-15a32c5dcdcd"),
                    Name = "StaggerThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("4912c143-c04e-4d70-8f7c-c95bb279fdcf"),
                    Name = "ArcThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("63229215-56a9-48eb-b5be-72edb90d7a53"),
                    Name = "ArcingIntensityThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("a77d6b66-0a44-497e-bcf4-7ca57f105499"),
                    Name = "SustainedStaggerDistanceThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("d3666b8d-a0cd-4db0-86a1-a76df3f871f7"),
                    Name = "SustainedArcingIntensityThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("b015c95f-f687-455c-9f12-99e6a43362e0"),
                    Name = "SustainedArcingNumberOfArcsThreshold"
                },
                new ConfigurationType
                {
                    Id = new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"),
                    Name = "SustainedArcingDistanceThreshold"
                }
            );
            #endregion

            #region seed data Global Configuration
            modelBuilder.Entity<GlobalConfiguration>().HasData(
                new GlobalConfiguration
                {
                    Id = new Guid("5bac22e3-1d3c-45d5-b03a-738b734457a2"),
                    ConfigTypeId = new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"),
                    Min = 2.3F,
                    Max = 3.4F
                },
                new GlobalConfiguration
                {
                    Id = new Guid("cb3897b5-625f-46be-b44b-1c1b8a70a527"),
                    ConfigTypeId = new Guid("8c8132ce-b561-4925-96bb-15a32c5dcdcd"),
                    Min = 2.35F,
                    Max = 3.43F
                },
                new GlobalConfiguration
                {
                    Id = new Guid("23d98649-6626-40de-9685-1b1f7c37084a"),
                    ConfigTypeId = new Guid("4912c143-c04e-4d70-8f7c-c95bb279fdcf"),
                    Min = 3.3F,
                    Max = 4.4F
                },
                 new GlobalConfiguration
                 {
                     Id = new Guid("4aa8fd18-80fb-4228-b8dd-409e7aa387c9"),
                     ConfigTypeId = new Guid("63229215-56a9-48eb-b5be-72edb90d7a53"),
                     Min = 3.35F,
                     Max = 4.45F
                 },
                 new GlobalConfiguration
                 {
                     Id = new Guid("a0c626ca-72a2-4aa4-b721-4933aa9e3d8e"),
                     ConfigTypeId = new Guid("a77d6b66-0a44-497e-bcf4-7ca57f105499"),
                     Min = 4.35F,
                     Max = 5.45F
                 },
                 new GlobalConfiguration
                 {
                     Id = new Guid("d353e98d-f8e2-4d0a-b823-a683d74a99bd"),
                     ConfigTypeId = new Guid("d3666b8d-a0cd-4db0-86a1-a76df3f871f7"),
                     Min = 3.37F,
                     Max = 4.44F
                 },
                 new GlobalConfiguration
                 {
                     Id = new Guid("52bc54d0-c766-441f-9b88-f1d9dfc6e293"),
                     ConfigTypeId = new Guid("b015c95f-f687-455c-9f12-99e6a43362e0"),
                     Min = 3.33F,
                     Max = 4.41F
                 },
                 new GlobalConfiguration
                 {
                     Id = new Guid("6f7b3f57-0530-497a-8094-650453f1354b"),
                     ConfigTypeId = new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"),
                     Min = 3.32F,
                     Max = 4.48F
                 }
            );
            #endregion

            #region seed data Mast
            modelBuilder.Entity<Mast>().HasData(
               new Mast
               {
                   Id = new Guid("6705669e-00fd-4f56-8138-0421b75f4f56"),
                   Lat = 16.069968M,
                   Lon = 108.232043M
               },
               new Mast
               {
                   Id = new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"),
                   Lat = 16.069954M,
                   Lon = 108.232043M
               },
               new Mast
               {
                   Id = new Guid("fc9bb638-95a1-48f6-bc9c-ebbb17db90d7"),
                   Lat = 16.069968M,
                   Lon = 108.232023M
               },
               new Mast
               {
                   Id = new Guid("498f054e-65c8-4cd0-8c8e-07d5a3e5d6fa"),
                   Lat = 16.069971M,
                   Lon = 108.232023M
               }
           );
            #endregion

            #region seed data Mast Configuration
            modelBuilder.Entity<MastConfiguration>().HasData(
                new MastConfiguration
                {
                    MastId = new Guid("6705669e-00fd-4f56-8138-0421b75f4f56"),
                    ConfigTypeId = new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"),
                    Min = 2.35F,
                    Max = 3.35F
                },
                new MastConfiguration
                {
                    MastId = new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"),
                    ConfigTypeId = new Guid("853bf959-2fab-4b6b-9390-98a53c8e210f"),
                    Min = null,
                    Max = null
                },
                new MastConfiguration
                {
                    MastId = new Guid("d35b4e13-2fdd-46b3-9898-e85036bad865"),
                    ConfigTypeId = new Guid("db7b21a5-6e92-45e9-b92b-493df455fc2c"),
                    Min = null,
                    Max = null
                }
                );
            #endregion

        }
        //public DbSet<Owner> Owners { get; set; }
        //public DbSet<Face> Faces { get; set; }
        //public DbSet<Plate> Plates { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Owner>().HasData(new Owner
        //    {
        //        Id = 1,
        //        Name = "Liem's Plate",
        //        PhoneNumber = "123456789",
        //        Address = "Da Nang",
        //        Email = "Liemnguyenx",
        //    }, new Owner
        //    {
        //        Id = 2,
        //        Name = "Liem's Plate",
        //        PhoneNumber = "123456789",
        //        Address = "Da Nang",
        //        Email = "Liemnguyenx",
        //    }
        //    );
        //    modelBuilder.Entity<Plate>().HasData(new Plate
        //    {
        //        Id = 1,
        //        OwnerId = 1,
        //        Location = "Da Nang123",
        //        Number = "43-K1-12346",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }, new Plate
        //    {
        //        Id = 2,
        //        OwnerId = 1,
        //        Number = "43-K1-12347",
        //        Location = "Ha Noi 123",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }, new Plate
        //    {
        //        Id = 3,
        //        OwnerId = 2,
        //        Number = "43-K1-12348",
        //        Location = "HCM123",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }
        //    );

        //    modelBuilder.Entity<Face>().HasData(new Face
        //    {
        //        Id = 1,
        //        OwnerId = 2,
        //        Location = "Nha Trang",
        //        Img = "img1",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }, new Face
        //    {
        //        Id = 2,
        //        OwnerId = 2,
        //        Location = "Quy Nhon",
        //        Img = "img1",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }, new Face
        //    {
        //        Id = 3,
        //        OwnerId = 1,
        //        Location = "Hue",
        //        Img = "img1",
        //        ModifyDate = DateTime.Now,
        //        LastFound = DateTime.Now,
        //        CreateAt = DateTime.Now
        //    }
        //    );
        //}
    }
}
