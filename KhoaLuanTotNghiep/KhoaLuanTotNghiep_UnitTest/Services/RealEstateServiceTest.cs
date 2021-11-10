using KhoaLuanTotNghiep_BackEnd.Models;
using KhoaLuanTotNghiep_BackEnd.Service;
using ShareModel;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KhoaLuanTotNghiep_UnitTest.Services
{
    public class RealEstateServiceTest : IClassFixture<SqliteMemory>
    {
        private readonly SqliteMemory _fixture;

        public RealEstateServiceTest(SqliteMemory fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }
        [Fact]
        public async Task Create_Success()
        {
            var dbContext = _fixture.Context;
            var userId = Guid.NewGuid().ToString();
            var categoryId = Guid.NewGuid().ToString();
            dbContext.Users.Add(
                new User()
                {
                    Id = userId,
                    FullName = "TTT",
                    Salary = 9,
                    Point = 9
                });
            dbContext.categories.Add(
                new Category()
                {
                    CategoryID = categoryId,
                    CategoryName = "Du An",
                    Description = "ABC"
                });
            await dbContext.SaveChangesAsync();

            var real = new RealEstateModel()
            {
                CategoryID = categoryId,
                UserID = userId,
                CategoryName = "Nha Dat Ban",
                ReportID = "",
                Title = "Bán Nhà Nguyên Căn",
                Price = "1000000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = 0352787585,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "50 Le Loi",
            };
            var assetRepo = new RealEstateService(dbContext);
            var assetNew = await assetRepo.CreateRealEstatesAsync(real);

            Assert.NotNull(assetNew);
        }

        [Fact]
        public async Task Update_Success()
        {
            // initial mock data
            var dbContext = _fixture.Context;
            var prevuserId = Guid.NewGuid().ToString();
            var prevreportgoryId = Guid.NewGuid().ToString();
            var prevcategoryId = Guid.NewGuid().ToString();
            var prevcatename = "Du An";
            string phone = "0352787585";
            // add mock data
            dbContext.Users.Add(
                new User()
                {
                    Id = prevuserId,
                    FullName = "TTT",
                    Salary = 9,
                    Point = 9,
                    PhoneNumber = phone
                });
            dbContext.categories.Add(
                new Category()
                {
                    CategoryID = prevcategoryId,
                    CategoryName = prevcatename,
                    Description = "ABC"
                });
            await dbContext.SaveChangesAsync();
            var real = new RealEstateModel()
            {
                CategoryID = prevcategoryId,
                UserID = prevuserId,
                CategoryName = prevcatename,
                ReportID = prevreportgoryId,
                Title = "Bán Nhà Nguyên Căn",
                Price = "1000000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = int.Parse(phone),
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "50 Le Loi",
            };
            // create repo
            var assetRepo = new RealEstateService(dbContext);
            var assetNew = await assetRepo.CreateRealEstatesAsync(real);

            var nextcateId = Guid.NewGuid().ToString();
            var nextcate = "Nhà Trọ";
            dbContext.categories.Add(
               new Category()
               {
                   CategoryID = nextcateId,
                   CategoryName = nextcate,
                   Description = "def"
               });
            var realTest = new RealEstateModel()
            {
                RealEstateID = assetNew.RealEstateID,
                CategoryID = nextcateId,
                UserID = real.UserID,
                CategoryName = nextcate,
                ReportID = prevreportgoryId,
                Title = "Bán Nhà Nguyên Căn",
                Price = "1000000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = 0352787586,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "90 Le Loi",
            };
            var assetupdate = await assetRepo.UpdateRealEstateAsync(assetNew.RealEstateID, realTest);
            Assert.NotNull(assetupdate);

        }
        [Fact]
        public async Task Delete_Success()
        {
            var dbContext = _fixture.Context;
            var prevuserId = Guid.NewGuid().ToString();
            var prevcategoryId = Guid.NewGuid().ToString();
            // add mock data
            dbContext.Users.Add(
                 new User()
                 {
                     Id = prevuserId,
                     FullName = "TTT",
                     Salary = 9,
                     Point = 9
                 });
            dbContext.categories.Add(
                new Category()
                {
                    CategoryID = prevcategoryId,
                    CategoryName = "Du An",
                    Description = "ABC"
                });
            await dbContext.SaveChangesAsync();
            //
            var real = new RealEstateModel()
            {
                CategoryID = prevcategoryId,
                UserID = prevuserId,
                CategoryName = "Nha Dat Ban",
                ReportID = "",
                Title = "Bán Nhà Nguyên Căn",
                Price = "1000000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = 0352787585,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "50 Le Loi",
            };
            // create repo
            var assetRepo = new RealEstateService(dbContext);
            var assetNew = await assetRepo.CreateRealEstatesAsync(real);

            var result = await assetRepo.DeleteAsync(assetNew.RealEstateID);
            Assert.NotNull(result);
            //Assert.Null(asset);
        }

        [Fact]
        public async Task GetById_Success()
        {
            var dbContext = _fixture.Context;
            var prevuserId = Guid.NewGuid().ToString();
            var prevcategoryId = Guid.NewGuid().ToString();
            var prevreportgoryId = Guid.NewGuid().ToString();
            var prevcatename = "Du An";
            string phone = "0352787585";
            // add mock data
            dbContext.Users.Add(
                 new User()
                 {
                     Id = prevuserId,
                     FullName = "TTT",
                     Salary = 9,
                     Point = 9,
                     PhoneNumber = phone
                 });
            dbContext.categories.Add(
                new Category()
                {
                    CategoryID = prevcategoryId,
                    CategoryName = prevcatename,
                    Description = "ABC"
                });
            //dbContext.reports.Add(
            // new Report()
            // {
            //     ReportID = prevreportgoryId
            // });

            await dbContext.SaveChangesAsync();
            var real = new RealEstateModel()
            {
                CategoryID = prevcategoryId,
                UserID = prevuserId,
                CategoryName = prevcatename,
                ReportID = prevreportgoryId,
                Title = "Bán Nhà Nguyên Căn",
                Price = "1000000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = Int32.Parse(phone),
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "50 Le Loi",
            };
            // create repo
            var assetRepo = new RealEstateService(dbContext);
            var assetNew = await assetRepo.CreateRealEstatesAsync(real);

            var asset = await assetRepo.GetByIdAsync(assetNew.RealEstateID);

            //await Assert.ThrowsAsync<Exception>(() => assetRepo.GetByIdAsync(Guid.NewGuid().ToString()));
            Assert.True(asset.RealEstateID.Equals(assetNew.RealEstateID));
            Assert.NotNull(asset);
            Assert.IsType<RealEstateModel>(asset);
        }
    }
}
