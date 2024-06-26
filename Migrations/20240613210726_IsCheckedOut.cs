using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryApp1.Migrations
{
    /// <inheritdoc />
    public partial class IsCheckedOut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCheckedOut",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            // migrationBuilder.InsertData(
            //     table: "Books",
            //     columns: new[] { "Id", "Author", "CopyrightInfo", "IsCheckedOut", "Title", "Year" },
            //     values: new object[,]
            //     {
            //         { 1, "F. Scott Fitzgerald", "© 1925 by F. Scott Fitzgerald", false, "The Great Gatsby", 1925 },
            //         { 2, "Harper Lee", "© 1960 by Harper Lee", false, "To Kill a Mockingbird", 1960 },
            //         { 3, "George Orwell", "© 1949 by George Orwell", false, "1984", 1949 },
            //         { 4, "Herman Melville", "© 1851 by Herman Melville", false, "Moby Dick", 1851 }
            //     });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "IsCheckedOut",
                table: "Books");
        }
    }
}
