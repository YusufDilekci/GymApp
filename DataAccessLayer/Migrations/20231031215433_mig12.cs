using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PacketCategory_Categories_CategoryId",
                table: "PacketCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_PacketCategory_Packets_PacketId",
                table: "PacketCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacketCategory",
                table: "PacketCategory");

            migrationBuilder.RenameTable(
                name: "PacketCategory",
                newName: "PacketCategories");

            migrationBuilder.RenameIndex(
                name: "IX_PacketCategory_CategoryId",
                table: "PacketCategories",
                newName: "IX_PacketCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacketCategories",
                table: "PacketCategories",
                columns: new[] { "PacketId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PacketCategories_Categories_CategoryId",
                table: "PacketCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PacketCategories_Packets_PacketId",
                table: "PacketCategories",
                column: "PacketId",
                principalTable: "Packets",
                principalColumn: "PacketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PacketCategories_Categories_CategoryId",
                table: "PacketCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_PacketCategories_Packets_PacketId",
                table: "PacketCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PacketCategories",
                table: "PacketCategories");

            migrationBuilder.RenameTable(
                name: "PacketCategories",
                newName: "PacketCategory");

            migrationBuilder.RenameIndex(
                name: "IX_PacketCategories_CategoryId",
                table: "PacketCategory",
                newName: "IX_PacketCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PacketCategory",
                table: "PacketCategory",
                columns: new[] { "PacketId", "CategoryId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PacketCategory_Categories_CategoryId",
                table: "PacketCategory",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PacketCategory_Packets_PacketId",
                table: "PacketCategory",
                column: "PacketId",
                principalTable: "Packets",
                principalColumn: "PacketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
