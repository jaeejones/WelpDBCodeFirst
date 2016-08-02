using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WelpDB.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public short? StarReview { get; set; }
        public string TextReiew { get; set; }

        // navigation properties
        public virtual User User { get; set; }
        public virtual Business Business { get; set; }
    }
}