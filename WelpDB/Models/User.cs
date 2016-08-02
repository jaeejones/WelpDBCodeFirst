using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WelpDB.Models
{
    public class User
    {
        public int UserID { get; set; }
        [MaxLength(50)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }


        //Navigation properties 
        public virtual ICollection<Rating> Ratings { get; set; }
        public virtual ICollection<Business> Business { get; set; }
       
    }
}