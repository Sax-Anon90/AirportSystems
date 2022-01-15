﻿// <auto-generated />
using System;
using FlightManagment.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightManagment.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220115032045_OptimizeFlightTblMaxStringlengths")]
    partial class OptimizeFlightTblMaxStringlengths
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FlightManagment.Domain.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("ConstructionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConstructionDate = new DateTime(2014, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 1,
                            Name = "Split"
                        },
                        new
                        {
                            Id = 2,
                            ConstructionDate = new DateTime(2012, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 2,
                            Name = "Palermo"
                        },
                        new
                        {
                            Id = 3,
                            ConstructionDate = new DateTime(2017, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 3,
                            Name = "Frankfurt"
                        },
                        new
                        {
                            Id = 4,
                            ConstructionDate = new DateTime(2018, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 4,
                            Name = "Ljubljana"
                        },
                        new
                        {
                            Id = 5,
                            ConstructionDate = new DateTime(2013, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 5,
                            Name = "Graz"
                        },
                        new
                        {
                            Id = 6,
                            ConstructionDate = new DateTime(2017, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CountryId = 6,
                            Name = "Warsaw"
                        });
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Croatia"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Slovenia"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Austria"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Poland"
                        });
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AirportId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Carrier")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("FlightDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("FlightTime")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("AirportId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Airport", b =>
                {
                    b.HasOne("FlightManagment.Domain.Models.Country", "Country")
                        .WithMany("Airports")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Flight", b =>
                {
                    b.HasOne("FlightManagment.Domain.Models.Airport", "Airport")
                        .WithMany("Flights")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airport");
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Airport", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("FlightManagment.Domain.Models.Country", b =>
                {
                    b.Navigation("Airports");
                });
#pragma warning restore 612, 618
        }
    }
}
