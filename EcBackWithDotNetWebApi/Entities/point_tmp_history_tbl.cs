namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_tmp_history_tbl")]
    public partial class point_tmp_history_tbl
    {
        [Key]
        public long point_tmp_history_id { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime change_date { get; set; }

        public byte status { get; set; }

        public int change_point { get; set; }

        public int balance_point { get; set; }

        public int total_lock_point { get; set; }

        [StringLength(26)]
        public string orderid { get; set; }

        public int? point_operation_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
