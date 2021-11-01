using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KhoaLuanTotNghiep_BackEnd.Models
{
    public class Rates
    {
        [Key]
        public int IDRate { get; set; }

        public int Value { get; set; }

        public string RealEstateID { get; set; }

        public string UserId { get; set; }
    }
}
