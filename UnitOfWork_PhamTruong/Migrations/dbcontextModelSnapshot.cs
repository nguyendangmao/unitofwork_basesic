﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UnitOfWork_PhamTruong.Entities;

#nullable disable

namespace UnitOfWork_PhamTruong.Migrations
{
    [DbContext(typeof(dbcontext))]
    partial class dbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UnitOfWork_PhamTruong.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "abc",
                            Price = 123m
                        },
                        new
                        {
                            Id = 2,
                            Name = "tr",
                            Price = 123m
                        },
                        new
                        {
                            Id = 3,
                            Name = "dsd",
                            Price = 123m
                        },
                        new
                        {
                            Id = 4,
                            Name = "sds",
                            Price = 123m
                        },
                        new
                        {
                            Id = 5,
                            Name = "ds",
                            Price = 123m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
