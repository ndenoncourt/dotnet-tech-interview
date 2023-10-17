using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace tech_interview_api.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Title" },
                values: new object[,]
                {
                    { 100, "J.R.R. Tolkien", "The Fellowship of the Ring" },
                    { 200, "J.R.R. Tolkien", "The Two Towers" },
                    { 300, "J.R.R. Tolkien", "The Return of the King" },
                    { 400, "J.R.R. Tolkien", "The Hobbit" },
                    { 500, "J.R.R. Tolkien", "The Silmarillion" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "EmailAddress", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 100, "yanick.rondeau@groupehsift.ca", "Yannick R", "(819) 247-4214" },
                    { 200, "john.doe@gmail.com", "John Doe", "(819) 555-5555" },
                    { 300, "Jane.D@outlook.com", "Jane Doe", null }
                });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "Id", "BookId", "BookId1", "LoanDate", "MemberId", "MemberId1", "ReturnDate" },
                values: new object[,]
                {
                    { 100, 200, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, null, null },
                    { 200, 300, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 200, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 200);
        }
    }
}
