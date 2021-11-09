using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Service
{
    public interface IRealEstateApiClient
    {
        Task<IEnumerable<RealEstateModel>> GetProducts();

        Task<RealEstateModel> GetProductById(string id);

        Task<IEnumerable<RealEstatefromCategory>> GetProductByCategory(string category);
        Task<IList<RateResponse>> GetListRatings();

        Task<bool> Rating(string productId, int values);
    }
}
