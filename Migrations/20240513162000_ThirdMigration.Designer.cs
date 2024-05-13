﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using pu_backend_cs.Data;

#nullable disable

namespace pu_backend_cs.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240513162000_ThirdMigration")]
    partial class ThirdMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("pu_backend_cs.Models.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<double>("amount")
                        .HasColumnType("double precision");

                    b.Property<DateTime>("date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<List<string>>("itemsId")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<int>("orderNumber")
                        .HasColumnType("integer");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ubicationId")
                        .HasColumnType("integer");

                    b.Property<string>("userCI")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.HasIndex("ubicationId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("pu_backend_cs.Models.Ubication", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("floor")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("state")
                        .HasColumnType("boolean");

                    b.Property<string>("tower")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Ubications");
                });

            modelBuilder.Entity("pu_backend_cs.Models.Order", b =>
                {
                    b.HasOne("pu_backend_cs.Models.Ubication", "oUbication")
                        .WithMany()
                        .HasForeignKey("ubicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("oUbication");
                });
#pragma warning restore 612, 618
        }
    }
}
