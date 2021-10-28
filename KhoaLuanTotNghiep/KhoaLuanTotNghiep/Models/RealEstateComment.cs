using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Models
{
    public class RealEstateComment
    {
        public int Id { get; set; }

        public string Comments { get; set; }

        public DateTime PublishedDate { get; set; }

        public string RealEstatesId { get; set; }

        public RealEstate RealEstates { get; set; }

        public int Rating { get; set; }
    }
}
