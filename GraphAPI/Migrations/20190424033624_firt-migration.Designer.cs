﻿// <auto-generated />
using System;
using GraphAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraphAPI.Migrations
{
    [DbContext(typeof(GraphDbContext))]
    [Migration("20190424033624_firt-migration")]
    partial class firtmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GraphAPI.Models.Face", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Img");

                    b.Property<DateTime>("LastFound");

                    b.Property<string>("Location");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<long>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Faces");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7071),
                            Img = "img1",
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(6434),
                            Location = "Nha Trang",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(6028),
                            OwnerId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7619),
                            Img = "img1",
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7616),
                            Location = "Quy Nhon",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7612),
                            OwnerId = 2L
                        },
                        new
                        {
                            Id = 3L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7624),
                            Img = "img1",
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7623),
                            Location = "Hue",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(7623),
                            OwnerId = 1L
                        });
                });

            modelBuilder.Entity("GraphAPI.Models.Owner", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("CreateAt");

                    b.Property<string>("Email");

                    b.Property<DateTime>("LastFound");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Da Nang",
                            CreateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Liemnguyenx",
                            LastFound = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Liem's Plate",
                            PhoneNumber = "123456789"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Da Nang",
                            CreateAt = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Liemnguyenx",
                            LastFound = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Liem's Plate",
                            PhoneNumber = "123456789"
                        });
                });

            modelBuilder.Entity("GraphAPI.Models.Plate", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateAt");

                    b.Property<DateTime>("LastFound");

                    b.Property<string>("Location");

                    b.Property<DateTime>("ModifyDate");

                    b.Property<string>("Number");

                    b.Property<long>("OwnerId");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Plates");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3131),
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(2655),
                            Location = "Da Nang123",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 187, DateTimeKind.Local).AddTicks(4976),
                            Number = "43-K1-12346",
                            OwnerId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3588),
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3584),
                            Location = "Ha Noi 123",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3580),
                            Number = "43-K1-12347",
                            OwnerId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CreateAt = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3593),
                            LastFound = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3593),
                            Location = "HCM123",
                            ModifyDate = new DateTime(2019, 4, 24, 10, 36, 24, 188, DateTimeKind.Local).AddTicks(3592),
                            Number = "43-K1-12348",
                            OwnerId = 2L
                        });
                });

            modelBuilder.Entity("GraphAPI.Models.Face", b =>
                {
                    b.HasOne("GraphAPI.Models.Owner", "Owner")
                        .WithMany("Faces")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GraphAPI.Models.Plate", b =>
                {
                    b.HasOne("GraphAPI.Models.Owner", "Owner")
                        .WithMany("Plates")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}