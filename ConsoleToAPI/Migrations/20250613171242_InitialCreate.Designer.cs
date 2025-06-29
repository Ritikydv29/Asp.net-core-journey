﻿// <auto-generated />
using System;
using ConsoleToAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleToAPI.Migrations
{
    [DbContext(typeof(StudentContext))]
    [Migration("20250613171242_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleToAPI.Score", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Student_Id")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Teacher_Id")
                        .HasColumnType("int");

                    b.Property<DateOnly>("date")
                        .HasColumnType("date");

                    b.HasKey("id");

                    b.HasIndex("Student_Id");

                    b.HasIndex("Teacher_Id");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("ConsoleToAPI.Student", b =>
                {
                    b.Property<int>("Student_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Student_Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone_No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Teacher_Id")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_Id");

                    b.HasIndex("Teacher_Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("ConsoleToAPI.Teacher", b =>
                {
                    b.Property<int>("Teacher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Teacher_Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Teacher_Id");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("ConsoleToAPI.Score", b =>
                {
                    b.HasOne("ConsoleToAPI.Student", "Student")
                        .WithMany("Scores")
                        .HasForeignKey("Student_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleToAPI.Teacher", "Teacher")
                        .WithMany("Scores")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ConsoleToAPI.Student", b =>
                {
                    b.HasOne("ConsoleToAPI.Teacher", "Teacher")
                        .WithMany("Students")
                        .HasForeignKey("Teacher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ConsoleToAPI.Student", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("ConsoleToAPI.Teacher", b =>
                {
                    b.Navigation("Scores");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
