using KhoaLuanTotNghiep.Data;
using KhoaLuanTotNghiep_BackEnd.Models;
using KhoaLuanTotNghiep_BackEnd.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Service
{
    public class RealEstateCommentService
    {
        private readonly ApplicationDbContext _dbContext;

        public RealEstateCommentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<RealEstateComment> GetCommentRating(RealEstateCommentVM vm)
        {
            var comment = vm.Comment;
            var realEstateId = vm.RealEstateID;
            var rating = vm.Rating;

            RealEstateComment rComment = new RealEstateComment()
            {
                RealEstatesId = realEstateId,
                Comments = comment,
                Rating = rating,
                PublishedDate = DateTime.Now
            };

            _dbContext.realEstateComments.Add(rComment);
            _dbContext.SaveChanges();

            return rComment;
        }
    }
}
