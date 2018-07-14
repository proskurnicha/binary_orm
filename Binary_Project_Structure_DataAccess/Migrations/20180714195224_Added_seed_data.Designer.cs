﻿// <auto-generated />
using System;
using Binary_Project_Structure_DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Binary_Project_Structure_DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180714195224_Added_seed_data")]
    partial class Added_seed_data
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AircraftName")
                        .IsRequired();

                    b.Property<DateTime>("DateRelease");

                    b.Property<TimeSpan>("Lifetime");

                    b.Property<int>("TypeAircraftId")
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.HasIndex("TypeAircraftId");

                    b.ToTable("Aircraft");

                    b.HasData(
                        new { Id = 1, AircraftName = "Star", DateRelease = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Lifetime = new TimeSpan(0, 0, 0, 0, 0), TypeAircraftId = 1 },
                        new { Id = 2, AircraftName = "Cometa", DateRelease = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Lifetime = new TimeSpan(0, 0, 0, 0, 0), TypeAircraftId = 2 }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Crew", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PilotId")
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.HasIndex("PilotId");

                    b.ToTable("Crew");

                    b.HasData(
                        new { Id = 1, PilotId = 1 },
                        new { Id = 2, PilotId = 1 },
                        new { Id = 3, PilotId = 1 }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Departure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasMaxLength(3);

                    b.Property<int>("CrewId")
                        .HasMaxLength(3);

                    b.Property<DateTime>("DepartureTime");

                    b.Property<int>("FlightId")
                        .HasMaxLength(3);

                    b.HasKey("Id");

                    b.HasIndex("AircraftId");

                    b.HasIndex("CrewId");

                    b.HasIndex("FlightId");

                    b.ToTable("Departure");

                    b.HasData(
                        new { Id = 1, AircraftId = 1, CrewId = 1, DepartureTime = new DateTime(2018, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), FlightId = 1 },
                        new { Id = 2, AircraftId = 2, CrewId = 2, DepartureTime = new DateTime(2018, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), FlightId = 2 },
                        new { Id = 3, AircraftId = 1, CrewId = 3, DepartureTime = new DateTime(2018, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), FlightId = 3 }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArrivalPoint")
                        .IsRequired();

                    b.Property<TimeSpan>("ArrivalTime");

                    b.Property<string>("DeparturePoint")
                        .IsRequired();

                    b.Property<TimeSpan>("DepartureTime");

                    b.HasKey("Id");

                    b.ToTable("Flight");

                    b.HasData(
                        new { Id = 1, ArrivalPoint = "Berlin", ArrivalTime = new TimeSpan(0, 10, 29, 0, 0), DeparturePoint = "Kiev", DepartureTime = new TimeSpan(0, 4, 46, 0, 0) },
                        new { Id = 2, ArrivalPoint = "Riga", ArrivalTime = new TimeSpan(0, 8, 5, 0, 0), DeparturePoint = "Kiev", DepartureTime = new TimeSpan(0, 11, 30, 0, 0) },
                        new { Id = 3, ArrivalPoint = "Brussels", ArrivalTime = new TimeSpan(0, 3, 15, 0, 0), DeparturePoint = "Kiev", DepartureTime = new TimeSpan(0, 5, 48, 0, 0) }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBirth");

                    b.Property<int>("Experience");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Pilot");

                    b.HasData(
                        new { Id = 1, DateBirth = new DateTime(1990, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Experience = 5, Name = "Ivan", Surname = "Ivanov" },
                        new { Id = 2, DateBirth = new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Experience = 10, Name = "Petr", Surname = "Petrov" },
                        new { Id = 3, DateBirth = new DateTime(1993, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Experience = 7, Name = "Sidr", Surname = "Sidorov" }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Stewardess", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrewId");

                    b.Property<DateTime>("DateBirth");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("CrewId");

                    b.ToTable("Stewardess");

                    b.HasData(
                        new { Id = 1, DateBirth = new DateTime(1990, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Natali", Surname = "Sidorova" },
                        new { Id = 2, DateBirth = new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Kate", Surname = "Petrova" },
                        new { Id = 3, DateBirth = new DateTime(1993, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Tanya", Surname = "Durova" }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlightId")
                        .HasMaxLength(3);

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.HasIndex("FlightId");

                    b.ToTable("Ticket");

                    b.HasData(
                        new { Id = 1, FlightId = 1, Price = 200.0 },
                        new { Id = 2, FlightId = 2, Price = 300.0 },
                        new { Id = 3, FlightId = 3, Price = 400.0 }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.TypeAircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(3)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftModel");

                    b.Property<int>("CarryingCapacity");

                    b.Property<int>("NumberPlaces");

                    b.HasKey("Id");

                    b.ToTable("TypeAircraft");

                    b.HasData(
                        new { Id = 1, AircraftModel = 7, CarryingCapacity = 240000, NumberPlaces = 797 },
                        new { Id = 2, AircraftModel = 9, CarryingCapacity = 164000, NumberPlaces = 183 }
                    );
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Aircraft", b =>
                {
                    b.HasOne("Binary_Project_Structure_DataAccess.Models.TypeAircraft", "TypeAircraft")
                        .WithMany()
                        .HasForeignKey("TypeAircraftId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Crew", b =>
                {
                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Pilot", "Pilot")
                        .WithMany()
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Departure", b =>
                {
                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Aircraft", "Aircraft")
                        .WithMany()
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Crew", "Crew")
                        .WithMany()
                        .HasForeignKey("CrewId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Flight", "Flight")
                        .WithMany()
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Stewardess", b =>
                {
                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Crew")
                        .WithMany("Stewardesses")
                        .HasForeignKey("CrewId");
                });

            modelBuilder.Entity("Binary_Project_Structure_DataAccess.Models.Ticket", b =>
                {
                    b.HasOne("Binary_Project_Structure_DataAccess.Models.Flight", "Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
