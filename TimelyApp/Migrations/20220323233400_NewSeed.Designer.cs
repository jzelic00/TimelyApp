﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TimelyApp.Models;

namespace TimelyApp.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220323233400_NewSeed")]
    partial class NewSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TimelyApp.Models.Log", b =>
                {
                    b.Property<int>("LogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("LogID");

                    b.ToTable("Log");

                    b.HasData(
                        new
                        {
                            LogID = 1,
                            Duration = 1234,
                            EndTime = new DateTime(2022, 3, 23, 23, 33, 59, 735, DateTimeKind.Utc).AddTicks(4897),
                            ProjectName = "test",
                            StartTime = new DateTime(2022, 3, 23, 23, 33, 59, 735, DateTimeKind.Utc).AddTicks(4675)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
