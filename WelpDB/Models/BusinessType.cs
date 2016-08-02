using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class BusinessType
    {
        // properties
        public int BusinessTypeID { get; set; }
        [MaxLength(50)]
        public string BusinessTypeName { get; set; }

        // navigation properties
        public virtual ICollection<Business> Businesses { get; set; }
    }
}