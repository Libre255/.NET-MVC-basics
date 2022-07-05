﻿// <auto-generated />
using System;
using MVC_uppgift.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_uppgift.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220705213512_AddDataToDB")]
    partial class AddDataToDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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

                    b.HasData(
                        new
                        {
                            Id = "8ff2636a-a320-452b-9272-41ee0e170acb",
                            ConcurrencyStamp = "b0c88ce5-1303-46d2-93df-07414e6283b6",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "fc6a5061-6c49-454d-a41f-4916d8c1167c",
                            ConcurrencyStamp = "949d5e1a-79e2-4e31-8c70-2de66987c2df",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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

                    b.HasData(
                        new
                        {
                            UserId = "8d9bc048-56bb-42a9-a289-6876463caba7",
                            RoleId = "8ff2636a-a320-452b-9272-41ee0e170acb"
                        },
                        new
                        {
                            UserId = "7da86268-c305-47c4-961b-7a63f3db4001",
                            RoleId = "fc6a5061-6c49-454d-a41f-4916d8c1167c"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MVC_uppgift.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Birthdate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

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

                    b.HasData(
                        new
                        {
                            Id = "8d9bc048-56bb-42a9-a289-6876463caba7",
                            AccessFailedCount = 0,
                            Birthdate = "02/02/02",
                            ConcurrencyStamp = "03537586-799a-4e57-bc62-88cad336edc1",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Adminsson",
                            LastName = "Headersson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDXn3RvIk2yTUsAPIlFHcbnT5CsLDxwOUdl4HVGp9N24FlWNx9x0p0oaqcmui+2gKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "506bd598-938d-48d0-a783-240b8b4e4771",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        },
                        new
                        {
                            Id = "7da86268-c305-47c4-961b-7a63f3db4001",
                            AccessFailedCount = 0,
                            Birthdate = "02/02/02",
                            ConcurrencyStamp = "10612c88-2680-4019-b786-182b7eb12d2e",
                            Email = "user@r.r",
                            EmailConfirmed = false,
                            FirstName = "usersson",
                            LastName = "headerusersson",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@R.R",
                            NormalizedUserName = "USER@R.R",
                            PasswordHash = "AQAAAAEAACcQAAAAEFmDOU06VDEknEHmmetwLcMr3rMAixHJvhRmZbudhCxRqYdOMGN0IApIAcnLoKkKdw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "25e0ec5c-c0c7-4e11-a225-9aba5b9ca1e5",
                            TwoFactorEnabled = false,
                            UserName = "user@r.r"
                        });
                });

            modelBuilder.Entity("MVC_uppgift.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryId = 1,
                            Name = "Kyoto"
                        },
                        new
                        {
                            Id = 4,
                            CountryId = 1,
                            Name = "Hiroshima"
                        },
                        new
                        {
                            Id = 2,
                            CountryId = 2,
                            Name = "Paris"
                        },
                        new
                        {
                            Id = 3,
                            CountryId = 3,
                            Name = "Gävle"
                        });
                });

            modelBuilder.Entity("MVC_uppgift.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 2,
                            Name = "France"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sweden"
                        });
                });

            modelBuilder.Entity("MVC_uppgift.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Japanese"
                        },
                        new
                        {
                            Id = 2,
                            Name = "French"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Swedish"
                        });
                });

            modelBuilder.Entity("MVC_uppgift.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Peoples");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Tony montana",
                            PhoneNumber = 24523421
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Name = "Werrever Tommorow",
                            PhoneNumber = 345363234
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            Name = "Lu Xiaojun",
                            PhoneNumber = 43523413
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            Name = "Goku Sayaying",
                            PhoneNumber = 452423
                        });
                });

            modelBuilder.Entity("MVC_uppgift.Models.PeopleLanguage", b =>
                {
                    b.Property<int>("PeopleId")
                        .HasColumnType("int");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.HasKey("PeopleId", "LanguageId");

                    b.HasIndex("LanguageId");

                    b.ToTable("PeopleLanguages");

                    b.HasData(
                        new
                        {
                            PeopleId = 3,
                            LanguageId = 1
                        },
                        new
                        {
                            PeopleId = 4,
                            LanguageId = 1
                        },
                        new
                        {
                            PeopleId = 2,
                            LanguageId = 2
                        },
                        new
                        {
                            PeopleId = 1,
                            LanguageId = 3
                        },
                        new
                        {
                            PeopleId = 1,
                            LanguageId = 1
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
                    b.HasOne("MVC_uppgift.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MVC_uppgift.Data.ApplicationUser", null)
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

                    b.HasOne("MVC_uppgift.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MVC_uppgift.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_uppgift.Models.City", b =>
                {
                    b.HasOne("MVC_uppgift.Models.Country", null)
                        .WithMany("ListOfCities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_uppgift.Models.People", b =>
                {
                    b.HasOne("MVC_uppgift.Models.City", "City")
                        .WithMany("ListOfPeople")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MVC_uppgift.Models.PeopleLanguage", b =>
                {
                    b.HasOne("MVC_uppgift.Models.Language", "Language")
                        .WithMany("PeopleLanguagues")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_uppgift.Models.People", "People")
                        .WithMany("PeopleLanguagues")
                        .HasForeignKey("PeopleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("People");
                });

            modelBuilder.Entity("MVC_uppgift.Models.City", b =>
                {
                    b.Navigation("ListOfPeople");
                });

            modelBuilder.Entity("MVC_uppgift.Models.Country", b =>
                {
                    b.Navigation("ListOfCities");
                });

            modelBuilder.Entity("MVC_uppgift.Models.Language", b =>
                {
                    b.Navigation("PeopleLanguagues");
                });

            modelBuilder.Entity("MVC_uppgift.Models.People", b =>
                {
                    b.Navigation("PeopleLanguagues");
                });
#pragma warning restore 612, 618
        }
    }
}