﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NETCoreDemo.Db;
using NETCoreDemo.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace NETCoreDemo.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230303132139_InitialMigrations")]
    partial class InitialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "course_status", new[] { "not_started", "on_going", "ended" });
            NpgsqlModelBuilderExtensions.HasPostgresEnum(modelBuilder, "project_role", new[] { "project_manager", "project_coordinator", "developer", "designer" });
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AssignmentStudent", b =>
                {
                    b.Property<int>("AssignmentsId")
                        .HasColumnType("integer")
                        .HasColumnName("assignments_id");

                    b.Property<int>("StudentsId")
                        .HasColumnType("integer")
                        .HasColumnName("students_id");

                    b.HasKey("AssignmentsId", "StudentsId")
                        .HasName("pk_assignment_student");

                    b.HasIndex("StudentsId")
                        .HasDatabaseName("ix_assignment_student_students_id");

                    b.ToTable("assignment_student", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("city");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("street");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("zipcode");

                    b.HasKey("Id")
                        .HasName("pk_addresses");

                    b.ToTable("addresses", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_assignment");

                    b.ToTable("assignment", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<ICollection<string>>("Images")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("images");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("name");

                    b.Property<short>("Size")
                        .HasColumnType("smallint")
                        .HasColumnName("size");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date");

                    b.Property<Course.CourseStatus>("Status")
                        .HasColumnType("course_status")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_courses");

                    b.HasIndex("Name")
                        .HasDatabaseName("ix_courses_name");

                    b.ToTable("courses", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("deadline");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("end_date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("start_date");

                    b.Property<ICollection<string>>("Tags")
                        .IsRequired()
                        .HasColumnType("jsonb")
                        .HasColumnName("tags");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("Id")
                        .HasName("pk_projects");

                    b.ToTable("projects", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.ProjectStudent", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("integer")
                        .HasColumnName("project_id");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer")
                        .HasColumnName("student_id");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("joined_at");

                    b.Property<ProjectRole>("Role")
                        .HasColumnType("project_role")
                        .HasColumnName("role");

                    b.HasKey("ProjectId", "StudentId")
                        .HasName("pk_project_students");

                    b.HasIndex("StudentId")
                        .HasDatabaseName("ix_project_students_student_id");

                    b.ToTable("project_students", (string)null);
                });

            modelBuilder.Entity("NETCoreDemo.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer")
                        .HasColumnName("course_id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("last_name");

                    b.Property<DateTime>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.HasKey("Id")
                        .HasName("pk_students");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasDatabaseName("ix_students_address_id");

                    b.HasIndex("CourseId")
                        .HasDatabaseName("ix_students_course_id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasDatabaseName("ix_students_email");

                    b.ToTable("students", (string)null);
                });

            modelBuilder.Entity("AssignmentStudent", b =>
                {
                    b.HasOne("NETCoreDemo.Models.Assignment", null)
                        .WithMany()
                        .HasForeignKey("AssignmentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_assignment_student_assignment_assignments_id");

                    b.HasOne("NETCoreDemo.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_assignment_student_students_students_id");
                });

            modelBuilder.Entity("NETCoreDemo.Models.ProjectStudent", b =>
                {
                    b.HasOne("NETCoreDemo.Models.Project", "Project")
                        .WithMany("StudentLinks")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_students_projects_project_id");

                    b.HasOne("NETCoreDemo.Models.Student", "Student")
                        .WithMany("ProjectLinks")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_project_students_students_student_id");

                    b.Navigation("Project");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NETCoreDemo.Models.Student", b =>
                {
                    b.HasOne("NETCoreDemo.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("NETCoreDemo.Models.Student", "AddressId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_students_addresses_address_id");

                    b.HasOne("NETCoreDemo.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_students_courses_course_id");

                    b.Navigation("Address");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("NETCoreDemo.Models.Course", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("NETCoreDemo.Models.Project", b =>
                {
                    b.Navigation("StudentLinks");
                });

            modelBuilder.Entity("NETCoreDemo.Models.Student", b =>
                {
                    b.Navigation("ProjectLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
