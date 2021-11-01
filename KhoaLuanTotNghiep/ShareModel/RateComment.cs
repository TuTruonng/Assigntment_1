using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareModel
{
    public class RateComment
    {
        public int id { get; set; }
        public string ProductId { get; set; }

        public int Value { get; set; }

        public string Comments { get; set; }

        public DateTime RatingDate { get; set; }

        public string UserId { get; set; }
    }
}
