﻿// <auto-generated />
using System;
using GenExRB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GenExRB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210831182057_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GenExRB.Models.CustomData.FeatureData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<bool>("Value1")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("FeatureData");
                });

            modelBuilder.Entity("GenExRB.Models.CustomData.FeatureOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("FeatureOptions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "CCTV"
                        },
                        new
                        {
                            Id = 2,
                            Key = "Clubhouse"
                        });
                });

            modelBuilder.Entity("GenExRB.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brgy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyRef")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyRef")
                        .IsUnique();

                    b.ToTable("Location");
                });

            modelBuilder.Entity("GenExRB.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("GenExRB.Models.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bedroom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("CarPark")
                        .HasColumnType("bit");

                    b.Property<int?>("Category1")
                        .HasColumnType("int");

                    b.Property<int?>("Category2")
                        .HasColumnType("int");

                    b.Property<int?>("Category3")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("District")
                        .HasColumnType("int");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("FloorArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Long")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ReservationFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ToiletAndBath")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("GenExRB.Models.CustomData.FeatureData", b =>
                {
                    b.HasOne("GenExRB.Models.Property", "Property")
                        .WithMany("FeatureData")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenExRB.Models.Location", b =>
                {
                    b.HasOne("GenExRB.Models.Property", "Property")
                        .WithOne("Location")
                        .HasForeignKey("GenExRB.Models.Location", "PropertyRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenExRB.Models.Photo", b =>
                {
                    b.HasOne("GenExRB.Models.Property", "Property")
                        .WithMany("Photos")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
