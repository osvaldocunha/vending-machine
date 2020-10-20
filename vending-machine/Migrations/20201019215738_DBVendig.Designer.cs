﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vending_machine.Context;

namespace vending_machine.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201019215738_DBVendig")]
    partial class DBVendig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("vending_machine.Models.Drink", b =>
                {
                    b.Property<int>("DrinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(80) CHARACTER SET utf8mb4")
                        .HasMaxLength(80);

                    b.Property<decimal>("Price")
                        .HasColumnType("Decimal(8,1)");

                    b.Property<float>("Stock")
                        .HasColumnType("float");

                    b.HasKey("DrinkId");

                    b.ToTable("Drinks");
                });
#pragma warning restore 612, 618
        }
    }
}