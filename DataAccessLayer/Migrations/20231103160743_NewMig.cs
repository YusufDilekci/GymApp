using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Categories_CategoryId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Categories_CategoryId",
                table: "Trainers");

            migrationBuilder.DropTable(
                name: "MemberCategories");

            migrationBuilder.DropTable(
                name: "PacketCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Trainers",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Trainers_CategoryId",
                table: "Trainers",
                newName: "IX_Trainers_BranchId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Images",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_CategoryId",
                table: "Images",
                newName: "IX_Images_BranchId");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Descriptions",
                newName: "BranchId");

            migrationBuilder.RenameIndex(
                name: "IX_Descriptions_CategoryId",
                table: "Descriptions",
                newName: "IX_Descriptions_BranchId");

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "MemberBranches",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberBranches", x => new { x.MemberId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_MemberBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberBranches_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacketBranches",
                columns: table => new
                {
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacketBranches", x => new { x.PacketId, x.BranchId });
                    table.ForeignKey(
                        name: "FK_PacketBranches_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacketBranches_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "BranchInfo", "BranchName", "BranchPrice" },
                values: new object[,]
                {
                    { 1, "üiğiüğğşğşsğaüğ", "Fitness", 1200.0 },
                    { 2, "üiğiüğğşğşsğaüğ", "Kickbox", 1700.0 },
                    { 3, "üiğiüğğşğşsğaüğ", "Zumba", 1500.0 },
                    { 4, "üiğiüğğşğşsğaüğ", "Pilates", 700.0 },
                    { 5, "üiğiüğğşğşsğaüğ", "Coaching", 15.699999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberBranches_BranchId",
                table: "MemberBranches",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_PacketBranches_BranchId",
                table: "PacketBranches",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Branches_BranchId",
                table: "Descriptions",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Branches_BranchId",
                table: "Images",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Branches_BranchId",
                table: "Trainers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "BranchId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Descriptions_Branches_BranchId",
                table: "Descriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_Branches_BranchId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainers_Branches_BranchId",
                table: "Trainers");

            migrationBuilder.DropTable(
                name: "MemberBranches");

            migrationBuilder.DropTable(
                name: "PacketBranches");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Trainers",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Trainers_BranchId",
                table: "Trainers",
                newName: "IX_Trainers_CategoryId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Images",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Images_BranchId",
                table: "Images",
                newName: "IX_Images_CategoryId");

            migrationBuilder.RenameColumn(
                name: "BranchId",
                table: "Descriptions",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Descriptions_BranchId",
                table: "Descriptions",
                newName: "IX_Descriptions_CategoryId");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "MemberCategories",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCategories", x => new { x.MemberId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_MemberCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberCategories_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PacketCategories",
                columns: table => new
                {
                    PacketId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PacketCategories", x => new { x.PacketId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PacketCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PacketCategories_Packets_PacketId",
                        column: x => x.PacketId,
                        principalTable: "Packets",
                        principalColumn: "PacketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryInfo", "CategoryName", "CategoryPrice" },
                values: new object[,]
                {
                    { 1, "üiğiüğğşğşsğaüğ", "Fitness", 1200.0 },
                    { 2, "üiğiüğğşğşsğaüğ", "Kickbox", 1700.0 },
                    { 3, "üiğiüğğşğşsğaüğ", "Zumba", 1500.0 },
                    { 4, "üiğiüğğşğşsğaüğ", "Pilates", 700.0 },
                    { 5, "üiğiüğğşğşsğaüğ", "Coaching", 15.699999999999999 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberCategories_CategoryId",
                table: "MemberCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PacketCategories_CategoryId",
                table: "PacketCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Descriptions_Categories_CategoryId",
                table: "Descriptions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Categories_CategoryId",
                table: "Images",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainers_Categories_CategoryId",
                table: "Trainers",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
