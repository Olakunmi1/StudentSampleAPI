﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentSampleAPI.Student.DataAcces;

namespace StudentSampleAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentSampleAPI.Student.DataAcces.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DateOfSubmission")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfSubmission = new DateTimeOffset(new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "This assignemnt contains some algorithim samplee",
                            Name = " Algorithim Sample",
                            StudentId = 1
                        },
                        new
                        {
                            Id = 2,
                            DateOfSubmission = new DateTimeOffset(new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "This assignemnt contains some algorithim samplee",
                            Name = " Algorithim Sample",
                            StudentId = 2
                        },
                        new
                        {
                            Id = 3,
                            DateOfSubmission = new DateTimeOffset(new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "This assignemnt contains some algorithim samplee",
                            Name = " Algorithim Sample",
                            StudentId = 3
                        },
                        new
                        {
                            Id = 4,
                            DateOfSubmission = new DateTimeOffset(new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Description = "This assignemnt contains some algorithim samplee",
                            Name = " Algorithim Sample",
                            StudentId = 4
                        });
                });

            modelBuilder.Entity("StudentSampleAPI.Student.DataAcces.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset>("DateOfBirth")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 24,
                            AssignmentId = 0,
                            Created_at = new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(560),
                            DateOfBirth = new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Name = "Mark Almson"
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            AssignmentId = 0,
                            Created_at = new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1750),
                            DateOfBirth = new DateTimeOffset(new DateTime(1995, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Name = "John Rice"
                        },
                        new
                        {
                            Id = 3,
                            Age = 24,
                            AssignmentId = 0,
                            Created_at = new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1780),
                            DateOfBirth = new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Name = "Olakunmi Sodiq"
                        },
                        new
                        {
                            Id = 4,
                            Age = 24,
                            AssignmentId = 0,
                            Created_at = new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1790),
                            DateOfBirth = new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Name = "Foluke Balagon"
                        });
                });

            modelBuilder.Entity("StudentSampleAPI.Student.DataAcces.Assignment", b =>
                {
                    b.HasOne("StudentSampleAPI.Student.DataAcces.Student", null)
                        .WithMany("Assignment")
                        .HasForeignKey("AssignmentId");

                    b.HasOne("StudentSampleAPI.Student.DataAcces.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("StudentSampleAPI.Student.DataAcces.Student", b =>
                {
                    b.Navigation("Assignment");
                });
#pragma warning restore 612, 618
        }
    }
}
