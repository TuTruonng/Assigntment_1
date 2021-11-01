using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareModel
{
    public class RateResponse
    {
        public int IdRate { get; set; }
        public string ProductId { get; set; }

        public int value { get; set; }

        public DateTime RatingDate { get; set; }

        public string UserId { get; set; }
    }
}
