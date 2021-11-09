using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 871, DateTimeKind.Local).AddTicks(59), new DateTime(2021, 11, 7, 21, 58, 22, 871, DateTimeKind.Local).AddTicks(9927) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(558), new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(573), new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(578), new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(585), new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(591), new DateTime(2021, 11, 7, 21, 58, 22, 872, DateTimeKind.Local).AddTicks(592) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 562, DateTimeKind.Local).AddTicks(6227), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6630), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6643), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6649), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6654), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6659), new DateTime(2021, 11, 7, 21, 56, 18, 563, DateTimeKind.Local).AddTicks(6660) });
        }
    }
}
