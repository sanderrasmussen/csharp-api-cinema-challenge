﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api_cinema_challenge.Data;

#nullable disable

namespace api_cinema_challenge.Migrations
{
    [DbContext(typeof(CinemaContext))]
    partial class CinemaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("MovieScreen", b =>
                {
                    b.Property<int>("moviesmovieId")
                        .HasColumnType("integer");

                    b.Property<int>("screensscreenId")
                        .HasColumnType("integer");

                    b.HasKey("moviesmovieId", "screensscreenId");

                    b.HasIndex("screensscreenId");

                    b.ToTable("MovieScreen");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Property<int>("customerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("customerId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("customerId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("customerId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("movieId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("movieId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Description");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Rating");

                    b.Property<string>("RuntimeMins")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("RuntimeMins");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("movieId");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screen", b =>
                {
                    b.Property<int>("screenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("screenId");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("screenId"));

                    b.Property<int>("capacity")
                        .HasColumnType("integer")
                        .HasColumnName("capacity");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("createdAt");

                    b.Property<int>("screenNumber")
                        .HasColumnType("integer")
                        .HasColumnName("screenNumber");

                    b.Property<DateTime>("startsAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("startsAt");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("UpdatedAt");

                    b.HasKey("screenId");

                    b.ToTable("Screen");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.Property<int>("ticketId")
                        .HasColumnType("integer")
                        .HasColumnName("ticketId");

                    b.Property<int>("customerID")
                        .HasColumnType("integer")
                        .HasColumnName("customerId");

                    b.HasKey("ticketId");

                    b.HasIndex("customerID");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("MovieScreen", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Movie", null)
                        .WithMany()
                        .HasForeignKey("moviesmovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screen", null)
                        .WithMany()
                        .HasForeignKey("screensscreenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Ticket", b =>
                {
                    b.HasOne("api_cinema_challenge.Models.Customer", "customer")
                        .WithMany("tickets")
                        .HasForeignKey("customerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api_cinema_challenge.Models.Screen", "screen")
                        .WithMany("tickets")
                        .HasForeignKey("ticketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");

                    b.Navigation("screen");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Customer", b =>
                {
                    b.Navigation("tickets");
                });

            modelBuilder.Entity("api_cinema_challenge.Models.Screen", b =>
                {
                    b.Navigation("tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
