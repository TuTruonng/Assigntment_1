using KhoaLuanTotNghiep_BackEnd.Controllers;
using KhoaLuanTotNghiep_BackEnd.Interface;
using Moq;
using ShareModel;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KhoaLuanTotNghiep_UnitTest.Controller
{
    public class CategoryControllerTest : IClassFixture<SqliteMemory>
    {
        private readonly SqliteMemory _fixture;

        public CategoryControllerTest(SqliteMemory fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }

        [Fact]
        public async Task GetCate_Success()
        {
            var mockCateService = new Mock<Icategory>();
            var cateModel = new CategoryModel
            {
                CategoryID = Guid.NewGuid().ToString(),
                CategoryName = "Nhà Đất Bán",
                Description = "Bán Nhà Đất"
            };
            mockCateService.Setup(m => m.GetListCategoryAsync());
            var cateSer = new CategoryController(mockCateService.Object);
            var result = await cateSer.GetListAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async Task CreateCate_Success()
        {
            var mockCateService = new Mock<Icategory>();
            var cateModel = new CategoryModel
            {
                CategoryID = Guid.NewGuid().ToString(),
                CategoryName = "Nhà Đất Bán",
                Description = "Bán Nhà Đất"
            };
            mockCateService.Setup(m => m.CreateCategoryAsync(It.IsAny<CategoryModel>())).ReturnsAsync(cateModel);
            var cateSer = new CategoryController(mockCateService.Object);
            var result = await cateSer.CreateAsync(cateModel);
            Assert.NotNull(result);
        }
    }
}
