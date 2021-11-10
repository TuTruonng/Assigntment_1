using KhoaLuanTotNghiep_BackEnd.Controllers;
using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using ShareModel;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KhoaLuanTotNghiep_UnitTest.Controller
{
    public class RealEstateControllerTest : IClassFixture<SqliteMemory>
    {
        private readonly SqliteMemory _fixture;
        public RealEstateControllerTest(SqliteMemory fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }
        [Fact]
        public async Task Create_Success()
        {
            var mock = new Mock<IRealEstate>();
            Mock<ISession> sessionMock = new Mock<ISession>();
            var real = new RealEstateModel
            {
                //RealEstateID = Guid.NewGuid().ToString(),
                CategoryID = Guid.NewGuid().ToString(),
                UserID = Guid.NewGuid().ToString(),
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
            //var assetmodel = new RealEstateModel();
            mock.Setup(m => m.CreateRealEstatesAsync(It.IsAny<RealEstateModel>())).ReturnsAsync(real);
            var realController = new RealEstateController(mock.Object);
            realController.ControllerContext.HttpContext = new DefaultHttpContext();
            realController.ControllerContext.HttpContext.Session = sessionMock.Object;
            var result = await realController.CreateAsync(real);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task Update_Success()
        {
            var mock = new Mock<IRealEstate>();
            Mock<ISession> sessionMock = new Mock<ISession>();
            var real = new RealEstateModel
            {
                RealEstateID = "10",
                CategoryID = Guid.NewGuid().ToString(),
                UserID = Guid.NewGuid().ToString(),
                CategoryName = "Nha Cho Thue",
                ReportID = "",
                Title = "Bán Nhà Nguyên Căn",
                Price = "2500000",
                Image = "https://res.cloudinary.com/dusq8k6rj/image/upload/v1636363996/Source/t3nougdorreex9y7yp4v.jpg",
                Description = "abc",
                acreage = "95 tỷ",
                Slug = "abc",
                Approve = 1,
                Status = "Con",
                PhoneNumber = 0352787585,
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Location = "118 Le Loi",
            };
            //var assetmodel = new AssetModel();
            mock.Setup(x => x.UpdateRealEstateAsync(It.IsAny<string>(), It.IsAny<RealEstateModel>())).ReturnsAsync(real);
            var assetContr = new RealEstateController(mock.Object);
            assetContr.ControllerContext.HttpContext = new DefaultHttpContext();
            assetContr.ControllerContext.HttpContext.Session = sessionMock.Object;
            var result = await assetContr.UpdateAsync(real.RealEstateID, real);
            Assert.NotNull(result);
        }
        [Fact]
        public async Task Delete_Success()
        {
            var mock = new Mock<IRealEstate>();
            string assetid = Guid.NewGuid().ToString();
            mock.Setup(x => x.DeleteRealEstateModelAsync(It.IsAny<string>())).ReturnsAsync(true);
            var assetContr = new RealEstateController(mock.Object);
            var result = await assetContr.Delete(assetid);
            Assert.IsType<OkObjectResult>(result.Result);
        }
        [Fact]
        public async Task Get_Success()
        {
            var mock = new Mock<IRealEstate>();
            string assetid = Guid.NewGuid().ToString();
            RealEstateModel real = new RealEstateModel();
            mock.Setup(x => x.GetByIdAsync(It.IsAny<string>())).ReturnsAsync(real);
            var assetContr = new RealEstateController(mock.Object);
            var result = await assetContr.GetById(assetid);
            Assert.IsType<OkObjectResult>(result.Result);
            Assert.NotNull(result);
        }

    }
}
