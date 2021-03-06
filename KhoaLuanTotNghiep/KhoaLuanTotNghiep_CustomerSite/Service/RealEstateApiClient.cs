using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Service
{
    public class RealEstateApiClient : IRealEstateApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;

        public RealEstateApiClient(IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            _configuration = configuration;
        }
        public async Task<IList<RealEstateModel>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") + "RealEstate");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<RealEstateModel>>();
        }

        public async Task<RealEstateModel> GetProductById(string id)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") + "RealEstate/" + id);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<RealEstateModel>();
        }

        public async Task<IList<RealEstatefromCategory>> GetProductByCategory(string categoryName)
        {
            var client = _httpClientFactory.CreateClient();
            var response = await client.GetAsync(_configuration.GetValue<string>("Backend") + "RealEstate/category=" + categoryName);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<RealEstatefromCategory>>();
        }

        public Task<bool> Rating(int productId, int values)
        {
            throw new NotImplementedException();
        }

        //public async Task<bool> Rating(int productId, int values)
        //{
        //    var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);
        //    var client = _httpClientFactory.CreateClient();
        //    client.UseBearerToken(accessToken);
        //    var rateRequest = new RateShare
        //    {
        //        ProductId = productId,
        //        value = values
        //    };
        //    var json = JsonConvert.SerializeObject(rateRequest);
        //    var data = new StringContent(json, Encoding.UTF8, "application/json");

        //    var res = await client.PostAsync(_configuration.GetValue<string>("Backend") + "api/Rate", data);

        //    res.EnsureSuccessStatusCode();

        //    var result = await res.Content.ReadAsAsync<bool>();

        //    return result;
        //}
    }
}
