﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Storing;

namespace PizzaBox.Storing.Migrations
{
    [DbContext(typeof(PizzaBoxContext))]
    [Migration("20210119040500_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Property<long>("CrustID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CrustID");

                    b.ToTable("Crust");

                    b.HasData(
                        new
                        {
                            CrustID = 637466042997369968L,
                            Name = "Thin",
                            Price = 2.00m
                        },
                        new
                        {
                            CrustID = 637466042997370869L,
                            Name = "Thick",
                            Price = 3.00m
                        },
                        new
                        {
                            CrustID = 637466042997370876L,
                            Name = "Cheese-Stuffed",
                            Price = 4.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("StoreID")
                        .HasColumnType("bigint");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UserID")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.HasIndex("StoreID");

                    b.HasIndex("UserID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Property<long>("PizzaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long?>("CrustID")
                        .HasColumnType("bigint");

                    b.Property<bool>("HasOrder")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long?>("SizeID")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaID");

                    b.HasIndex("CrustID");

                    b.HasIndex("OrderID");

                    b.HasIndex("SizeID");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.Property<long>("PizzaID")
                        .HasColumnType("bigint");

                    b.Property<long>("ToppingID")
                        .HasColumnType("bigint");

                    b.HasKey("PizzaID", "ToppingID");

                    b.HasIndex("ToppingID");

                    b.ToTable("PizzaTopping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Property<long>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("SizeID");

                    b.ToTable("Size");

                    b.HasData(
                        new
                        {
                            SizeID = 637466042997371679L,
                            Name = "Medium",
                            Price = 12.00m
                        },
                        new
                        {
                            SizeID = 637466042997372517L,
                            Name = "Large",
                            Price = 15.00m
                        },
                        new
                        {
                            SizeID = 637466042997372526L,
                            Name = "X-Large",
                            Price = 18.00m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Property<long>("StoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreID");

                    b.ToTable("Store");

                    b.HasData(
                        new
                        {
                            StoreID = 1L,
                            Name = "Pizza Hut"
                        },
                        new
                        {
                            StoreID = 2L,
                            Name = "Little Caesers"
                        },
                        new
                        {
                            StoreID = 3L,
                            Name = "Dominoes"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Property<long>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ToppingID");

                    b.ToTable("Topping");

                    b.HasData(
                        new
                        {
                            ToppingID = 637466042997353000L,
                            Name = "Cheese",
                            Price = 0.99m
                        },
                        new
                        {
                            ToppingID = 637466042997368870L,
                            Name = "Pineapple",
                            Price = 1.50m
                        },
                        new
                        {
                            ToppingID = 637466042997368900L,
                            Name = "Ham",
                            Price = 1.99m
                        },
                        new
                        {
                            ToppingID = 637466042997368904L,
                            Name = "Pepperoni",
                            Price = 1.99m
                        },
                        new
                        {
                            ToppingID = 637466042997368906L,
                            Name = "Sausage",
                            Price = 1.99m
                        },
                        new
                        {
                            ToppingID = 637466042997368908L,
                            Name = "Sauce",
                            Price = 1.99m
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserID = 1L,
                            Name = "Lawrence"
                        });
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Store", "Store")
                        .WithMany("Orders")
                        .HasForeignKey("StoreID");

                    b.HasOne("PizzaBox.Domain.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserID");

                    b.Navigation("Store");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Crust", "Crust")
                        .WithMany("Pizzas")
                        .HasForeignKey("CrustID");

                    b.HasOne("PizzaBox.Domain.Models.Order", "Order")
                        .WithMany("Pizzas")
                        .HasForeignKey("OrderID");

                    b.HasOne("PizzaBox.Domain.Models.Size", "Size")
                        .WithMany("Pizzas")
                        .HasForeignKey("SizeID");

                    b.Navigation("Crust");

                    b.Navigation("Order");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.PizzaTopping", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Pizza", "Pizza")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("PizzaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzaBox.Domain.Models.Topping", "Topping")
                        .WithMany("PizzaToppings")
                        .HasForeignKey("ToppingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pizza");

                    b.Navigation("Topping");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Crust", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Order", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Pizza", b =>
                {
                    b.Navigation("PizzaToppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Size", b =>
                {
                    b.Navigation("Pizzas");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Store", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Topping", b =>
                {
                    b.Navigation("PizzaToppings");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
