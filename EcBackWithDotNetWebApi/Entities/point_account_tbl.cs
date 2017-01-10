namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_account_tbl")]
    public partial class point_account_tbl
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        public int balance_point_0 { get; set; }

        public int balance_point_1 { get; set; }

        public int balance_point_2 { get; set; }

        public int balance_point_3 { get; set; }

        public int balance_point_4 { get; set; }

        public int balance_point_5 { get; set; }

        public int balance_point_6 { get; set; }

        public int balance_point_7 { get; set; }

        public int balance_point_8 { get; set; }

        public int balance_point_9 { get; set; }

        public int balance_point_10 { get; set; }

        public int balance_point_11 { get; set; }

        public int balance_point_12 { get; set; }

        [Required]
        [StringLength(36)]
        public string lockid { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
