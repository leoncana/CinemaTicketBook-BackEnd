﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie.Data;

#nullable disable

namespace Movie.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240424001436_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movie.Models.Admin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Movie.Models.Booking", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("MovieId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ShowDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShowTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Movie.Models.Celeb", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("CelebImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelebName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelebRole")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CelebType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Celebs");
                });

            modelBuilder.Entity("Movie.Models.MovieCeleb", b =>
                {
                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.Property<long>("CelebId")
                        .HasColumnType("bigint");

                    b.Property<long?>("MovieeId")
                        .HasColumnType("bigint");

                    b.HasKey("MovieId", "CelebId");

                    b.HasIndex("CelebId");

                    b.HasIndex("MovieeId");

                    b.ToTable("MovieCeleb");
                });

            modelBuilder.Entity("Movie.Models.Moviee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("LandscapeImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PortraitImgUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Movie.Models.MovieSchedule", b =>
                {
                    b.Property<long>("MovieScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MovieScheduleId"), 1L, 1);

                    b.Property<long>("MovieId")
                        .HasColumnType("bigint");

                    b.Property<long>("ScreenId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ShowDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShowTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieScheduleId");

                    b.HasIndex("MovieId");

                    b.HasIndex("ScreenId");

                    b.ToTable("MovieSchedules");
                });

            modelBuilder.Entity("Movie.Models.Screen", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Screens");
                });

            modelBuilder.Entity("Movie.Models.Seat", b =>
                {
                    b.Property<long>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SeatId"), 1L, 1);

                    b.Property<long>("BookingId")
                        .HasColumnType("bigint");

                    b.Property<int>("Col")
                        .HasColumnType("int");

                    b.Property<long?>("MovieScheduleId")
                        .HasColumnType("bigint");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Row")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("ScreenId")
                        .HasColumnType("bigint");

                    b.HasKey("SeatId");

                    b.HasIndex("BookingId");

                    b.HasIndex("MovieScheduleId");

                    b.HasIndex("ScreenId");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("Movie.Models.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Movie.Models.Booking", b =>
                {
                    b.HasOne("Movie.Models.User", "User")
                        .WithMany("Bookings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Movie.Models.MovieCeleb", b =>
                {
                    b.HasOne("Movie.Models.Celeb", "Celeb")
                        .WithMany("MovieCelebs")
                        .HasForeignKey("CelebId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.Models.Moviee", "Movie")
                        .WithMany("Cast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.Models.Moviee", null)
                        .WithMany("Crew")
                        .HasForeignKey("MovieeId");

                    b.Navigation("Celeb");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Movie.Models.MovieSchedule", b =>
                {
                    b.HasOne("Movie.Models.Moviee", "Movie")
                        .WithMany("MovieSchedules")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.Models.Screen", "Screen")
                        .WithMany("MovieSchedules")
                        .HasForeignKey("ScreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Screen");
                });

            modelBuilder.Entity("Movie.Models.Seat", b =>
                {
                    b.HasOne("Movie.Models.Booking", "Booking")
                        .WithMany("Seats")
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.Models.MovieSchedule", null)
                        .WithMany("NotAvailableSeats")
                        .HasForeignKey("MovieScheduleId");

                    b.HasOne("Movie.Models.Screen", null)
                        .WithMany("Seats")
                        .HasForeignKey("ScreenId");

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("Movie.Models.Booking", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Movie.Models.Celeb", b =>
                {
                    b.Navigation("MovieCelebs");
                });

            modelBuilder.Entity("Movie.Models.Moviee", b =>
                {
                    b.Navigation("Cast");

                    b.Navigation("Crew");

                    b.Navigation("MovieSchedules");
                });

            modelBuilder.Entity("Movie.Models.MovieSchedule", b =>
                {
                    b.Navigation("NotAvailableSeats");
                });

            modelBuilder.Entity("Movie.Models.Screen", b =>
                {
                    b.Navigation("MovieSchedules");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("Movie.Models.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
