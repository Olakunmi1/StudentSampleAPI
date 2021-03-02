using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentSampleAPI.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "AssignmentId", "Created_at", "DateOfBirth", "Name" },
                values: new object[,]
                {
                    { 1, 24, 0, new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(560), new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Mark Almson" },
                    { 2, 25, 0, new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1750), new DateTimeOffset(new DateTime(1995, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "John Rice" },
                    { 3, 24, 0, new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1780), new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Olakunmi Sodiq" },
                    { 4, 24, 0, new DateTime(2021, 2, 28, 22, 55, 22, 712, DateTimeKind.Local).AddTicks(1790), new DateTimeOffset(new DateTime(1996, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "Foluke Balagon" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "AssignmentId", "DateOfSubmission", "Description", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "This assignemnt contains some algorithim samplee", " Algorithim Sample", 1 },
                    { 2, null, new DateTimeOffset(new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "This assignemnt contains some algorithim samplee", " Algorithim Sample", 2 },
                    { 3, null, new DateTimeOffset(new DateTime(2021, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "This assignemnt contains some algorithim samplee", " Algorithim Sample", 3 },
                    { 4, null, new DateTimeOffset(new DateTime(2021, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)), "This assignemnt contains some algorithim samplee", " Algorithim Sample", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
