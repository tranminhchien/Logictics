﻿// <auto-generated />
using System;
using Logictics.DAL.EFContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Logictics.DAL.Migrations
{
    [DbContext(typeof(LogicticsDbContext))]
    [Migration("20210313164625_Add_Order")]
    partial class Add_Order
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Logictics.Entity.Models.OrderDetailTbl", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("float");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("float");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCategoryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderDetailTbl");
                });

            modelBuilder.Entity("Logictics.Entity.Models.OrderTbl", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("float");

                    b.Property<string>("CustomerPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("ModifyData")
                        .HasColumnType("float");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Store")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalWeight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTbl");
                });

            modelBuilder.Entity("Logictics.Entity.Models.UserAdmin", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double?>("CreateDate")
                        .HasColumnType("float");

                    b.Property<double?>("ModifyDate")
                        .HasColumnType("float");

                    b.Property<string>("PassWord")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.Property<string>("Role")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Status")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UserName")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("UserAdmin");

                    b.HasData(
                        new
                        {
                            Id = "69bd714f-9576-45ba-b5b7-f00649be00de",
                            PassWord = "7c4a8d9ca3762af61e59520943dc26494f8941b",
                            Role = "ADMIN",
                            Status = "ACTIVE",
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "69bd714f-9576-45ba-b5b7-f00649be00df",
                            CreateDate = 1.0,
                            PassWord = "7c4a8d9ca3762af61e59520943dc26494f8941b",
                            Role = "CLIENT",
                            Status = "ACTIVE",
                            UserName = "ChienClient"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
