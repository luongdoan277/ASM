﻿// <auto-generated />
using System;
using ASM.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASM.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ASM.Models.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ASM.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CategoriesCategoryID")
                        .HasColumnType("bigint");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageProduct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.Property<long?>("SizesSizeID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductID");

                    b.HasIndex("CategoriesCategoryID");

                    b.HasIndex("SizesSizeID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ASM.Models.Size", b =>
                {
                    b.Property<long>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("SizeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeID");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("ASM.Models.Product", b =>
                {
                    b.HasOne("ASM.Models.Category", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoriesCategoryID");

                    b.HasOne("ASM.Models.Size", "Sizes")
                        .WithMany("Products")
                        .HasForeignKey("SizesSizeID");

                    b.Navigation("Categories");

                    b.Navigation("Sizes");
                });

            modelBuilder.Entity("ASM.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ASM.Models.Size", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}