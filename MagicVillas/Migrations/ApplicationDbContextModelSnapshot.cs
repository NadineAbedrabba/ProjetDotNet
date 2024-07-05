﻿// <auto-generated />
using System;
using MagicVillas.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagicVillas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagicVilla_VillaAPI.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1143),
                            Description = "This is the royal villa",
                            ImageUrl = "http://via.placeholder.com/400x300.png?text=Royal+Villa",
                            Name = "Royal villa",
                            Occupancy = 0,
                            Price = 100000,
                            Rate = 4.5,
                            Sqft = 400,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1192),
                            Description = "A beautiful villa with an ocean view",
                            ImageUrl = "http://via.placeholder.com/400x300.png?text=Ocean+View+Villa",
                            Name = "Ocean View Villa",
                            Occupancy = 0,
                            Price = 150000,
                            Rate = 4.7999999999999998,
                            Sqft = 550,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1195),
                            Description = "A serene villa in the mountains",
                            ImageUrl = "http://via.placeholder.com/400x300.png?text=Mountain+Retreat+Villa",
                            Name = "Mountain Retreat Villa",
                            Occupancy = 0,
                            Price = 200000,
                            Rate = 4.7000000000000002,
                            Sqft = 600,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1198),
                            Description = "A modern villa in the city center",
                            ImageUrl = "http://via.placeholder.com/400x300.png?text=City+Lights+Villa",
                            Name = "City Lights Villa",
                            Occupancy = 0,
                            Price = 120000,
                            Rate = 4.5999999999999996,
                            Sqft = 450,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 7, 4, 13, 33, 59, 860, DateTimeKind.Local).AddTicks(1202),
                            Description = "A charming villa in the countryside",
                            ImageUrl = "http://via.placeholder.com/400x300.png?text=Countryside+Villa",
                            Name = "Countryside Villa",
                            Occupancy = 0,
                            Price = 110000,
                            Rate = 4.9000000000000004,
                            Sqft = 500,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}