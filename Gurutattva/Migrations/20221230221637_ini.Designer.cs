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
    [Migration("20221230221637_ini")]
    partial class ini
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

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistrictName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Latitude")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Longitude")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TalukaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Shibirs");
                });
#pragma warning restore 612, 618
        }
    }
}
