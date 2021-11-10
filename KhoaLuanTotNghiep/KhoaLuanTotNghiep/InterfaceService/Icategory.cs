
using ShareModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Interface
{
    public interface Icategory
    {
        Task<ICollection<CategoryModel>> GetListCategoryAsync();

        Task<CategoryModel> CreateCategoryAsync(CategoryModel categoryModel);

        Task<CategoryModel> UpdateCategoryAsync(string id, CategoryModel categoryModel);

        Task<bool> DeleteCategoryAsync(string id);
    }
}
