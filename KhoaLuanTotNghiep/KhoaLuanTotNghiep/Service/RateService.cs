using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.AspNetCore.Http;
using ShareModel;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

namespace KhoaLuanTotNghiep_BackEnd.Service
{
    public class RateService : IRate
    {
        private readonly ApplicationDbContext _applicationDb;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RateService(ApplicationDbContext applicationDb, IHttpContextAccessor httpContextAccessor)
        {
            _applicationDb = applicationDb;
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<bool> CreateRate(CreateRatingRequest rateShare)
        {
            var rates = new Rates { RealEstateID = rateShare.ProductId, Value = rateShare.value };

            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            rates.UserId = userId.ToString();
            _applicationDb.Add(rates);
            await _applicationDb.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<RateResponse>> GetListRatingAsync()
        {
            var list_rate = await _applicationDb.rates
                .Select(r => new RateResponse
                {
                    IdRate = r.IDRate,
                    value = r.Value,
                    RatingDate = DateTime.Now,
                    ProductId = r.RealEstateID,
                    UserId = r.UserId
                })
                .ToListAsync();
            return list_rate;
        }
    }
}
