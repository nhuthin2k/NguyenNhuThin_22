using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenNhuThin_22.Models
{
    public partial class LTQLDbcontext : DbContext
    {
        public LTQLDbcontext()
            : base("name=LTQLDbcontext")
        {
        }

        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        

        
    }
}
