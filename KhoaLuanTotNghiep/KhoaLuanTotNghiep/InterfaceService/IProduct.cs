using KhoaLuanTotNghiep_BackEnd.Models;
using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.InterfaceService
{
    public interface IProduct
    {
        Task<RealEstate> CreateAsync(RealEstateCreateRequest model);

        Task<RealEstate> DeleteAsync(int id);

        Task<IEnumerable<RealEstateModel>> GetAllAsync();

        
    }
}
