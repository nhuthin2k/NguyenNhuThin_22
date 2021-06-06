namespace NguyenNhuThin_22.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tab1s
    {
        [Key]
        public string MaHH { get; set; }

        public string TenHH { get; set; }

        [StringLength(15)]
        public string ID { get; set; }
    }
}
