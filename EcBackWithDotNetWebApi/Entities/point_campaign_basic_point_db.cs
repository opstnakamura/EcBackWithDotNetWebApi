namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_basic_point_db")]
    public partial class point_campaign_basic_point_db
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int min_sku { get; set; }

        public int max_sku { get; set; }

        public double point_rate { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public DateTime mod_date { get; set; }

        public int? set_type { get; set; }

        public DateTime reg_date { get; set; }

        public bool is_deleted { get; set; }

        [StringLength(36)]
        public string last_modified_user_id { get; set; }
    }
}
