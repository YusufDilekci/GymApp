using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class BigMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 5,
                column: "BranchName",
                value: "Futbol");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 13,
                column: "DescriptionName",
                value: "Futbol-1weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 14,
                column: "DescriptionName",
                value: "Futbol-2weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 15,
                column: "DescriptionName",
                value: "Futbol-3weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "ImageName",
                value: "futbol1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "ImageName",
                value: "futbol2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "ImageName",
                value: "futbol3.jpg");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 7,
                column: "TrainerDescription",
                value: "Futbol - 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "BranchId",
                keyValue: 5,
                column: "BranchName",
                value: "Coaching");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 13,
                column: "DescriptionName",
                value: "Coaching-1weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 14,
                column: "DescriptionName",
                value: "Coaching-2weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Descriptions",
                keyColumn: "DescriptionId",
                keyValue: 15,
                column: "DescriptionName",
                value: "Coaching-3weıpüqrıpoıqwmskdf");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 13,
                column: "ImageName",
                value: "coaching1.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 14,
                column: "ImageName",
                value: "coaching2.jpg");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: 15,
                column: "ImageName",
                value: "coaching3.jpg");

            migrationBuilder.UpdateData(
                table: "Trainers",
                keyColumn: "TrainerId",
                keyValue: 7,
                column: "TrainerDescription",
                value: "Coaching - 1");
        }
    }
}
