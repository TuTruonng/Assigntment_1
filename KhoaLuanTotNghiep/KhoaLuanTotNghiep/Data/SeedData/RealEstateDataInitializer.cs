using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Data.SeedData
{
    public static class RealEstateDataInitializer
    {
        public static void SeedRealEstateData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RealEstate>().HasData(
                new RealEstate
                {
                    RealEstateID = "1",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "1",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = "2",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "1",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634380024/leduyen/rv7lrwnztkzvnzrqltha.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = "3",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "2",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = "4",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "2",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379964/leduyen/p9zypdbshv8spvwl0m0o.png",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = "5",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "3",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                },
                new RealEstate
                {
                    RealEstateID = "6",
                    UserID = "9ccb5f39-7b81-47fa-a1cd-2e18d1ad7a8b",
                    CategoryID = "3",
                    Title = "RA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐTRA HÀNG DÃY SHOPHOUSE CHÂN THÁP TÀI CHÍNH DỰ ÁN THE MANOR CETRAL PARK KINH DOANH CỰC TỐT",
                    Price = "19 tỷ",
                    Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1634379264/leduyen/mmgcl8rhah6i2nzfuef3.jpg",
                    Description = "Bảng giá các căn giá tốt nhất thị trường của dự án The Manor Central Park: Mua trực tiếp chủ đầu tư Bitexco Group.Bảng hàng shophouse các căn vị trí đẹp của giai đoạn 1 và giai đoạn 2 của dự án The Manor Central Park",
                    Acgreage = "95",
                    Slug = "https://www.google.com/maps/place/20%C2%B058'31.1%22N+105%C2%B048'51.7%22E/@20.975292,105.814369,15z/data=!4m5!3m4!1s0x0:0x0!8m2!3d20.9752922!4d105.8143692?hl=en-US",
                    Approve = 1,
                    Status = "Đang Bán",
                    Location = "50 Lê Lợi",
                    CreateTime = DateTime.Now,
                    UpdateTime = DateTime.Now,
                }
            );
        }
    }
}
