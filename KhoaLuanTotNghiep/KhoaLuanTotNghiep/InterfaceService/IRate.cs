using ShareModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.InterfaceService
{
    public interface IRate
    {
        Task<CreateRatingRequest> CreateRate(CreateRatingRequest rate);

        Task<IEnumerable<RateResponse>> GetListRatingAsync(string id);
    }
}
