using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.AspNetCore.Http;
using ShareModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Service
{
    public class RateService : IRate
    {
        private readonly ApplicationDbContext _applicationDb;

        public RateService(ApplicationDbContext applicationDb)
        {
            _applicationDb = applicationDb;
        }


        public async Task<CreateRatingRequest> CreateRate(CreateRatingRequest rateShare)
        {
            var rates = new Rates
            {
                RealEstateID = rateShare.ProductId,
                Value = rateShare.value
            };
            //if (rateShare.ProductId == null)
            //{
            //    //var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //    //rates.UserId = userId.ToString();
            //    throw new Exception("Add Fail");

            //}
            _applicationDb.Add(rates);

            var result = await _applicationDb.SaveChangesAsync();
            if (result > 0)
            {
                return rateShare;
            }
            throw new Exception("Create Rate Fail");
        }

        public async Task<IEnumerable<RateResponse>> GetListRatingAsync(string id)
        {
            var queryable = _applicationDb.rates.AsQueryable();
            queryable = queryable.Where(r => r.RealEstateID == id);
            var list_rate = await queryable.Select(r => new RateResponse
            {
                IdRate = r.IDRate,
                value = r.Value,
                RatingDate = DateTime.Now,
                ProductId = r.RealEstateID,
                UserId = r.UserId
            }).ToListAsync();
            return list_rate;
        }
    }
}
