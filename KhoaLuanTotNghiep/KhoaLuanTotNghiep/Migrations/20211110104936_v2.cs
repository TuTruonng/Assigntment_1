using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhoaLuanTotNghiep_BackEnd.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "realEstates",
                columns: new[] { "RealEstateID", "Acgreage", "Approve", "CategoryID", "CreateTime", "Description", "Image", "Location", "Price", "ReportID", "Slug", "Status", "Title", "UpdateTime", "UserID" },
                values: new object[,]
                {
                    { "1", "95", 1, "1", new DateTime(2021, 11, 10, 17, 49, 34, 742, DateTimeKind.Local).AddTicks(162), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(529), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" },
                    { "2", "95", 1, "1", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1945), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1968), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" },
                    { "3", "95", 1, "2", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1974), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1976), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" },
                    { "4", "95", 1, "2", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1980), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1982), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" },
                    { "5", "95", 1, "3", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1986), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1988), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" },
                    { "6", "95", 1, "3", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1991), "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park", "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg", "50 Lê Lợi", "19 tỷ", null, "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US", "Đang Bán", "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT", new DateTime(2021, 11, 10, 17, 49, 34, 743, DateTimeKind.Local).AddTicks(1993), "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "realEstates",
                keyColumn: "RealEstateID",
                keyValue: "6");
        }
    }
}
