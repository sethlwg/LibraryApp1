using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    CopyrightInfo = table.Column<string>(type: "TEXT", nullable: false),
                    IsCheckedOut = table.Column<bool>(type: "INTEGER", nullable: false),
                    CheckOutDateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReturnDateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CheckOutDateAndTime", "CopyrightInfo", "IsCheckedOut", "ReturnDateAndTime", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "© 1925 by F. Scott Fitzgerald", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Great Gatsby", 1925 },
                    { 2, "Harper Lee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "© 1960 by Harper Lee", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "To Kill a Mockingbird", 1960 },
                    { 3, "George Orwell", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "© 1949 by George Orwell", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1984", 1949 },
                    { 4, "Herman Melville", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "© 1851 by Herman Melville", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moby Dick", 1851 },
                    { 5, "Suzanne Collins", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "© 2008 by Suzanne Collins", false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Hunger Games", 2008 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "EmailAddress", "Name" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John Doe" },
                    { 2, "jane.smith@example.com", "Jane Smith" },
                    { 3, "james.hammington@example.com", "James Hammington" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
