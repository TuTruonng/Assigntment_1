using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.InterfaceService;
using KhoaLuanTotNghiep_BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Service
{
    public class ProductService : IProduct
    {
        private readonly ApplicationDbContext _dbContext;

        public ProductService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
      

        public async Task<RealEstate> CreateAsync(RealEstateCreateRequest model)
        {
            //var category = await _dbContext.categories.FirstOrDefaultAsync(x => x.CategoryName == categoryModel.CategoryName);
            var product = new RealEstate();
            model.CategoryID = product.CategoryID;
            model.Title = product.Title;
            model.Price = product.Price;
            model.Image = product.Image;
            _dbContext.Add(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

        public async Task<RealEstate> DeleteAsync(int id)
        {
            var product = await _dbContext.realEstates.FindAsync(id);
            if (product == null)
                return null;
            _dbContext.realEstates.Remove(product);
            await _dbContext.SaveChangesAsync();
            return product;
        }

      

        public async Task<IEnumerable<RealEstateModel>> GetAllAsync()
        {
            var product = await _dbContext.realEstates.Include(p => p.category).Select(p =>
                new RealEstateModel
                {
                    RealEstateID = p.RealEstateID,
                    CategoryID = p.CategoryID,
                    UserID = p.UserID,
                    CategoryName = p.category.CategoryName,
                    ReportID = p.ReportID,
                    Title = p.Title,
                    Price = p.Price,
                    Image = p.Image,
                    Description = p.Description,
                    Quantity = p.Quantity,
                    acreage = p.Acgreage,
                    Slug = p.Slug,
                    Approve = p.Approve,
                    Status = p.Status,
                    PhoneNumber = p.PhoneNumber,
                    Location = p.Location,
                }).ToListAsync();
            return product;
        }



    }
}
