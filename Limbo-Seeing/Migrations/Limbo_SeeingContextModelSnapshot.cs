﻿// <auto-generated />
using System;
using Limbo_Seeing.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Limbo_Seeing.Migrations
{
    [DbContext(typeof(Limbo_SeeingContext))]
    partial class Limbo_SeeingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Limbo_Seeing.Models.Activiteiten", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aantal")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Eind_Activiteit")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Gebruiker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start_Activiteit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tijdslot_grote")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Gebruiker_Id");

                    b.ToTable("Activiteiten");
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Gebruiker", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Achternaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Geboortendatum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Geslacht")
                        .HasColumnType("int");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<bool>("UserActive")
                        .HasColumnType("bit");

                    b.Property<string>("Voornaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gebruikers");
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Resevering", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Activiteit_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Gebruiker_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Tijdslot_Eind")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Tijdslot_Start")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Activiteit_Id");

                    b.HasIndex("Gebruiker_Id");

                    b.ToTable("Reseverings");
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Sensors", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Battery")
                        .HasColumnType("int");

                    b.Property<string>("Locatie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SensorType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Sensoren");
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Sensors_Acties", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Aantal_bewegingen")
                        .HasColumnType("int");

                    b.Property<Guid>("Sensor_Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Snelheid")
                        .HasColumnType("int");

                    b.Property<int>("Soort_beweging")
                        .HasColumnType("int");

                    b.Property<DateTime>("Tijd")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Sensor_Id");

                    b.ToTable("Sensors_Acties");
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Activiteiten", b =>
                {
                    b.HasOne("Limbo_Seeing.Models.Gebruiker", "Gebruiker")
                        .WithMany("Activiteitens")
                        .HasForeignKey("Gebruiker_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Resevering", b =>
                {
                    b.HasOne("Limbo_Seeing.Models.Activiteiten", "Activiteit")
                        .WithMany("Reseverings")
                        .HasForeignKey("Activiteit_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Limbo_Seeing.Models.Gebruiker", "Gebruiker")
                        .WithMany("Reseverings")
                        .HasForeignKey("Gebruiker_Id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Limbo_Seeing.Models.Sensors_Acties", b =>
                {
                    b.HasOne("Limbo_Seeing.Models.Sensors", "Sensors")
                        .WithMany("Sensors_Acties")
                        .HasForeignKey("Sensor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
