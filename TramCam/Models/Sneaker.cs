namespace TramCam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sneaker")]
    public partial class Sneaker
    {
        [Key]
        public int MaGiay { get; set; }

        public int? MaLoai { get; set; }

        [StringLength(50)]
        public string TenGiay { get; set; }

        public decimal? Gia { get; set; }

        [StringLength(50)]
        public string Hinh { get; set; }

        public string MoTa { get; set; }

        public virtual Type Type { get; set; }
    }
}
