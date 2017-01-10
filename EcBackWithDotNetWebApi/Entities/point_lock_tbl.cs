namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_lock_tbl")]
    public partial class point_lock_tbl
    {
        [Key]
        [StringLength(36)]
        public string lockid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime lock_date { get; set; }

        public int lock_point { get; set; }

        [Required]
        [StringLength(26)]
        public string orderid { get; set; }

        public DateTime tentative_order_date { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
