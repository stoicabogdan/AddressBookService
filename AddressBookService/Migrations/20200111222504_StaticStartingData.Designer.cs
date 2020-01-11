﻿// <auto-generated />
using System;
using AddressBookService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AddressBookService.Migrations
{
    [DbContext(typeof(AddressBookDbContext))]
    [Migration("20200111222504_StaticStartingData")]
    partial class StaticStartingData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AddressBookService.Model.Database.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressBookId")
                        .IsUnique();

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("74babd01-e17c-4804-9396-843682aeac7c"),
                            AddressBookId = new Guid("384497a7-4e3b-4f91-b248-0fd250ef0b69"),
                            City = "London",
                            Country = "England",
                            StreetAddress = "Test St 1"
                        },
                        new
                        {
                            Id = new Guid("8a92a38e-5e85-488d-b20d-1d34bd8037f2"),
                            AddressBookId = new Guid("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"),
                            City = "london",
                            Country = "England",
                            StreetAddress = "Test St 2"
                        },
                        new
                        {
                            Id = new Guid("b0a02e8e-fb78-41d1-b35d-5658a20fc31c"),
                            AddressBookId = new Guid("515f5a89-0002-437c-9cdd-a55bd31769c7"),
                            City = "New York",
                            Country = "USA",
                            StreetAddress = "Test St 3"
                        },
                        new
                        {
                            Id = new Guid("826d8e11-ee0d-4e99-934f-5e742ef28164"),
                            AddressBookId = new Guid("1eada19b-7b8c-4b50-97a0-0322db5fc969"),
                            City = "New york",
                            Country = "USA",
                            StreetAddress = "Test St 4"
                        },
                        new
                        {
                            Id = new Guid("b9791e7f-4d85-437f-a0ca-cdfec73d199e"),
                            AddressBookId = new Guid("c1aefccf-c057-4a20-a407-8b007801a9fe"),
                            City = "London",
                            Country = "England",
                            StreetAddress = "Test St 4"
                        },
                        new
                        {
                            Id = new Guid("52dbd833-fc25-482d-9ac4-73c1962074fa"),
                            AddressBookId = new Guid("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"),
                            City = "boston",
                            Country = "USA",
                            StreetAddress = "1765 Long street"
                        });
                });

            modelBuilder.Entity("AddressBookService.Model.Database.AddressBook", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AddressBooks");

                    b.HasData(
                        new
                        {
                            Id = new Guid("384497a7-4e3b-4f91-b248-0fd250ef0b69"),
                            FirstName = "John",
                            LastName = "Smith"
                        },
                        new
                        {
                            Id = new Guid("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"),
                            FirstName = "Jane",
                            LastName = "Doe"
                        },
                        new
                        {
                            Id = new Guid("515f5a89-0002-437c-9cdd-a55bd31769c7"),
                            FirstName = "Tim",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = new Guid("1eada19b-7b8c-4b50-97a0-0322db5fc969"),
                            FirstName = "David",
                            LastName = "Jones"
                        },
                        new
                        {
                            Id = new Guid("c1aefccf-c057-4a20-a407-8b007801a9fe"),
                            FirstName = "Any",
                            LastName = "Body"
                        },
                        new
                        {
                            Id = new Guid("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"),
                            FirstName = "Any",
                            LastName = "Body"
                        });
                });

            modelBuilder.Entity("AddressBookService.Model.Database.Address", b =>
                {
                    b.HasOne("AddressBookService.Model.Database.AddressBook", "AddressBook")
                        .WithOne("Address")
                        .HasForeignKey("AddressBookService.Model.Database.Address", "AddressBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}