﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240421074422_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Domain.Incubator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumePasare")
                        .HasColumnType("TEXT");

                    b.Property<bool>("StareBec")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("TempCurenta")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TempOptima")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TempSetata")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ZiFinal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ZiIncepere")
                        .HasColumnType("TEXT");

                    b.Property<int>("ZileFormare")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Incubatoare");
                });

            modelBuilder.Entity("Domain.LogIncubator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataOra")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TempCurenta")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TempSetata")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LogIncubatoare");
                });
#pragma warning restore 612, 618
        }
    }
}