using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareModel
{
    public class RateRequest
    {
        public int id { get; set; }
        public string ProductId { get; set; }

        public int Value { get; set; }

        public string Comments { get; set; }

        public DateTime RatingDate { get; set; }

        public string UserId { get; set; }
    }
}
