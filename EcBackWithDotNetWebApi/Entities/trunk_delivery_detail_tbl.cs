namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_delivery_detail_tbl")]
    public partial class trunk_delivery_detail_tbl
    {
        [Key]
        public int trunk_delivery_detail_id { get; set; }

        public int trunk_delivery_id { get; set; }

        public DateTime delivery_date { get; set; }

        public byte status { get; set; }

        public DateTime? exec_start_date { get; set; }

        public DateTime? exec_end_date { get; set; }

        public int exec_plan_cnt { get; set; }

        public int exec_cnt { get; set; }

        public int exec_fail_cnt { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
