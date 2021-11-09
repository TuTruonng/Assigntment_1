using Microsoft.Extensions.Configuration;
using ShareModel;
using ShareModel.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Service
{
    public class CategoryApiClient : ICategoryApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        //private readonly IConfiguration _configuration;

        public CategoryApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
           // _configuration = configuration;

        }

        public async Task<IList<CategoryModel>> GetCategories()
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync(EndpointConstants.GET_CATEGORIES);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<CategoryModel>>();

        }
    }
}
