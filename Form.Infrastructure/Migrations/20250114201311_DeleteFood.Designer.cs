﻿// <auto-generated />
using Form.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Form.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250114201311_DeleteFood")]
    partial class DeleteFood
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Form.Domain.Domain.FormEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("BeChampagne")
                        .HasColumnType("boolean");

                    b.Property<bool>("BeCongac")
                        .HasColumnType("boolean");

                    b.Property<bool>("BeVodka")
                        .HasColumnType("boolean");

                    b.Property<bool>("BeWine")
                        .HasColumnType("boolean");

                    b.Property<string>("ChildrenName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("DontDrink")
                        .HasColumnType("boolean");

                    b.Property<string>("PartnerName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("VisitorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("WillTheRegistration")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Forms");
                });
#pragma warning restore 612, 618
        }
    }
}
