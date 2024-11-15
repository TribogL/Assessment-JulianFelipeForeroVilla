﻿// <auto-generated />
using System;
using Assessment_JulianFelipeForeroVilla.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assessment_JulianFelipeForeroVilla.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241115173357_CreateTableSpecialty")]
    partial class CreateTableSpecialty
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Assessment_JulianFelipeForeroVilla.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("last_name");

                    b.Property<int>("Office")
                        .HasColumnType("int")
                        .HasColumnName("office");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("password");

                    b.Property<int>("SpecialtyId")
                        .HasColumnType("int")
                        .HasColumnName("specialty_id");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Status");

                    b.Property<int>("specialty_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("specialty_id");

                    b.ToTable("doctors", t =>
                        {
                            t.Property("specialty_id")
                                .HasColumnName("specialty_id1");
                        });
                });

            modelBuilder.Entity("Assessment_JulianFelipeForeroVilla.Models.Mourner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("address");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("first_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("last_name");

                    b.Property<string>("Nationality")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nationality");

                    b.Property<string>("Occupation")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("occupation");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("password");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("phone_number");

                    b.HasKey("Id");

                    b.ToTable("mourners");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "4292 Weissnat Vista",
                            Age = 90,
                            DateOfBirth = new DateTime(1988, 5, 11, 8, 22, 6, 279, DateTimeKind.Local).AddTicks(9466),
                            Email = "Shad54@yahoo.com",
                            FirstName = "Lambert",
                            Gender = "Male",
                            LastName = "Bernier",
                            Password = "heeaeooa",
                            PhoneNumber = "1-438-253-5052 x961"
                        },
                        new
                        {
                            Id = 2,
                            Address = "7322 Albertha Corners",
                            Age = 95,
                            DateOfBirth = new DateTime(1994, 3, 25, 13, 17, 13, 920, DateTimeKind.Local).AddTicks(2785),
                            Email = "Micaela_Kunde@gmail.com",
                            FirstName = "Jerod",
                            Gender = "Female",
                            LastName = "Brown",
                            Password = "seooaeoa",
                            PhoneNumber = "(274) 918-1246 x5249"
                        },
                        new
                        {
                            Id = 3,
                            Address = "13628 Raynor Villages",
                            Age = 32,
                            DateOfBirth = new DateTime(1963, 6, 3, 16, 42, 8, 230, DateTimeKind.Local).AddTicks(4060),
                            Email = "Griffin.Swift48@hotmail.com",
                            FirstName = "Katelyn",
                            Gender = "Male",
                            LastName = "Lockman",
                            Password = "vuaaaoae",
                            PhoneNumber = "1-212-459-4751"
                        },
                        new
                        {
                            Id = 4,
                            Address = "525 Myles View",
                            Age = 83,
                            DateOfBirth = new DateTime(1952, 7, 31, 9, 44, 47, 936, DateTimeKind.Local).AddTicks(7262),
                            Email = "Jacquelyn10@yahoo.com",
                            FirstName = "Mohammed",
                            Gender = "Female",
                            LastName = "Berge",
                            Password = "geuaeuea",
                            PhoneNumber = "275.793.2473 x30899"
                        },
                        new
                        {
                            Id = 5,
                            Address = "2670 Donato Creek",
                            Age = 81,
                            DateOfBirth = new DateTime(1953, 6, 8, 8, 2, 13, 120, DateTimeKind.Local).AddTicks(8101),
                            Email = "Frederick4@yahoo.com",
                            FirstName = "Pierce",
                            Gender = "Male",
                            LastName = "Upton",
                            Password = "meiuoeoa",
                            PhoneNumber = "882-513-0495"
                        },
                        new
                        {
                            Id = 6,
                            Address = "75911 Dameon Route",
                            Age = 79,
                            DateOfBirth = new DateTime(1937, 7, 28, 15, 42, 29, 754, DateTimeKind.Local).AddTicks(1446),
                            Email = "Irving_Mann@gmail.com",
                            FirstName = "Marilie",
                            Gender = "Other",
                            LastName = "Weimann",
                            Password = "siiooaou",
                            PhoneNumber = "1-990-458-5381 x4536"
                        },
                        new
                        {
                            Id = 7,
                            Address = "12501 Champlin Terrace",
                            Age = 65,
                            DateOfBirth = new DateTime(1940, 7, 13, 22, 19, 29, 399, DateTimeKind.Local).AddTicks(199),
                            Email = "Arthur39@hotmail.com",
                            FirstName = "Jalen",
                            Gender = "Female",
                            LastName = "Maggio",
                            Password = "feueeeoe",
                            PhoneNumber = "212.799.8407 x839"
                        },
                        new
                        {
                            Id = 8,
                            Address = "653 Addie Views",
                            Age = 77,
                            DateOfBirth = new DateTime(1978, 7, 8, 8, 59, 50, 766, DateTimeKind.Local).AddTicks(470),
                            Email = "Samantha41@yahoo.com",
                            FirstName = "Ima",
                            Gender = "Female",
                            LastName = "Runte",
                            Password = "peeuuooa",
                            PhoneNumber = "1-278-813-8626"
                        },
                        new
                        {
                            Id = 9,
                            Address = "510 Eryn Ports",
                            Age = 47,
                            DateOfBirth = new DateTime(1935, 7, 20, 0, 4, 54, 797, DateTimeKind.Local).AddTicks(3707),
                            Email = "Van_Morar@hotmail.com",
                            FirstName = "Bulah",
                            Gender = "Male",
                            LastName = "Windler",
                            Password = "veiuuoee",
                            PhoneNumber = "1-595-814-1065"
                        },
                        new
                        {
                            Id = 10,
                            Address = "34561 Benedict Rapid",
                            Age = 69,
                            DateOfBirth = new DateTime(1984, 4, 8, 1, 40, 37, 840, DateTimeKind.Local).AddTicks(5376),
                            Email = "Osvaldo_Champlin@gmail.com",
                            FirstName = "Chanel",
                            Gender = "Female",
                            LastName = "Reilly",
                            Password = "laaauaio",
                            PhoneNumber = "734-280-2842"
                        });
                });

            modelBuilder.Entity("Assessment_JulianFelipeForeroVilla.Models.Specialty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("specialties");
                });

            modelBuilder.Entity("Assessment_JulianFelipeForeroVilla.Models.Doctor", b =>
                {
                    b.HasOne("Assessment_JulianFelipeForeroVilla.Models.Specialty", "Specialty")
                        .WithMany()
                        .HasForeignKey("specialty_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specialty");
                });
#pragma warning restore 612, 618
        }
    }
}
