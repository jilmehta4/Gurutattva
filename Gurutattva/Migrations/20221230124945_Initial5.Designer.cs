﻿// <auto-generated />
using System;
using Gurutattva.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gurutattva.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221230124945_Initial5")]
    partial class Initial5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Gurutattva.Models.Shibir", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakEmail1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakEmail2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakName1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakPhoneNumber1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SanchalakPhoneNumber2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShibirName")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TalukaId")
                        .HasColumnType("int");

                    b.Property<string>("TalukaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shibirs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Capacity = 50,
                            CityId = 0,
                            CityName = "Waterloo",
                            CountryId = 0,
                            DistrictId = 0,
                            DistrictName = "Kitchener",
                            EmailAddress = "jilmehta52@gmaIL.com",
                            EndDate = new DateTime(2022, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EndTime = new DateTime(2022, 12, 30, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Jil",
                            LastName = "Mehta",
                            Latitude = 43.464300000000001,
                            Longitude = 80.520399999999995,
                            PhoneNumber = "6478321825",
                            PinCode = "364340",
                            SanchalakEmail1 = "SanchalakEmail1",
                            SanchalakEmail2 = "SanchalakEmail2",
                            SanchalakName1 = "Sanchalak1",
                            SanchalakName2 = "SanchalakName2",
                            SanchalakPhoneNumber1 = "3456542312",
                            SanchalakPhoneNumber2 = "3454637234",
                            ShibirName = 0,
                            StartDate = new DateTime(2022, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartTime = new DateTime(2022, 12, 30, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            StateId = 0,
                            StateName = "Ontario",
                            StreetAddress1 = "802-131 University Ave",
                            StreetAddress2 = "Waterloo, Canada",
                            TalukaId = 0,
                            TalukaName = "Waterloo"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
