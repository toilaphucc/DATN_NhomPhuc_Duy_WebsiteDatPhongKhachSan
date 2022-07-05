﻿// <auto-generated />
using System;
using DATN_WebDatPhongKhachSan.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DATN_WebDatPhongKhachSan.Migrations
{
    [DbContext(typeof(DatPhongKhachSanContext))]
    partial class DatPhongKhachSanContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Customer", b =>
                {
                    b.Property<Guid>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Month")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.HasIndex("UserID");

                    b.ToTable("Custommers");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Favorite", b =>
                {
                    b.Property<Guid>("FavoriteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("OwnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FavoriteID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OwnerID");

                    b.ToTable("Favorites");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Invoice", b =>
                {
                    b.Property<Guid>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountPeople")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OwnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PaymentAccountID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RentalTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoomID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("InvoiceID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OwnerID");

                    b.HasIndex("PaymentAccountID");

                    b.HasIndex("RentalTypeID");

                    b.HasIndex("RoomID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Owner", b =>
                {
                    b.Property<Guid>("OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HotelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHotel")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ward")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerID");

                    b.HasIndex("UserID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.PaymentAccount", b =>
                {
                    b.Property<Guid>("PaymentAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustommerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentAccountID");

                    b.HasIndex("CustomerID");

                    b.ToTable("PaymentAccounts");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.RentalType", b =>
                {
                    b.Property<Guid>("RentalTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("RentalTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentalTypeID");

                    b.ToTable("RentalTypes");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Room", b =>
                {
                    b.Property<Guid>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountRoom")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OwnerID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("RoomCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoomTypeID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoomID");

                    b.HasIndex("OwnerID");

                    b.HasIndex("RoomTypeID");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.RoomType", b =>
                {
                    b.Property<Guid>("RoomTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoomTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomTypeID");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Tag", b =>
                {
                    b.Property<Guid>("TagID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("TagName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TagID");

                    b.ToTable("Utilitiess");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.User", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Customer", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.User", "User")
                        .WithMany("Customers")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Favorite", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Owner", null)
                        .WithMany("Favorites")
                        .HasForeignKey("OwnerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Invoice", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Owner", "Owner")
                        .WithMany("Invoices")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.PaymentAccount", "PaymentAccount")
                        .WithMany("Invoices")
                        .HasForeignKey("PaymentAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.RentalType", "RentalType")
                        .WithMany("Invoices")
                        .HasForeignKey("RentalTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Room", "Room")
                        .WithMany("Invoices")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Owner");

                    b.Navigation("PaymentAccount");

                    b.Navigation("RentalType");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Owner", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.User", "User")
                        .WithMany("Owners")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.PaymentAccount", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Customer", "Customer")
                        .WithMany("PaymentAccounts")
                        .HasForeignKey("CustomerID");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Room", b =>
                {
                    b.HasOne("DATN_WebDatPhongKhachSan.Models.Owner", "Owner")
                        .WithMany("Rooms")
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DATN_WebDatPhongKhachSan.Models.RoomType", "RoomType")
                        .WithMany("Rooms")
                        .HasForeignKey("RoomTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("RoomType");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("PaymentAccounts");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Owner", b =>
                {
                    b.Navigation("Favorites");

                    b.Navigation("Invoices");

                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.PaymentAccount", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.RentalType", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.Room", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.RoomType", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("DATN_WebDatPhongKhachSan.Models.User", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("Owners");
                });
#pragma warning restore 612, 618
        }
    }
}
