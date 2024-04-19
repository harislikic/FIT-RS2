﻿// <auto-generated />
using System;
using AutoTrader.Services.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AutoTrader.Services.Migrations
{
    [DbContext(typeof(AutoTraderContext))]
    [Migration("20240419132908_brandEdit")]
    partial class brandEdit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AutoTrader.Services.AutomobileAd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdditionalEquipmentId")
                        .HasColumnType("int");

                    b.Property<int>("CarBrandId")
                        .HasColumnType("int");

                    b.Property<int>("CarCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("CarModelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOFadd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FeaturedExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FuelTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit");

                    b.Property<bool>("IsFeatured")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Last_Big_Service")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Last_Small_Service")
                        .HasColumnType("datetime2");

                    b.Property<string>("Milage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<bool>("Registered")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RegistrationExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransmissionTypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("VehicleConditionId")
                        .HasColumnType("int");

                    b.Property<int>("ViewsCount")
                        .HasColumnType("int");

                    b.Property<string>("YearOfManufacture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdditionalEquipmentId");

                    b.HasIndex("CarBrandId");

                    b.HasIndex("CarCategoryId");

                    b.HasIndex("CarModelId");

                    b.HasIndex("FuelTypeId");

                    b.HasIndex("TransmissionTypeId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleConditionId");

                    b.ToTable("AutomobileAds");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.AdImage", b =>
                {
                    b.Property<int>("AdImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdImageId"));

                    b.Property<int>("AutomobileAdId")
                        .HasColumnType("int");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdImageId");

                    b.HasIndex("AutomobileAdId");

                    b.ToTable("AdImages");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.AdditionalEquipment", b =>
                {
                    b.Property<int>("AdditionalEquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdditionalEquipmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdditionalEquipmentId");

                    b.ToTable("AdditionalEquipments");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Canton", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cantons");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.CarBrand", b =>
                {
                    b.Property<int>("CarBrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarBrandId"));

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarBrandId");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.CarCategory", b =>
                {
                    b.Property<int>("CarCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarCategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarCategoryId");

                    b.ToTable("carCategories");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.CarModel", b =>
                {
                    b.Property<int>("CarModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarModelId"));

                    b.Property<int>("CarBrandId")
                        .HasColumnType("int");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarModelId");

                    b.HasIndex("CarBrandId");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CantonId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CantonId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.FuelType", b =>
                {
                    b.Property<int>("FuelTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuelTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuelTypeId");

                    b.ToTable("FuelTypes");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AutomobileAdId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AutomobileAdId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.TransmissionType", b =>
                {
                    b.Property<int>("TransmissionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransmissionTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TransmissionTypeId");

                    b.ToTable("TransmissionTypes");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.VehicleCondition", b =>
                {
                    b.Property<int>("VehicleConditionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehicleConditionId"));

                    b.Property<string>("ConditionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleConditionId");

                    b.ToTable("VehicleConditions");
                });

            modelBuilder.Entity("AutoTrader.Services.AutomobileAd", b =>
                {
                    b.HasOne("AutoTrader.Services.Database.AdditionalEquipment", "AdditionalEquipment")
                        .WithMany()
                        .HasForeignKey("AdditionalEquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.CarCategory", "CarCategory")
                        .WithMany()
                        .HasForeignKey("CarCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.CarModel", "CarModel")
                        .WithMany()
                        .HasForeignKey("CarModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.FuelType", "FuelType")
                        .WithMany()
                        .HasForeignKey("FuelTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.TransmissionType", "TransmissionType")
                        .WithMany()
                        .HasForeignKey("TransmissionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AutoTrader.Services.Database.VehicleCondition", "VehicleCondition")
                        .WithMany()
                        .HasForeignKey("VehicleConditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdditionalEquipment");

                    b.Navigation("CarBrand");

                    b.Navigation("CarCategory");

                    b.Navigation("CarModel");

                    b.Navigation("FuelType");

                    b.Navigation("TransmissionType");

                    b.Navigation("User");

                    b.Navigation("VehicleCondition");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.AdImage", b =>
                {
                    b.HasOne("AutoTrader.Services.AutomobileAd", "AutomobileAd")
                        .WithMany("Images")
                        .HasForeignKey("AutomobileAdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AutomobileAd");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.CarModel", b =>
                {
                    b.HasOne("AutoTrader.Services.Database.CarBrand", "CarBrand")
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.City", b =>
                {
                    b.HasOne("AutoTrader.Services.Database.Canton", "Canton")
                        .WithMany("Cities")
                        .HasForeignKey("CantonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canton");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Comment", b =>
                {
                    b.HasOne("AutoTrader.Services.AutomobileAd", "AutomobileAd")
                        .WithMany()
                        .HasForeignKey("AutomobileAdId");

                    b.HasOne("AutoTrader.Services.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("AutomobileAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Reservation", b =>
                {
                    b.HasOne("AutoTrader.Services.AutomobileAd", "AutomobileAd")
                        .WithMany()
                        .HasForeignKey("AutomobileAdId");

                    b.HasOne("AutoTrader.Services.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("AutomobileAd");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.User", b =>
                {
                    b.HasOne("AutoTrader.Services.Database.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("AutoTrader.Services.AutomobileAd", b =>
                {
                    b.Navigation("Images");
                });

            modelBuilder.Entity("AutoTrader.Services.Database.Canton", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
