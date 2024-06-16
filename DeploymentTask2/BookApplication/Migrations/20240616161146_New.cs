using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesBook.Migrations
{
    /// <inheritdoc />
    public partial class New : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishDate",
                table: "Book",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Book",
                newName: "Progress");

            migrationBuilder.AddColumn<DateTime>(
                name: "FinishDate",
                table: "Book",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinishDate",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Book",
                newName: "PublishDate");

            migrationBuilder.RenameColumn(
                name: "Progress",
                table: "Book",
                newName: "Price");
        }
    }
}
