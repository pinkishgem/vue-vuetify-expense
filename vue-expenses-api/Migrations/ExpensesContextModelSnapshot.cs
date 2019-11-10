﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using vue_expenses_api.Infrastructure;

namespace vue_expenses_api.Migrations
{
    [DbContext(typeof(ExpensesContext))]
    partial class ExpensesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("vue_expenses_api.Domain.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Comments")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Expenses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            Date = new DateTime(2019, 11, 10, 12, 58, 54, 75, DateTimeKind.Local).AddTicks(4918),
                            TypeId = 1,
                            UpdatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            UserId = 1,
                            Value = 10m
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Budget")
                        .HasColumnType("TEXT");

                    b.Property<string>("ColourHex")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Budget = 0m,
                            CreatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            Name = "General Expenses",
                            UpdatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ExpenseTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            Name = "Credit Card",
                            UpdatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            UserId = 1
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Hash")
                        .HasColumnType("BLOB");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("Salt")
                        .HasColumnType("BLOB");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266),
                            Email = "foo@bar.com",
                            FirstName = "John",
                            FullName = "John Doe",
                            Hash = new byte[] { 145, 136, 159, 166, 243, 39, 106, 138, 133, 92, 168, 246, 218, 50, 200, 243, 190, 118, 122, 159, 227, 140, 109, 169, 24, 195, 20, 71, 128, 25, 139, 154, 155, 1, 116, 135, 187, 153, 111, 16, 241, 147, 238, 28, 78, 28, 241, 58, 249, 252, 153, 106, 163, 254, 43, 193, 142, 114, 44, 48, 252, 182, 242, 230 },
                            LastName = "Doe",
                            Salt = new byte[] { 130, 78, 115, 116, 61, 159, 217, 74, 185, 223, 171, 127, 229, 87, 102, 221 },
                            UpdatedAt = new DateTime(2019, 11, 10, 12, 58, 54, 67, DateTimeKind.Local).AddTicks(2266)
                        });
                });

            modelBuilder.Entity("vue_expenses_api.Domain.Expense", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.ExpenseCategory", "Category")
                        .WithMany("Expenses")
                        .HasForeignKey("CategoryId");

                    b.HasOne("vue_expenses_api.Domain.ExpenseType", "Type")
                        .WithMany("Expenses")
                        .HasForeignKey("TypeId");

                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseCategory", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("vue_expenses_api.Domain.ExpenseType", b =>
                {
                    b.HasOne("vue_expenses_api.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
