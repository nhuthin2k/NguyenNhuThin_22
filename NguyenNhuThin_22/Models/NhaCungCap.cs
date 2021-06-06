using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenNhuThin_22.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        public int MaNhaCungCap { get; set; }

        [StringLength(50)]
        public string TenNhaCungCap { get; set; }

    }
}