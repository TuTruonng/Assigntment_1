using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Service
{
    public interface IProductApiClient
    {
        Task<IList<RealEstateModel>> GetProducts();

        Task<RealEstateModel> GetProductById(int id);

        Task<IList<RealEstatefromCategory>> GetProductByCategory(string categoryName);

        Task<bool> Rating(int productId, int values);
    }
}
