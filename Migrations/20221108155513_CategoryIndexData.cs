using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Oniga_Andra_Lab2.Migrations
{
    public partial class CategoryIndexData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Category",
                newName: "ID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Category",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");
        }
    }
}
