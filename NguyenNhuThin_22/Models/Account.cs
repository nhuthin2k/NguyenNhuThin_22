using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenNhuThin_22.Models
{
    public class Account
    {
        [Key]
        public string UserName { get; set; }
        [StringLength(20)]
        public string PassWord { get; set; }
        public string RoleID { get; set; }
    }
}