﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCommerceConsole.Office.Context;

#nullable disable

namespace eCommerceConsole.Office.Migrations
{
    [DbContext(typeof(EcommerceOfficeContext))]
    [Migration("20250115193523_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCommerceConsole.Office.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Michael Johnson"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Emily Davis"
                        },
                        new
                        {
                            Id = 5,
                            Name = "William Brown"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Sophia Wilson"
                        },
                        new
                        {
                            Id = 7,
                            Name = "James Anderson"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Olivia Martinez"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Alexander Garcia"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Emma Thomas"
                        });
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.EmployeeClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmployeeClasses");
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.EmployeeSector", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("SectorId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("EmployeeId", "SectorId");

                    b.HasIndex("SectorId");

                    b.ToTable("EmployeeSectors");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            SectorId = 10,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 2,
                            SectorId = 9,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7395), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 3,
                            SectorId = 8,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7397), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 4,
                            SectorId = 7,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7399), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 5,
                            SectorId = 6,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7400), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 6,
                            SectorId = 5,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7402), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 7,
                            SectorId = 4,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7404), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 8,
                            SectorId = 3,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7406), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 9,
                            SectorId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7408), new TimeSpan(0, -3, 0, 0, 0))
                        },
                        new
                        {
                            EmployeeId = 10,
                            SectorId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2025, 1, 15, 16, 35, 23, 298, DateTimeKind.Unspecified).AddTicks(7409), new TimeSpan(0, -3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT Support"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Research and Development"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Customer Service"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Logistics"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Operations"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Legal"
                        });
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("EmployeeEmployeeClass", b =>
                {
                    b.Property<int>("EmployeeClassesId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeClassesId", "EmployeesId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("EmployeeEmployeeClass");
                });

            modelBuilder.Entity("EmployeeVehicle", b =>
                {
                    b.Property<int>("EmployeesId")
                        .HasColumnType("int");

                    b.Property<int>("VehiclesId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesId", "VehiclesId");

                    b.HasIndex("VehiclesId");

                    b.ToTable("EmployeeVehicle");
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.EmployeeSector", b =>
                {
                    b.HasOne("eCommerceConsole.Office.Models.Employee", "Employee")
                        .WithMany("EmployeeSectors")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceConsole.Office.Models.Sector", "Sector")
                        .WithMany("EmployeeSectors")
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Sector");
                });

            modelBuilder.Entity("EmployeeEmployeeClass", b =>
                {
                    b.HasOne("eCommerceConsole.Office.Models.EmployeeClass", null)
                        .WithMany()
                        .HasForeignKey("EmployeeClassesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceConsole.Office.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeVehicle", b =>
                {
                    b.HasOne("eCommerceConsole.Office.Models.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eCommerceConsole.Office.Models.Vehicle", null)
                        .WithMany()
                        .HasForeignKey("VehiclesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.Employee", b =>
                {
                    b.Navigation("EmployeeSectors");
                });

            modelBuilder.Entity("eCommerceConsole.Office.Models.Sector", b =>
                {
                    b.Navigation("EmployeeSectors");
                });
#pragma warning restore 612, 618
        }
    }
}
