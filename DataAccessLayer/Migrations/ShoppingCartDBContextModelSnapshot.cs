﻿// <auto-generated />
using System;
using DataAccessLayer.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ShoppingCartDBContext))]
    partial class ShoppingCartDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Model.Category", b =>
                {
                    b.Property<int>("CatergoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatergoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BilingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeleveryCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeliveryAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Customer")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("Payment")
                        .HasColumnType("int");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("Customer");

                    b.HasIndex("Order");

                    b.HasIndex("Payment");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DataAccessLayer.Model.OrderDetail", b =>
                {
                    b.Property<int>("OrderDtailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("Product")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<double>("discount")
                        .HasColumnType("float");

                    b.HasKey("OrderDtailId");

                    b.HasIndex("Order");

                    b.HasIndex("Product");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Payment", b =>
                {
                    b.Property<int>("PayamentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int?>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PayamentId");

                    b.HasIndex("Order");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Category")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("Category");

                    b.ToTable("products");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Order", b =>
                {
                    b.HasOne("DataAccessLayer.Model.Customer", "customers")
                        .WithMany("orders")
                        .HasForeignKey("Customer");

                    b.HasOne("DataAccessLayer.Model.Order", "orders")
                        .WithMany()
                        .HasForeignKey("Order");

                    b.HasOne("DataAccessLayer.Model.Payment", "Payments")
                        .WithMany()
                        .HasForeignKey("Payment");
                });

            modelBuilder.Entity("DataAccessLayer.Model.OrderDetail", b =>
                {
                    b.HasOne("DataAccessLayer.Model.Order", "orders")
                        .WithMany("orderdetails")
                        .HasForeignKey("Order");

                    b.HasOne("DataAccessLayer.Model.Product", "product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("Product");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Payment", b =>
                {
                    b.HasOne("DataAccessLayer.Model.Order", "order")
                        .WithMany()
                        .HasForeignKey("Order");
                });

            modelBuilder.Entity("DataAccessLayer.Model.Product", b =>
                {
                    b.HasOne("DataAccessLayer.Model.Category", "Categories")
                        .WithMany("products")
                        .HasForeignKey("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
