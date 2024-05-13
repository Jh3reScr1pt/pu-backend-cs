using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pu_backend_cs.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Ubications_ubicationid",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ubicationid",
                table: "Orders",
                newName: "ubicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ubicationid",
                table: "Orders",
                newName: "IX_Orders_ubicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Ubications_ubicationId",
                table: "Orders",
                column: "ubicationId",
                principalTable: "Ubications",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Ubications_ubicationId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "ubicationId",
                table: "Orders",
                newName: "ubicationid");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ubicationId",
                table: "Orders",
                newName: "IX_Orders_ubicationid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Ubications_ubicationid",
                table: "Orders",
                column: "ubicationid",
                principalTable: "Ubications",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
