﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Models;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20231017082138_AddSchoolYear")]
    partial class AddSchoolYear
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Models.Circular", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("body")
                        .HasAnnotation("Relational:JsonPropertyName", "body");

                    b.Property<int>("CircularNumber")
                        .HasColumnType("integer")
                        .HasColumnName("circular_number")
                        .HasAnnotation("Relational:JsonPropertyName", "circular_name");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("header")
                        .HasAnnotation("Relational:JsonPropertyName", "header");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("location")
                        .HasAnnotation("Relational:JsonPropertyName", "location");

                    b.Property<string>("Object")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("object")
                        .HasAnnotation("Relational:JsonPropertyName", "object");

                    b.Property<string>("Sign")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("sign")
                        .HasAnnotation("Relational:JsonPropertyName", "sign");

                    b.Property<DateOnly>("UploadDate")
                        .HasColumnType("date")
                        .HasColumnName("upload_date")
                        .HasAnnotation("Relational:JsonPropertyName", "upload_date");

                    b.HasKey("Id");

                    b.ToTable("Pdfs");
                });

            modelBuilder.Entity("backend.Models.Classroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("classrooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("612ce7d2-c15f-4dca-ac34-676e93f6bb0e"),
                            Name = "1A"
                        },
                        new
                        {
                            Id = new Guid("0ed3811a-0a5c-4ed0-b7db-53090199aa27"),
                            Name = "1B"
                        },
                        new
                        {
                            Id = new Guid("70f432dc-2a6c-499b-9326-52d1506befa5"),
                            Name = "2A"
                        });
                });

            modelBuilder.Entity("backend.Models.Exam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date")
                        .HasColumnName("date")
                        .HasAnnotation("Relational:JsonPropertyName", "date");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<Guid>("TeacherSubjectClassroomId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_teacherSubjectClassroom")
                        .HasAnnotation("Relational:JsonPropertyName", "id_teacherSubjectClassroom");

                    b.HasKey("Id");

                    b.HasIndex("TeacherSubjectClassroomId");

                    b.ToTable("exams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("55988821-2bc3-4122-aa50-e0fb3b8f42ad"),
                            Date = new DateOnly(2023, 9, 6),
                            TeacherSubjectClassroomId = new Guid("0f69c148-07ab-47a8-838a-0c9dfce974bf")
                        },
                        new
                        {
                            Id = new Guid("06dec5ca-003e-4b39-af43-c745746d23e0"),
                            Date = new DateOnly(2023, 9, 10),
                            TeacherSubjectClassroomId = new Guid("a0d8bde6-4ece-4eaa-96bd-6da7d2db7daa")
                        },
                        new
                        {
                            Id = new Guid("20ad1b3e-af97-4a45-815b-af9f34e52dc3"),
                            Date = new DateOnly(2023, 9, 25),
                            TeacherSubjectClassroomId = new Guid("7fb36228-d263-43d7-ba9a-58e7f6ff5f0d")
                        });
                });

            modelBuilder.Entity("backend.Models.PromotionHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<int>("FinalGraduation")
                        .HasColumnType("integer")
                        .HasColumnName("final_graduation")
                        .HasAnnotation("Relational:JsonPropertyName", "final_graduation");

                    b.Property<Guid>("PreviousClassroomId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_previous_classroom")
                        .HasAnnotation("Relational:JsonPropertyName", "id_previous_classroom");

                    b.Property<string>("PreviousSchoolYear")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("previous_school_year")
                        .HasAnnotation("Relational:JsonPropertyName", "previous_school_year");

                    b.Property<bool>("Promoted")
                        .HasColumnType("boolean")
                        .HasColumnName("promoted")
                        .HasAnnotation("Relational:JsonPropertyName", "promoted");

                    b.Property<int>("ScholasticBehavior")
                        .HasColumnType("integer")
                        .HasColumnName("scholastic_behavior")
                        .HasAnnotation("Relational:JsonPropertyName", "scholastic_behavior");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_student")
                        .HasAnnotation("Relational:JsonPropertyName", "id_student");

                    b.HasKey("Id");

                    b.HasIndex("PreviousClassroomId");

                    b.HasIndex("StudentId");

                    b.ToTable("promotion_histories");
                });

            modelBuilder.Entity("backend.Models.Registry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<string>("Address")
                        .HasColumnType("text")
                        .HasColumnName("address")
                        .HasAnnotation("Relational:JsonPropertyName", "address");

                    b.Property<DateOnly?>("Birth")
                        .HasColumnType("date")
                        .HasColumnName("birth")
                        .HasAnnotation("Relational:JsonPropertyName", "birth");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email")
                        .HasAnnotation("Relational:JsonPropertyName", "email");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("gender")
                        .HasAnnotation("Relational:JsonPropertyName", "gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname")
                        .HasAnnotation("Relational:JsonPropertyName", "surname");

                    b.Property<string>("Telephone")
                        .HasColumnType("text")
                        .HasColumnName("telephone")
                        .HasAnnotation("Relational:JsonPropertyName", "telephone");

                    b.HasKey("Id");

                    b.ToTable("registries");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d7f23f33-ebf2-4716-8c3f-b997ba2da125"),
                            Birth = new DateOnly(1996, 9, 15),
                            Gender = "Vipera",
                            Name = "Giordana",
                            Surname = "Pistorio"
                        },
                        new
                        {
                            Id = new Guid("153afc1d-f63f-45aa-ae55-534d4ceeb737"),
                            Birth = new DateOnly(2002, 1, 3),
                            Gender = "Sirenetta",
                            Name = "Gabriele",
                            Surname = "Giuliano"
                        },
                        new
                        {
                            Id = new Guid("c976d8c8-3aa5-4164-be7c-884ebe29ee1e"),
                            Birth = new DateOnly(2001, 9, 25),
                            Gender = "M",
                            Name = "Francesco",
                            Surname = "Limonelli"
                        },
                        new
                        {
                            Id = new Guid("f833e6a7-f617-4683-a772-b5bcd1971da8"),
                            Birth = new DateOnly(1993, 5, 6),
                            Gender = "F",
                            Name = "Francesca",
                            Surname = "Scollo"
                        },
                        new
                        {
                            Id = new Guid("634477e4-1eeb-4a0d-bb07-c9bd2e3f9702"),
                            Birth = new DateOnly(2001, 9, 23),
                            Gender = "M",
                            Name = "Angelo",
                            Surname = "Lombardo"
                        });
                });

            modelBuilder.Entity("backend.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<Guid>("ClassroomId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_classroom")
                        .HasAnnotation("Relational:JsonPropertyName", "id_classroom");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<Guid>("RegistryId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_registry")
                        .HasAnnotation("Relational:JsonPropertyName", "id_registry");

                    b.Property<string>("SchoolYear")
                        .HasColumnType("text")
                        .HasColumnName("school_year")
                        .HasAnnotation("Relational:JsonPropertyName", "school_year");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_user")
                        .HasAnnotation("Relational:JsonPropertyName", "id_user");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("RegistryId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("007d3bca-d81d-42bd-9194-9c1d9f1f5ed7"),
                            ClassroomId = new Guid("612ce7d2-c15f-4dca-ac34-676e93f6bb0e"),
                            RegistryId = new Guid("c976d8c8-3aa5-4164-be7c-884ebe29ee1e"),
                            UserId = new Guid("8af66697-aaf2-44d3-ac9e-b051451fa2ea")
                        },
                        new
                        {
                            Id = new Guid("8767fd02-7891-4b47-8b02-3cc0d07ac334"),
                            ClassroomId = new Guid("0ed3811a-0a5c-4ed0-b7db-53090199aa27"),
                            RegistryId = new Guid("f833e6a7-f617-4683-a772-b5bcd1971da8"),
                            UserId = new Guid("37ce79ab-5b93-44ce-8189-e49ab8e377e2")
                        },
                        new
                        {
                            Id = new Guid("78362ba2-29ea-472b-9878-f55dad233e21"),
                            ClassroomId = new Guid("612ce7d2-c15f-4dca-ac34-676e93f6bb0e"),
                            RegistryId = new Guid("634477e4-1eeb-4a0d-bb07-c9bd2e3f9702"),
                            UserId = new Guid("c98b3291-bd68-4f9e-a906-1a273ac9046b")
                        });
                });

            modelBuilder.Entity("backend.Models.StudentExam", b =>
                {
                    b.Property<Guid>("ExamId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_exam")
                        .HasAnnotation("Relational:JsonPropertyName", "id_exam");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_student")
                        .HasAnnotation("Relational:JsonPropertyName", "id_student");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<int?>("Grade")
                        .HasColumnType("integer")
                        .HasColumnName("grade")
                        .HasAnnotation("Relational:JsonPropertyName", "grade");

                    b.HasKey("ExamId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("students_exams");
                });

            modelBuilder.Entity("backend.Models.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name")
                        .HasAnnotation("Relational:JsonPropertyName", "name");

                    b.HasKey("Id");

                    b.ToTable("subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("be1816ff-41be-4620-a48c-ac18b71e3bf8"),
                            Name = "Italiano"
                        },
                        new
                        {
                            Id = new Guid("a907ec00-1577-4a50-ab10-579e071f1e59"),
                            Name = "Inglese"
                        },
                        new
                        {
                            Id = new Guid("46fd8c9d-b689-47cb-b9fd-44a19c5291a4"),
                            Name = "Matematica"
                        },
                        new
                        {
                            Id = new Guid("b55de490-fcdd-43d3-9146-94774e96cfe6"),
                            Name = "Storia"
                        },
                        new
                        {
                            Id = new Guid("336d920e-273f-40bd-aed3-17212e2fb2a3"),
                            Name = "Geografia"
                        },
                        new
                        {
                            Id = new Guid("47e8b0b5-1b53-46be-a0a9-9954958d3071"),
                            Name = "Spagnola"
                        });
                });

            modelBuilder.Entity("backend.Models.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<Guid>("RegistryId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_registry")
                        .HasAnnotation("Relational:JsonPropertyName", "id_regitry");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_user")
                        .HasAnnotation("Relational:JsonPropertyName", "id_user");

                    b.HasKey("Id");

                    b.HasIndex("RegistryId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cc3f629e-ae6b-448e-be46-afce1fa9e31d"),
                            RegistryId = new Guid("d7f23f33-ebf2-4716-8c3f-b997ba2da125"),
                            UserId = new Guid("1346712f-a66d-4b25-9ff6-cf6b7cd8c954")
                        },
                        new
                        {
                            Id = new Guid("54ff5a4a-1469-4f07-afcb-9b1864dcb335"),
                            RegistryId = new Guid("153afc1d-f63f-45aa-ae55-534d4ceeb737"),
                            UserId = new Guid("affab63e-dec6-4626-abfb-1e52b258cc6c")
                        });
                });

            modelBuilder.Entity("backend.Models.TeacherSubjectClassroom", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<Guid>("ClassroomId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_classroom")
                        .HasAnnotation("Relational:JsonPropertyName", "id_classroom");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_subject")
                        .HasAnnotation("Relational:JsonPropertyName", "id_subject");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uuid")
                        .HasColumnName("id_teacher")
                        .HasAnnotation("Relational:JsonPropertyName", "id_techer");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("teachers_subjects_classrooms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0f69c148-07ab-47a8-838a-0c9dfce974bf"),
                            ClassroomId = new Guid("0ed3811a-0a5c-4ed0-b7db-53090199aa27"),
                            SubjectId = new Guid("a907ec00-1577-4a50-ab10-579e071f1e59"),
                            TeacherId = new Guid("54ff5a4a-1469-4f07-afcb-9b1864dcb335")
                        },
                        new
                        {
                            Id = new Guid("a0d8bde6-4ece-4eaa-96bd-6da7d2db7daa"),
                            ClassroomId = new Guid("0ed3811a-0a5c-4ed0-b7db-53090199aa27"),
                            SubjectId = new Guid("be1816ff-41be-4620-a48c-ac18b71e3bf8"),
                            TeacherId = new Guid("cc3f629e-ae6b-448e-be46-afce1fa9e31d")
                        },
                        new
                        {
                            Id = new Guid("7fb36228-d263-43d7-ba9a-58e7f6ff5f0d"),
                            ClassroomId = new Guid("0ed3811a-0a5c-4ed0-b7db-53090199aa27"),
                            SubjectId = new Guid("336d920e-273f-40bd-aed3-17212e2fb2a3"),
                            TeacherId = new Guid("cc3f629e-ae6b-448e-be46-afce1fa9e31d")
                        },
                        new
                        {
                            Id = new Guid("0ac0626c-802a-4e59-a54d-8ddc3eab0b61"),
                            ClassroomId = new Guid("612ce7d2-c15f-4dca-ac34-676e93f6bb0e"),
                            SubjectId = new Guid("a907ec00-1577-4a50-ab10-579e071f1e59"),
                            TeacherId = new Guid("54ff5a4a-1469-4f07-afcb-9b1864dcb335")
                        });
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasAnnotation("Relational:JsonPropertyName", "id");

                    b.Property<DateOnly?>("DeletedAt")
                        .HasColumnType("date")
                        .HasColumnName("deleted_at")
                        .HasAnnotation("Relational:JsonPropertyName", "deleted_at");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("password")
                        .HasAnnotation("Relational:JsonPropertyName", "password");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("username")
                        .HasAnnotation("Relational:JsonPropertyName", "username");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1346712f-a66d-4b25-9ff6-cf6b7cd8c954"),
                            Password = "123",
                            Username = "giop5"
                        },
                        new
                        {
                            Id = new Guid("affab63e-dec6-4626-abfb-1e52b258cc6c"),
                            Password = "123",
                            Username = "aboutgg"
                        },
                        new
                        {
                            Id = new Guid("8af66697-aaf2-44d3-ac9e-b051451fa2ea"),
                            Password = "nonloso",
                            Username = "sidectrl"
                        },
                        new
                        {
                            Id = new Guid("c98b3291-bd68-4f9e-a906-1a273ac9046b"),
                            Password = "nonticonosco",
                            Username = "angelarmstrong"
                        },
                        new
                        {
                            Id = new Guid("37ce79ab-5b93-44ce-8189-e49ab8e377e2"),
                            Password = "ilsegreto",
                            Username = "donnafrancisca"
                        });
                });

            modelBuilder.Entity("backend.Models.Exam", b =>
                {
                    b.HasOne("backend.Models.TeacherSubjectClassroom", "TeacherSubjectClassroom")
                        .WithMany("Exam")
                        .HasForeignKey("TeacherSubjectClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeacherSubjectClassroom");
                });

            modelBuilder.Entity("backend.Models.PromotionHistory", b =>
                {
                    b.HasOne("backend.Models.Classroom", "PreviousClassroom")
                        .WithMany("PromotionHistories")
                        .HasForeignKey("PreviousClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Student", "Student")
                        .WithMany("PromotionHistories")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PreviousClassroom");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("backend.Models.Student", b =>
                {
                    b.HasOne("backend.Models.Classroom", "Classroom")
                        .WithMany("Students")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Registry", "Registry")
                        .WithOne("Student")
                        .HasForeignKey("backend.Models.Student", "RegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.User", "User")
                        .WithOne("Student")
                        .HasForeignKey("backend.Models.Student", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Registry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("backend.Models.StudentExam", b =>
                {
                    b.HasOne("backend.Models.Exam", "Exam")
                        .WithMany("StudentExams")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Student", "Student")
                        .WithMany("StudentExams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("backend.Models.Teacher", b =>
                {
                    b.HasOne("backend.Models.Registry", "Registry")
                        .WithOne("Teacher")
                        .HasForeignKey("backend.Models.Teacher", "RegistryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.User", "User")
                        .WithOne("Teacher")
                        .HasForeignKey("backend.Models.Teacher", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Registry");

                    b.Navigation("User");
                });

            modelBuilder.Entity("backend.Models.TeacherSubjectClassroom", b =>
                {
                    b.HasOne("backend.Models.Classroom", "Classroom")
                        .WithMany("TeacherSubjectsClassrooms")
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Subject", "Subject")
                        .WithMany("TeacherSubjectsClassrooms")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backend.Models.Teacher", "Teacher")
                        .WithMany("TeachersSubjectsClassrooms")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Classroom");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("backend.Models.Classroom", b =>
                {
                    b.Navigation("PromotionHistories");

                    b.Navigation("Students");

                    b.Navigation("TeacherSubjectsClassrooms");
                });

            modelBuilder.Entity("backend.Models.Exam", b =>
                {
                    b.Navigation("StudentExams");
                });

            modelBuilder.Entity("backend.Models.Registry", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();

                    b.Navigation("Teacher")
                        .IsRequired();
                });

            modelBuilder.Entity("backend.Models.Student", b =>
                {
                    b.Navigation("PromotionHistories");

                    b.Navigation("StudentExams");
                });

            modelBuilder.Entity("backend.Models.Subject", b =>
                {
                    b.Navigation("TeacherSubjectsClassrooms");
                });

            modelBuilder.Entity("backend.Models.Teacher", b =>
                {
                    b.Navigation("TeachersSubjectsClassrooms");
                });

            modelBuilder.Entity("backend.Models.TeacherSubjectClassroom", b =>
                {
                    b.Navigation("Exam");
                });

            modelBuilder.Entity("backend.Models.User", b =>
                {
                    b.Navigation("Student")
                        .IsRequired();

                    b.Navigation("Teacher")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
