using KhoaLuanTotNghiep_CustomerSite.Extentions;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Newtonsoft.Json;
using ShareModel;
using ShareModel.Constant;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_CustomerSite.Service
{
    public class RealEstateApiClient : IRealEstateApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IConfiguration _configuration;

        public RealEstateApiClient(IHttpContextAccessor httpContextAccessor, IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
            //_configuration = configuration;
        }
        public async Task<IEnumerable<RealEstateModel>> GetProducts()
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync(EndpointConstants.GET_REALESTATES);
            response.EnsureSuccessStatusCode();
            var list = await response.Content.ReadAsAsync<IEnumerable<RealEstateModel>>();
            return list;
        }

        public async Task<RealEstateModel> GetProductById(string id)
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_REALESTATES}\\{id}");
            response.EnsureSuccessStatusCode();
            var realestate = await response.Content.ReadAsAsync<RealEstateModel>();
            return realestate;
        }

        public async Task<IEnumerable<RealEstatefromCategory>> GetProductByCategory(string category)
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync($"{EndpointConstants.GET_REALESTATES}\\{"category=" + category}");
            response.EnsureSuccessStatusCode();
            var real_category = await response.Content.ReadAsAsync<IEnumerable<RealEstatefromCategory>>();
            return real_category;
        }

        public async Task<IList<RateResponse>> GetListRatings()
        {
            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var response = await client.GetAsync(EndpointConstants.GET_RATES);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsAsync<IList<RateResponse>>();
        }

        public async Task<bool> Rating(string productId, int values)
        {
            //var accessToken = await _httpContextAccessor.HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken);

            //client.UseBearerToken(accessToken);

            var rateRequest = new CreateRatingRequest
            {
                ProductId = productId,
                value = values
            };
            var json = JsonConvert.SerializeObject(rateRequest);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient(ServiceConstants.BACK_END_NAMED_CLIENT);
            var res = await client.PostAsync(EndpointConstants.GET_RATES, data);

            res.EnsureSuccessStatusCode();

            return await Task.FromResult(true);
        }
    }
}
