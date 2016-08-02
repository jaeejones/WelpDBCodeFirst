using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Business
    {
        // properties
        public int BusinessID { get; set; }
        [MaxLength(50)]
        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        [MaxLength(100)]
        public string Address { get; set; }
        [MaxLength(100)]
        public string Hours { get; set; }
        [MaxLength(50)]
        public string Phone { get; set; }
        public string Menu { get; set; }
        public int UserID { get; set; }

        // navigation properties
        public virtual BusinessType BusinessType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
