using KhoaLuanTotNghiep_BackEnd.Models;
using KhoaLuanTotNghiep_BackEnd.Service;
using ShareModel;
using System;
using System.Threading.Tasks;
using Xunit;

namespace KhoaLuanTotNghiep_UnitTest.Services
{
    public class CategoryServiceTest : IClassFixture<SqliteMemory>
    {

        private readonly SqliteMemory _fixture;

        public CategoryServiceTest(SqliteMemory fixture)
        {
            _fixture = fixture;
            _fixture.CreateDatabase();
        }
        [Fact]
        public async Task CreateCategory_Failed()
        {
            var dbContext = _fixture.Context;
            var categoryId = Guid.NewGuid().ToString();

            // add mock data
            var assetTest = new CategoryModel()
            {
                CategoryID = categoryId,
                CategoryName = "Test",
                Description = "T",
            };
            await dbContext.SaveChangesAsync();
            // create repo
            var assetRepo = new CategoryService(dbContext);
            var assetNew = await assetRepo.CreateCategoryAsync(assetTest);
            // test
            Assert.NotNull(assetNew);
        }

        [Fact]
        public async Task GetCategory_Success()
        {
            var dbContext = _fixture.Context;
            dbContext.categories.Add(
            new Category
            {
                CategoryID = Guid.NewGuid().ToString(),
                Description = "",
                CategoryName = "Nhà Đất Bán"
            });
            await dbContext.SaveChangesAsync();

            var category = new CategoryService(dbContext);
            var result = category.GetListCategoryAsync();
            Assert.Null(result);
        }
    }
}
