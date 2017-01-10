namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_item_db")]
    public partial class point_campaign_item_db
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int campaignid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        public int campaign_point { get; set; }

        public DateTime reg_date { get; set; }

        public bool is_deleted { get; set; }

        [StringLength(36)]
        public string last_modified_user_id { get; set; }
    }
}
