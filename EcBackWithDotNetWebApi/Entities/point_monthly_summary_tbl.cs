namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_monthly_summary_tbl")]
    public partial class point_monthly_summary_tbl
    {
        [Key]
        [StringLength(6)]
        public string year_month { get; set; }

        public byte status { get; set; }

        public int purchase_issuance_point { get; set; }

        public int etc_issuance_point { get; set; }

        public int use_point { get; set; }

        public int expiration_point { get; set; }

        public int total_issuance_point { get; set; }

        public int total_use_point { get; set; }

        public int total_expiration_point { get; set; }

        public int balance_point { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
