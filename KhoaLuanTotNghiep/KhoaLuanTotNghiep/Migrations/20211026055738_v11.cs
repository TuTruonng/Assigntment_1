using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_realEstateComments_realEstates_RealEstatesRealEstateID",
                table: "realEstateComments");

            migrationBuilder.DropIndex(
                name: "IX_realEstateComments_RealEstatesRealEstateID",
                table: "realEstateComments");

            migrationBuilder.DropColumn(
                name: "RealEstatesRealEstateID",
                table: "realEstateComments");

            migrationBuilder.AlterColumn<string>(
                name: "RealEstatesId",
                table: "realEstateComments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_realEstateComments_RealEstatesId",
                table: "realEstateComments",
                column: "RealEstatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_realEstateComments_realEstates_RealEstatesId",
                table: "realEstateComments",
                column: "RealEstatesId",
                principalTable: "realEstates",
                principalColumn: "RealEstateID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_realEstateComments_realEstates_RealEstatesId",
                table: "realEstateComments");

            migrationBuilder.DropIndex(
                name: "IX_realEstateComments_RealEstatesId",
                table: "realEstateComments");

            migrationBuilder.AlterColumn<int>(
                name: "RealEstatesId",
                table: "realEstateComments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RealEstatesRealEstateID",
                table: "realEstateComments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_realEstateComments_RealEstatesRealEstateID",
                table: "realEstateComments",
                column: "RealEstatesRealEstateID");

            migrationBuilder.AddForeignKey(
                name: "FK_realEstateComments_realEstates_RealEstatesRealEstateID",
                table: "realEstateComments",
                column: "RealEstatesRealEstateID",
                principalTable: "realEstates",
                principalColumn: "RealEstateID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
