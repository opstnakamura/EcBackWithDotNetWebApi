namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.marathon_prize_db")]
    public partial class marathon_prize_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(8)]
        public string campaign_cd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string prize_cd { get; set; }

        public int prize_lank { get; set; }

        [Required]
        [StringLength(128)]
        public string prize_name { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
