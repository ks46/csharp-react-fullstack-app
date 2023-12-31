﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using courses.wwwapi.Data;

#nullable disable

namespace courses.wwwapi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231027193815_NullableExamsPeriodDeclaration")]
    partial class NullableExamsPeriodDeclaration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("courses.wwwapi.Models.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ects")
                        .HasColumnType("integer");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("semester")
                        .HasColumnType("integer");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("courses.wwwapi.Models.CoursesDeclarations", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("courseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("declarationId")
                        .HasColumnType("integer");

                    b.Property<decimal>("grade")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.HasIndex("declarationId");

                    b.ToTable("CoursesDeclarations");
                });

            modelBuilder.Entity("courses.wwwapi.Models.CoursesSpecializations", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("courseId")
                        .HasColumnType("integer");

                    b.Property<int>("specializationId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.HasIndex("courseId");

                    b.ToTable("CoursesSpecializations");
                });

            modelBuilder.Entity("courses.wwwapi.Models.Declaration", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("examsPeriod")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("period")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("studentId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("Declarations");
                });

            modelBuilder.Entity("courses.wwwapi.Models.Student", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("createdAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("department")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("faculty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("semester")
                        .HasColumnType("integer");

                    b.Property<DateTime>("updatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("courses.wwwapi.Models.CoursesDeclarations", b =>
                {
                    b.HasOne("courses.wwwapi.Models.Declaration", null)
                        .WithMany("courses")
                        .HasForeignKey("declarationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("courses.wwwapi.Models.CoursesSpecializations", b =>
                {
                    b.HasOne("courses.wwwapi.Models.Course", null)
                        .WithMany("specializations")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("courses.wwwapi.Models.Course", b =>
                {
                    b.Navigation("specializations");
                });

            modelBuilder.Entity("courses.wwwapi.Models.Declaration", b =>
                {
                    b.Navigation("courses");
                });
#pragma warning restore 612, 618
        }
    }
}
