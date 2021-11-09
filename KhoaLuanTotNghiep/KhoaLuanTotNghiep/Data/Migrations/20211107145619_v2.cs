using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 562, DateTimeKind.Local).AddTicks(6227), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(5937), "1" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6630), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6639), "1" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6643), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6645), "1" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6649), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6651), "1" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6654), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6656), "1" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6659), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6660), "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 44, DateTimeKind.Local).AddTicks(8516), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8198), "49170aba-addd-4e0f-96aa-5749565d3dbe" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8775), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8784), "49170aba-addd-4e0f-96aa-5749565d3dbe" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8789), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8791), "49170aba-addd-4e0f-96aa-5749565d3dbe" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8795), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8796), "49170aba-addd-4e0f-96aa-5749565d3dbe" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8800), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8801), "49170aba-addd-4e0f-96aa-5749565d3dbe" });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6",
                columns: new[] { "CreateTime", "UpdateTime", "UserID" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8804), new DateTime(2021, 11, 7, 21, 54, 57, 45, DateTimeKind.Local).AddTicks(8806), "49170aba-addd-4e0f-96aa-5749565d3dbe" });
        }
    }
}
