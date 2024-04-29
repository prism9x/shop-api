﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prism.Infrastructure.Persistence;

#nullable disable

namespace Prism.Infrastructure.Migrations
{
    [DbContext(typeof(PrismDbContext))]
    [Migration("20240429081234_InitDb")]
    partial class InitDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Prism.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Danh mục tất cả các loại giường",
                            IsActive = true,
                            Name = "Giường"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Danh mục tất cả các loại tủ",
                            IsActive = true,
                            Name = "Tủ"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Danh mục tất cả các loại sập",
                            IsActive = true,
                            Name = "Sập"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Danh mục tất cả các loại ban thờ",
                            IsActive = true,
                            Name = "Ban Thờ"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Danh mục tất cả các loại vòng tay",
                            IsActive = true,
                            Name = "Vòng tay"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Danh mục tất cả các loại tượng gỗ",
                            IsActive = true,
                            Name = "Tượng gỗ"
                        });
                });

            modelBuilder.Entity("Prism.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2001),
                            Description = "Sập trơn",
                            IsActive = true,
                            Name = "Sập trơn",
                            Price = 30000000.0,
                            Stock = 10
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2018),
                            Description = "Sập ngũ phúc",
                            IsActive = true,
                            Name = "Sập ngũ phúc",
                            Price = 32000000.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2020),
                            Description = "Sập ba bông",
                            IsActive = true,
                            Name = "Sập ba bông",
                            Price = 33500000.0,
                            Stock = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2022),
                            Description = "Tủ 3 buồng 4 cánh",
                            IsActive = true,
                            Name = "Tủ 3 buồng 4 cánh",
                            Price = 22300000.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2024),
                            Description = "Tủ 2 buồng",
                            IsActive = true,
                            Name = "Tủ 2 buồng",
                            Price = 17500000.0,
                            Stock = 2
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2025),
                            Description = "Tủ chè cánh cong",
                            IsActive = true,
                            Name = "Tủ chè cánh cong",
                            Price = 16499000.0,
                            Stock = 5
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2027),
                            Description = "Tủ chè cánh thẳng",
                            IsActive = true,
                            Name = "Tủ chè cánh thẳng",
                            Price = 15499000.0,
                            Stock = 6
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2028),
                            Description = "Tủ chè khảm trai",
                            IsActive = true,
                            Name = "Tủ chè khảm trai",
                            Price = 55500000.0,
                            Stock = 2
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2030),
                            Description = "Vòng tay trầm",
                            IsActive = true,
                            Name = "Vòng tay trầm",
                            Price = 3500000.0,
                            Stock = 50
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2033),
                            Description = "Vòng tay sưa đỏ",
                            IsActive = true,
                            Name = "Vòng tay sưa đỏ",
                            Price = 1200000.0,
                            Stock = 25
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2034),
                            Description = "Tượng gỗ quan vũ",
                            IsActive = true,
                            Name = "Tượng gỗ quan vũ",
                            Price = 5600000.0,
                            Stock = 8
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 6,
                            CreatedDate = new DateTime(2024, 4, 29, 15, 12, 34, 38, DateTimeKind.Local).AddTicks(2036),
                            Description = "Tượng tam đa",
                            IsActive = true,
                            Name = "Tượng tam đa",
                            Price = 12999000.0,
                            Stock = 4
                        });
                });

            modelBuilder.Entity("Prism.Domain.Entities.Product", b =>
                {
                    b.HasOne("Prism.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Prism.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
