﻿// <auto-generated />
using System;
using EfCoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreDemo.Migrations
{
    [DbContext(typeof(InvoiceDbContext))]
    partial class InvoiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreDemo.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<decimal>("Amount")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)")
                        .HasColumnName("ContactName");

                    b.Property<string>("Description")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("Description");

                    b.Property<DateTimeOffset>("DueDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("DueDate");

                    b.Property<DateTimeOffset>("InvoiceDate")
                        .HasColumnType("datetimeoffset")
                        .HasColumnName("InvoiceDate");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("varchar(32)")
                        .HasColumnName("InvoiceNumber");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("Status");

                    b.HasKey("Id");

                    b.ToTable("Invoices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("1ca43af4-bd53-4f00-9987-3141a4eee1cd"),
                            Amount = 100m,
                            ContactName = "Iron Man",
                            Description = "Invoice for the first month",
                            DueDate = new DateTimeOffset(new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceDate = new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceNumber = "INV-001",
                            Status = "AwaitPayment"
                        },
                        new
                        {
                            Id = new Guid("2e5d9ec5-b863-4c25-b233-9156d154e8a4"),
                            Amount = 200m,
                            ContactName = "Captain America",
                            Description = "Invoice for the first month",
                            DueDate = new DateTimeOffset(new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceDate = new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceNumber = "INV-002",
                            Status = "AwaitPayment"
                        },
                        new
                        {
                            Id = new Guid("798e87ed-1686-438f-ac6d-04af9f7e02a2"),
                            Amount = 300m,
                            ContactName = "Thor",
                            Description = "Invoice for the first month",
                            DueDate = new DateTimeOffset(new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceDate = new DateTimeOffset(new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            InvoiceNumber = "INV-003",
                            Status = "Draft"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
