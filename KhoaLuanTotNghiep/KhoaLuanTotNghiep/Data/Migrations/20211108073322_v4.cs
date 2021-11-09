using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "news",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "news",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 502, DateTimeKind.Local).AddTicks(1705), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(1508) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2247), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2264), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2274), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2290), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6",
                columns: new[] { "CreateTime", "UpdateTime" },
                values: new object[] { new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2301), new DateTime(2021, 11, 8, 14, 33, 21, 503, DateTimeKind.Local).AddTicks(2306) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "news");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "news");

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
    }
}
