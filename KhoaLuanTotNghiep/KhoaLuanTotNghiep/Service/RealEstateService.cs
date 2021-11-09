using Gremlin.Net.Process.Traversal;
using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.Enum;
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
    public class RealEstateService : IRealEstate
    {
        private readonly ApplicationDbContext _dbContext;

        public RealEstateService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<ICollection<RealEstateModel>> GetAllAsync()
        {
            var queryable = _dbContext.realEstates.Include(p => p.category).Include(p => p.user).AsQueryable();
            var product = await queryable.Select(p => new RealEstateModel
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
                    acreage = p.Acgreage,
                    Slug = p.Slug,
                    Approve = p.Approve,
                    Status = p.Status,
                    PhoneNumber = Int32.Parse(p.user.PhoneNumber),
                    CreateTime = p.CreateTime,
                    UpdateTime = p.UpdateTime,
                    Location = p.Location,
                }).ToListAsync();
            return product;
            
        }

        public async Task<RealEstateModel> CreateRealEstatesAsync(RealEstateModel realEstateModel)
        {
            var realEstate = await _dbContext.categories.FirstOrDefaultAsync(p => p.CategoryID == realEstateModel.CategoryID);
            if (realEstate == null)
            {
                throw new Exception("Have not Category");
            }
            realEstateModel.RealEstateID = Guid.NewGuid().ToString();
            var Model = new RealEstate
            {
                RealEstateID = realEstateModel.RealEstateID,
                CategoryID = realEstateModel.CategoryID,
                UserID = realEstateModel.UserID,
                ReportID = realEstateModel.ReportID,
                Title = realEstateModel.Title,
                Price = realEstateModel.Price,
                Image = realEstateModel.Image,
                Description = realEstateModel.Description,
                Acgreage = realEstateModel.acreage,
                Slug = realEstateModel.Slug,
                Approve = (int)StateApprove.FALSE,
                Status = realEstateModel.Status,
                Location = realEstateModel.Location,
            };
            var create = _dbContext.Add(Model);
            var result = _dbContext.SaveChanges();
            if (result > 0)
            {
                return realEstateModel;
            }
            throw new Exception("Create News Fail");
        }

        public async Task<RealEstateModel> GetByIdAsync(string id)
        {
            
            var queryable = _dbContext.realEstates.Include(p => p.category).Include(p => p.user).AsQueryable();
            queryable = queryable.Where(p => p.RealEstateID == id);
            var list = await queryable.Select(p =>  new RealEstateModel
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
                   acreage = p.Acgreage,
                   Slug = p.Slug,
                   Approve = p.Approve,
                   Status = p.Status,
                   PhoneNumber = Int32.Parse(p.user.PhoneNumber),
                   //Rating = p.Rates.ToList(),
                   Location = p.Location,
               }).FirstOrDefaultAsync();
            return list;
        }

        public async Task<IEnumerable<RealEstatefromCategory>> GetByCategoryAsync(string categoryname)
        {
            var products = await _dbContext.realEstates.Include(p => p.category)
                .Where(p => p.category.CategoryName == categoryname)
                .Select(p =>
           
                new RealEstatefromCategory
                 {                 
                     Title = p.Title,
                     Description = p.Description,
                     Price = p.Price,
                     Image = p.Image,
                     CategoryName = p.category.CategoryName
                 }).ToListAsync();

            return products;
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

        public async Task<RealEstateModel> UpdateRealEstateAsync(string id, RealEstateModel realEstateModel)
        {
            var realEstate = await _dbContext.realEstates.FirstOrDefaultAsync(x => x.RealEstateID == id);
            if (realEstate == null)
            {
                throw new Exception("Have not NewsID");
            }
            realEstateModel.RealEstateID = Guid.NewGuid().ToString();
            realEstate.Title = realEstateModel.Title;
            realEstate.Approve = realEstateModel.Approve;
            var result = await _dbContext.SaveChangesAsync();
            if (result > 0)
            {
                return realEstateModel;
            }
            throw new Exception("Update  fail");
        }

        public async Task<bool> DeleteRealEstateModelAsync(string id)
        {
            var realEstate = await _dbContext.realEstates.FirstOrDefaultAsync(x => x.RealEstateID == id);
            if (realEstate == null)
            {
                throw new Exception("Have not RealEstate");
            }
            var delete = _dbContext.Remove(realEstate);
            var result = _dbContext.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            throw new Exception("Delete fail");
        }
    }
}
