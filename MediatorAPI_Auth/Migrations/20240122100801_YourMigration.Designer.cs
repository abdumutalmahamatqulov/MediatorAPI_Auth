﻿// <auto-generated />
using System;
using MediatorAPI_Auth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MediatorAPI_Auth.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240122100801_YourMigration")]
    partial class YourMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MediatorAPI_Auth.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Discraption")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discraption = "10 mashq",
                            TaskName = "Math",
                            Title = "Hosila"
                        },
                        new
                        {
                            Id = 2,
                            Discraption = "15 Mashq",
                            TaskName = "Bialogiya",
                            Title = "tabiat yaralishi "
                        },
                        new
                        {
                            Id = 3,
                            Discraption = "18 mashq",
                            TaskName = "Ona-tili",
                            Title = "sher"
                        },
                        new
                        {
                            Id = 4,
                            Discraption = "11 Mavzu",
                            TaskName = "Vatantuyg'usi",
                            Title = "vatan bordir "
                        },
                        new
                        {
                            Id = 5,
                            Discraption = "56 Mavzu",
                            TaskName = "adabiyot",
                            Title = "O'tkir Hoshimov"
                        });
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("StudentAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StudentAge")
                        .HasColumnType("integer");

                    b.Property<string>("StudentEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StudentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StudentAddress = "Zangiota",
                            StudentAge = 10,
                            StudentEmail = "qobil@gmail.com",
                            StudentName = "Qobil"
                        },
                        new
                        {
                            Id = 2,
                            StudentAddress = "Yangiyo'l",
                            StudentAge = 18,
                            StudentEmail = "qodir@gmail.com",
                            StudentName = "Qodir"
                        },
                        new
                        {
                            Id = 3,
                            StudentAddress = "Chinoz",
                            StudentAge = 12,
                            StudentEmail = "qaxor@gmail.com",
                            StudentName = "Qaxor"
                        },
                        new
                        {
                            Id = 4,
                            StudentAddress = "Chilonzor",
                            StudentAge = 15,
                            StudentEmail = "qodirali@gmail.com",
                            StudentName = "Qodirali"
                        },
                        new
                        {
                            Id = 5,
                            StudentAddress = "Vodiy",
                            StudentAge = 8,
                            StudentEmail = "talos@gmail.com",
                            StudentName = "Talos"
                        },
                        new
                        {
                            Id = 6,
                            StudentAddress = "Toshkent",
                            StudentAge = 16,
                            StudentEmail = "temur@gmail.com",
                            StudentName = "Temur"
                        },
                        new
                        {
                            Id = 7,
                            StudentAddress = "Toshkent",
                            StudentAge = 14,
                            StudentEmail = "turon@gmail.com",
                            StudentName = "Turon"
                        },
                        new
                        {
                            Id = 8,
                            StudentAddress = "Toshkent",
                            StudentAge = 13,
                            StudentEmail = "tarichili@gmail.com",
                            StudentName = "Tarichili"
                        });
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.StudentExercises", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentExercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExerciseId = 1,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            ExerciseId = 2,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 3,
                            ExerciseId = 3,
                            StudentId = 1
                        },
                        new
                        {
                            Id = 4,
                            ExerciseId = 1,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 5,
                            ExerciseId = 2,
                            StudentId = 2
                        },
                        new
                        {
                            Id = 6,
                            ExerciseId = 3,
                            StudentId = 2
                        });
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Science")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Level = "Senior",
                            Name = "Bachuayee",
                            Science = "Math"
                        },
                        new
                        {
                            Id = 2,
                            Level = "Middle",
                            Name = "Chaluba",
                            Science = "Kimyo"
                        },
                        new
                        {
                            Id = 3,
                            Level = "Jenior",
                            Name = "Chukveza",
                            Science = "Informatika"
                        },
                        new
                        {
                            Id = 4,
                            Level = "Good",
                            Name = "chupo Moting",
                            Science = "bialogiya"
                        },
                        new
                        {
                            Id = 5,
                            Level = "Strong Jenior",
                            Name = "Salah",
                            Science = "Biosfera"
                        },
                        new
                        {
                            Id = 6,
                            Level = "Strong Middle",
                            Name = "Qodirali",
                            Science = "Rus Tili"
                        },
                        new
                        {
                            Id = 7,
                            Level = "Academic",
                            Name = "Son",
                            Science = "Ona Tili"
                        },
                        new
                        {
                            Id = 8,
                            Level = "Well",
                            Name = "Sinyorita",
                            Science = "Geografiya"
                        },
                        new
                        {
                            Id = 9,
                            Level = "Jenior",
                            Name = "Vasvasagin",
                            Science = "Fizika"
                        },
                        new
                        {
                            Id = 10,
                            Level = "Jenior",
                            Name = "Jalil",
                            Science = "Math"
                        });
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.TeacherStudents", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherStudents");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            StudentId = 1,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            StudentId = 2,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 3,
                            StudentId = 3,
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 4,
                            StudentId = 1,
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 5,
                            StudentId = 2,
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 6,
                            StudentId = 3,
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 7,
                            StudentId = 1,
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 8,
                            StudentId = 2,
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 9,
                            StudentId = 3,
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "",
                            Name = ""
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.StudentExercises", b =>
                {
                    b.HasOne("MediatorAPI_Auth.Models.Exercise", "Exercise")
                        .WithMany()
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediatorAPI_Auth.Models.Student", "Student")
                        .WithMany("StudentExercises")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.TeacherStudents", b =>
                {
                    b.HasOne("MediatorAPI_Auth.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MediatorAPI_Auth.Models.Teacher", "Teacher")
                        .WithMany("TeacherStudents")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
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
                    b.HasOne("MediatorAPI_Auth.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MediatorAPI_Auth.Models.User", null)
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

                    b.HasOne("MediatorAPI_Auth.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MediatorAPI_Auth.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.Student", b =>
                {
                    b.Navigation("StudentExercises");
                });

            modelBuilder.Entity("MediatorAPI_Auth.Models.Teacher", b =>
                {
                    b.Navigation("TeacherStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
