﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryApp1.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CheckOutDateAndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("CopyrightInfo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCheckedOut")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            CheckOutDateAndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CopyrightInfo = "© 1925 by F. Scott Fitzgerald",
                            IsCheckedOut = false,
                            Title = "The Great Gatsby",
                            Year = 1925
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            CheckOutDateAndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CopyrightInfo = "© 1960 by Harper Lee",
                            IsCheckedOut = false,
                            Title = "To Kill a Mockingbird",
                            Year = 1960
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Orwell",
                            CheckOutDateAndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CopyrightInfo = "© 1949 by George Orwell",
                            IsCheckedOut = false,
                            Title = "1984",
                            Year = 1949
                        },
                        new
                        {
                            Id = 4,
                            Author = "Herman Melville",
                            CheckOutDateAndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CopyrightInfo = "© 1851 by Herman Melville",
                            IsCheckedOut = false,
                            Title = "Moby Dick",
                            Year = 1851
                        },
                        new
                        {
                            Id = 5,
                            Author = "Suzanne Collins",
                            CheckOutDateAndTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CopyrightInfo = "© 2008 by Suzanne Collins",
                            IsCheckedOut = false,
                            Title = "The Hunger Games",
                            Year = 2008
                        });
                });

            modelBuilder.Entity("Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmailAddress = "john.doe@example.com",
                            Name = "John Doe"
                        },
                        new
                        {
                            Id = 2,
                            EmailAddress = "jane.smith@example.com",
                            Name = "Jane Smith"
                        },
                        new
                        {
                            Id = 3,
                            EmailAddress = "james.hammington@example.com",
                            Name = "James Hammington"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
