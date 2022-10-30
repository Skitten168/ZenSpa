﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPages.Models;

namespace RazorPages.Migrations
{
    [DbContext(typeof(SpaContext))]
    [Migration("20221030202718_lientAndAnnotations")]
    partial class lientAndAnnotations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPages.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("First Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("Last Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnName("Zipcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Email = "flo@schmoe.net",
                            FirstName = "Flo",
                            LastName = "Schmoe",
                            Password = "FloSchmoe1234*",
                            Username = "Flo"
                        },
                        new
                        {
                            ID = 2,
                            Email = "jojo@schmoe.net",
                            FirstName = "Jo",
                            LastName = "Schmoe",
                            Password = "JoJoSchmoe1234?",
                            Username = "JoJo"
                        },
                        new
                        {
                            ID = 3,
                            Email = "truly@schmoe.net",
                            FirstName = "Truly",
                            LastName = "Schmoe",
                            Password = "Truly9876**",
                            Username = "Truly"
                        });
                });

            modelBuilder.Entity("RazorPages.Models.ClientService", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("ServicesID");

                    b.ToTable("ClientServices");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ClientID = 1,
                            Date = new DateTime(2022, 10, 30, 16, 27, 17, 937, DateTimeKind.Local).AddTicks(7849),
                            ServicesID = 1
                        },
                        new
                        {
                            ID = 2,
                            ClientID = 2,
                            Date = new DateTime(2022, 10, 30, 16, 27, 17, 939, DateTimeKind.Local).AddTicks(1969),
                            ServicesID = 7
                        },
                        new
                        {
                            ID = 3,
                            ClientID = 1,
                            Date = new DateTime(2022, 10, 30, 16, 27, 17, 939, DateTimeKind.Local).AddTicks(2008),
                            ServicesID = 5
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServicesID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ServicesID");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ContactEmail = "wilma@flint.net",
                            Name = "Wilma Flintstone",
                            ServicesID = 1
                        },
                        new
                        {
                            ID = 2,
                            ContactEmail = "Barn@rubb.com",
                            Name = "Barney Rubble",
                            ServicesID = 7
                        },
                        new
                        {
                            ID = 3,
                            ContactEmail = "betts@rubb.com",
                            Name = "Betty Rubble",
                            ServicesID = 5
                        });
                });

            modelBuilder.Entity("RazorPages.Models.Services", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Classification")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Classification = "Full",
                            Fee = 450.0,
                            Name = "Full-Day Treatment Package"
                        },
                        new
                        {
                            ID = 2,
                            Classification = "Half",
                            Fee = 300.0,
                            Name = "Half-Day Treatment Package"
                        },
                        new
                        {
                            ID = 3,
                            Classification = "Two",
                            Fee = 225.0,
                            Name = "Two-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 4,
                            Classification = "One",
                            Fee = 100.0,
                            Name = "One-Hour Treatment Package"
                        },
                        new
                        {
                            ID = 5,
                            Classification = "Other",
                            Fee = 200.0,
                            Name = "Custom Treatment Package"
                        },
                        new
                        {
                            ID = 6,
                            Classification = "Cut",
                            Fee = 45.0,
                            Name = "Haircut or Trim"
                        },
                        new
                        {
                            ID = 7,
                            Classification = "Color",
                            Fee = 100.0,
                            Name = "Full Foil Color"
                        });
                });

            modelBuilder.Entity("RazorPages.Models.ClientService", b =>
                {
                    b.HasOne("RazorPages.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RazorPages.Models.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RazorPages.Models.Contact", b =>
                {
                    b.HasOne("RazorPages.Models.Services", "Services")
                        .WithMany()
                        .HasForeignKey("ServicesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
