﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Trucking.Entities.Models;

namespace Trucking.Entities.Migrations
{
    [DbContext(typeof(MyDbContext.TruckingDbContext))]
    [Migration("20190507194915_AddColumnToFreight3")]
    partial class AddColumnToFreight3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Trucking.Entities.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine");

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Freight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FreightType");

                    b.Property<int?>("FromAddressId");

                    b.Property<string>("Image");

                    b.Property<int?>("ToAddressId");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("FromAddressId");

                    b.HasIndex("ToAddressId");

                    b.ToTable("Freights");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CurrentCity");

                    b.Property<int?>("DriverId");

                    b.Property<string>("Manufacturer");

                    b.Property<long>("Mileage");

                    b.Property<string>("Model");

                    b.Property<int?>("OwnerId");

                    b.Property<int>("WeightCapacityInTones");

                    b.HasKey("Id");

                    b.HasIndex("DriverId");

                    b.HasIndex("OwnerId");

                    b.ToTable("Trucks");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Freight", b =>
                {
                    b.HasOne("Trucking.Entities.Models.Address", "FromAddress")
                        .WithMany()
                        .HasForeignKey("FromAddressId");

                    b.HasOne("Trucking.Entities.Models.Address", "ToAddress")
                        .WithMany()
                        .HasForeignKey("ToAddressId");
                });

            modelBuilder.Entity("Trucking.Entities.Models.Truck", b =>
                {
                    b.HasOne("Trucking.Entities.Models.Driver", "Driver")
                        .WithMany()
                        .HasForeignKey("DriverId");

                    b.HasOne("Trucking.Entities.Models.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");
                });
#pragma warning restore 612, 618
        }
    }
}
