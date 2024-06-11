using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pu_backend_cs.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Orders_Orderid",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameColumn(
                name: "Orderid",
                table: "Items",
                newName: "orderId");

            migrationBuilder.RenameIndex(
                name: "IX_Item_Orderid",
                table: "Items",
                newName: "IX_Items_orderId");

            migrationBuilder.AlterColumn<int>(
                name: "orderId",
                table: "Items",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_orderId",
                table: "Items",
                column: "orderId",
                principalTable: "Orders",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_orderId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameColumn(
                name: "orderId",
                table: "Item",
                newName: "Orderid");

            migrationBuilder.RenameIndex(
                name: "IX_Items_orderId",
                table: "Item",
                newName: "IX_Item_Orderid");

            migrationBuilder.AlterColumn<int>(
                name: "Orderid",
                table: "Item",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Orders_Orderid",
                table: "Item",
                column: "Orderid",
                principalTable: "Orders",
                principalColumn: "id");
        }
    }
}
