using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CommentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Erkek Giyim" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Kadın Giyim" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Supplement" });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "SubCategoryId", "CategoryId", "SubCategoryImage", "SubCategoryName" },
                values: new object[,]
                {
                    { 1, 1, "#", "Tshirt" },
                    { 2, 1, "#", "Sweatshirt" },
                    { 3, 1, "#", "Eşofman" },
                    { 4, 1, "#", "Ayakkabı" },
                    { 5, 2, "#", "Tshirt" },
                    { 6, 2, "#", "Sweatshirt" },
                    { 7, 2, "#", "Eşofman" },
                    { 8, 2, "#", "Ayakkabı" },
                    { 9, 3, "#", "Protein Tozu" },
                    { 10, 3, "#", "Gainer" },
                    { 11, 3, "#", "Kreatin" },
                    { 12, 3, "#", "PreWorkout" },
                    { 13, 3, "#", "BCAA" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductDescription", "ProductImage", "ProductName", "ProductPrice", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "Erkek Tshirt", "#", "Jack & Jones", 200.0, 1 },
                    { 2, "Erkek Tshirt", "#", "Mavi", 200.0, 1 },
                    { 3, "Erkek Tshirt", "#", "DeFacto", 200.0, 1 },
                    { 4, "Erkek Tshirt", "#", "Jack & Jones", 200.0, 2 },
                    { 5, "Erkek Tshirt", "#", "Pull & Bear", 200.0, 2 },
                    { 6, "Erkek Tshirt", "#", "Lc Waikiki", 200.0, 2 },
                    { 7, "Erkek Tshirt", "#", "Nike", 200.0, 3 },
                    { 8, "Erkek Tshirt", "#", "Adidas", 200.0, 3 },
                    { 9, "Erkek Tshirt", "#", "Under Armour", 200.0, 3 },
                    { 10, "Erkek Tshirt", "#", "Nike", 200.0, 4 },
                    { 11, "Erkek Tshirt", "#", "Puma", 200.0, 4 },
                    { 12, "Erkek Tshirt", "#", "Adidas", 200.0, 4 },
                    { 13, "Erkek Tshirt", "#", "Jack & Jones", 200.0, 5 },
                    { 14, "Erkek Tshirt", "#", "Mavi", 200.0, 5 },
                    { 15, "Erkek Tshirt", "#", "DeFacto", 200.0, 5 },
                    { 16, "Erkek Tshirt", "#", "Jack & Jones", 200.0, 6 },
                    { 17, "Erkek Tshirt", "#", "Pull & Bear", 200.0, 6 },
                    { 18, "Erkek Tshirt", "#", "Lc Waikiki", 200.0, 6 },
                    { 19, "Erkek Tshirt", "#", "Nike", 200.0, 7 },
                    { 20, "Erkek Tshirt", "#", "Adidas", 200.0, 7 },
                    { 21, "Erkek Tshirt", "#", "Under Armour", 200.0, 7 },
                    { 22, "Erkek Tshirt", "#", "Nike", 200.0, 8 },
                    { 23, "Erkek Tshirt", "#", "Puma", 200.0, 8 },
                    { 24, "Erkek Tshirt", "#", "Adidas", 200.0, 8 },
                    { 25, "Erkek Tshirt", "#", "Hardline", 200.0, 9 },
                    { 26, "Erkek Tshirt", "#", "Protein Ocean", 200.0, 9 },
                    { 27, "Erkek Tshirt", "#", "Swiss", 200.0, 9 },
                    { 28, "Erkek Tshirt", "#", "Hardline", 200.0, 10 },
                    { 29, "Erkek Tshirt", "#", "Protein Ocean", 200.0, 10 },
                    { 30, "Erkek Tshirt", "#", "Swiss", 200.0, 10 },
                    { 31, "Erkek Tshirt", "#", "Hardline", 200.0, 11 },
                    { 32, "Erkek Tshirt", "#", "Protein Ocean", 200.0, 11 },
                    { 33, "Erkek Tshirt", "#", "Swiss", 200.0, 11 },
                    { 34, "Erkek Tshirt", "#", "Hardline", 200.0, 12 },
                    { 35, "Erkek Tshirt", "#", "Protein Ocean", 200.0, 12 },
                    { 36, "Erkek Tshirt", "#", "Swiss", 200.0, 12 },
                    { 37, "Erkek Tshirt", "#", "Hardline", 200.0, 13 },
                    { 38, "Erkek Tshirt", "#", "Protein Ocean", 200.0, 13 },
                    { 39, "Erkek Tshirt", "#", "Swiss", 200.0, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
