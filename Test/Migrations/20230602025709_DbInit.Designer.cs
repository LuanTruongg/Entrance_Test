﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Test.Models;

#nullable disable

namespace Test.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20230602025709_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Test.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Test.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<int>("Born")
                        .HasColumnType("int");

                    b.Property<int?>("Died")
                        .HasColumnType("int");

                    b.Property<bool>("Female")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.HasKey("AuthorId");

                    b.ToTable("Author");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            Born = 1957,
                            Female = false,
                            Name = "Steve Harvey",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 2,
                            Born = 1864,
                            Died = 1912,
                            Female = false,
                            Name = "James Allen",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 3,
                            Born = 1945,
                            Female = true,
                            Name = "Robin Norwood",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 4,
                            Born = 1982,
                            Female = false,
                            Name = "Ramit Sethi",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 5,
                            Born = 1948,
                            Female = true,
                            Name = "Melody Beattie",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 6,
                            Born = 1888,
                            Died = 1955,
                            Female = true,
                            Name = "Dale Carnegie",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 7,
                            Born = 1940,
                            Female = false,
                            Name = "Wayne Dyer",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 8,
                            Born = 1937,
                            Female = false,
                            Name = "John T. Molloy",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 10,
                            Born = 1934,
                            Died = 2006,
                            Female = false,
                            Name = "Allen Carr",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 12,
                            Born = 1959,
                            Female = false,
                            Name = "Robert Greene",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 13,
                            Born = 1949,
                            Female = true,
                            Name = "Wendy Kaminer",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 14,
                            Born = 1927,
                            Died = 1987,
                            Female = false,
                            Name = "David Schwartz",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 15,
                            Born = 1964,
                            Female = false,
                            Name = "Robin Sharma",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 16,
                            Born = 1898,
                            Died = 1993,
                            Female = false,
                            Name = "Norman Vincent Peale",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 17,
                            Born = 1899,
                            Died = 1975,
                            Female = false,
                            Name = "Maxwell Maltz",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 18,
                            Born = 1951,
                            Female = true,
                            Name = "Rhonda Byrne",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 19,
                            Born = 1932,
                            Died = 2012,
                            Female = false,
                            Name = "Stephen Covey",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 20,
                            Born = 1883,
                            Died = 1970,
                            Female = false,
                            Name = "Napoleon Hill",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 21,
                            Born = 1960,
                            Female = false,
                            Name = "Anthony Robbins",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 22,
                            Born = 1926,
                            Died = 2017,
                            Female = true,
                            Name = "Louise Hay",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 23,
                            Born = 1926,
                            Died = 1949,
                            Female = false,
                            Name = "Charles F.Haanel",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 24,
                            Born = 1948,
                            Female = false,
                            Name = "Eckhart Tolle",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 25,
                            Born = 1950,
                            Female = true,
                            Name = "Diane Muldrow",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 26,
                            Born = 1957,
                            Female = false,
                            Name = "David Gillespie",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 27,
                            Born = 1968,
                            Female = false,
                            Name = "Burra Venkatesham",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 28,
                            Born = 1955,
                            Female = false,
                            Name = "Dr.Walter Doyle Staples",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 29,
                            Born = 1925,
                            Died = 2021,
                            Female = false,
                            Name = "Wahiduddin Khan",
                            age = 0
                        },
                        new
                        {
                            AuthorId = 30,
                            Born = 1947,
                            Female = false,
                            Name = "Paulo Coelho",
                            age = 0
                        });
                });

            modelBuilder.Entity("Test.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            AuthorName = "Steve Harvey",
                            Price = 20m,
                            PublishYear = 2009,
                            Rating = 1,
                            Title = "Act like a Lady, Think like a Man",
                            Topic = "relationship"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 2,
                            AuthorName = "James Allen",
                            Price = 50m,
                            PublishYear = 1902,
                            Rating = 2,
                            Title = "As a Man Thinketh",
                            Topic = "positive thinking"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 3,
                            AuthorName = "Robin Norwood",
                            Price = 15.4m,
                            PublishYear = 1985,
                            Rating = 3,
                            Title = "Women Who Love Too Much",
                            Topic = "relationship"
                        },
                        new
                        {
                            Id = 4,
                            AuthorId = 4,
                            AuthorName = "Ramit Sethi",
                            Price = 20m,
                            PublishYear = 2009,
                            Rating = 4,
                            Title = "I Will Teach You To Be Rich",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 5,
                            AuthorId = 5,
                            AuthorName = "Melody Beattie",
                            Price = 32m,
                            PublishYear = 1986,
                            Rating = 2,
                            Title = "Codependent No More",
                            Topic = "relationship"
                        },
                        new
                        {
                            Id = 6,
                            AuthorId = 6,
                            AuthorName = "Dale Carnegie",
                            Price = 50m,
                            PublishYear = 1948,
                            Rating = 4,
                            Title = "How to Stop Worrying and Start Living",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 7,
                            AuthorId = 7,
                            AuthorName = "Wayne Dyer",
                            Price = 24m,
                            PublishYear = 1976,
                            Rating = 5,
                            Title = "Your Erroneous Zones",
                            Topic = "health"
                        },
                        new
                        {
                            Id = 8,
                            AuthorId = 8,
                            AuthorName = "John T. Molloy",
                            Price = 54.2m,
                            PublishYear = 1975,
                            Rating = 3,
                            Title = "Dress for Success",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 9,
                            AuthorId = 10,
                            AuthorName = "Allen Carr",
                            Price = 45.6m,
                            PublishYear = 2006,
                            Rating = 2,
                            Title = "The Easy Way to Stop Smoking",
                            Topic = "health"
                        },
                        new
                        {
                            Id = 10,
                            AuthorId = 6,
                            AuthorName = "Dale Carnegie",
                            Price = 10.2m,
                            PublishYear = 1936,
                            Rating = 4,
                            Title = "How to Win Friends and Influence People",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 11,
                            AuthorId = 10,
                            AuthorName = "Allen Carr",
                            Price = 20.5m,
                            PublishYear = 1985,
                            Rating = 2,
                            Title = "The 48 Laws of Power",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 12,
                            AuthorId = 12,
                            AuthorName = "Robert Greene",
                            Price = 10.05m,
                            PublishYear = 1998,
                            Rating = 3,
                            Title = "I'm Dysfunctional, You're Dysfunctional",
                            Topic = "anti-self-help"
                        },
                        new
                        {
                            Id = 13,
                            AuthorId = 12,
                            AuthorName = "Robert Greene",
                            Price = 100m,
                            PublishYear = 1992,
                            Rating = 5,
                            Title = "The Magic of Thinking Big",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 14,
                            AuthorId = 13,
                            AuthorName = "Wendy Kaminer",
                            Price = 39.55m,
                            PublishYear = 1959,
                            Rating = 3,
                            Title = "The Monk Who Sold His Ferrari",
                            Topic = "health"
                        },
                        new
                        {
                            Id = 15,
                            AuthorId = 14,
                            AuthorName = "David Schwartz",
                            Price = 12.34m,
                            PublishYear = 1952,
                            Rating = 5,
                            Title = "The Power of Positive Thinking",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 16,
                            AuthorId = 15,
                            AuthorName = "Robin Sharma",
                            Price = 12.34m,
                            PublishYear = 1960,
                            Rating = 2,
                            Title = "Psycho-Cybernetics",
                            Topic = "self image"
                        },
                        new
                        {
                            Id = 17,
                            AuthorId = 16,
                            AuthorName = "Norman Vincent Peale",
                            Price = 20.5m,
                            PublishYear = 2006,
                            Rating = 4,
                            Title = "The Secret",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 18,
                            AuthorId = 17,
                            AuthorName = "Maxwell Maltz",
                            Price = 50.3m,
                            PublishYear = 1989,
                            Rating = 1,
                            Title = "The Seven Habits of Highly Effective People",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 19,
                            AuthorId = 18,
                            AuthorName = "Rhonda Byrne",
                            Price = 25.5m,
                            PublishYear = 1937,
                            Rating = 5,
                            Title = "Think and Grow Rich",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 20,
                            AuthorId = 19,
                            AuthorName = "Stephen Covey",
                            Price = 20.5m,
                            PublishYear = 1986,
                            Rating = 5,
                            Title = "Unlimited Power",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 21,
                            AuthorId = 20,
                            AuthorName = "Napoleon Hill",
                            Price = 100m,
                            PublishYear = 1984,
                            Rating = 4,
                            Title = "You Can Heal Your Life",
                            Topic = "health"
                        },
                        new
                        {
                            Id = 22,
                            AuthorId = 21,
                            AuthorName = "Anthony Robbins",
                            Price = 69.6m,
                            PublishYear = 1916,
                            Rating = 1,
                            Title = "The Master Key System",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 23,
                            AuthorId = 22,
                            AuthorName = "Louise Hay",
                            Price = 45.56m,
                            PublishYear = 1997,
                            Rating = 4,
                            Title = "The Power of Now",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 24,
                            AuthorId = 18,
                            AuthorName = "Rhonda Byrne",
                            Price = 100.05m,
                            PublishYear = 1930,
                            Rating = 5,
                            Title = "The Magic Ladder To Success",
                            Topic = ""
                        },
                        new
                        {
                            Id = 25,
                            AuthorId = 18,
                            AuthorName = "Rhonda Byrne",
                            Price = 32.45m,
                            PublishYear = 2011,
                            Rating = 3,
                            Title = "Outwitting the Devil",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 26,
                            AuthorId = 25,
                            AuthorName = "Rhonda Byrne",
                            Price = 20.6m,
                            PublishYear = 2019,
                            Rating = 4,
                            Title = "Selfie Of Success",
                            Topic = "success"
                        },
                        new
                        {
                            Id = 27,
                            AuthorId = 26,
                            AuthorName = "Rhonda Byrne",
                            Price = 20.5m,
                            PublishYear = 1991,
                            Rating = 3,
                            Title = "Think Like a Winner!",
                            Topic = "optimism"
                        },
                        new
                        {
                            Id = 28,
                            AuthorId = 27,
                            AuthorName = "Burra Venkatesham",
                            Price = 14.3m,
                            PublishYear = 1987,
                            Rating = 5,
                            Title = "Raaz-e-Hayat",
                            Topic = "optimism"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Test.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Test.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Test.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Test.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Test.Models.Book", b =>
                {
                    b.HasOne("Test.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });
#pragma warning restore 612, 618
        }
    }
}
