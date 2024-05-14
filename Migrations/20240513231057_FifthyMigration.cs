using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pu_backend_cs.Migrations
{
    /// <inheritdoc />
    public partial class FifthyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Item",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Item",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Item",
                newName: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Item",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Item",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Item",
                newName: "Name");
        }
    }
}
