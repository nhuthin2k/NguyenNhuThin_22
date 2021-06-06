using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenNhuThin_22.Models
{
    public class SanPham
    {
        
        [Key]
            public string MaSanPham { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }
        [Key]
        public int MaNhaCungCap { get; set; }
    }
}