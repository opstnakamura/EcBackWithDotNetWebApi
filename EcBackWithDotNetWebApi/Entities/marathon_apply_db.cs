namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.marathon_apply_db")]
    public partial class marathon_apply_db
    {
        [Key]
        public int applyid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Required]
        [StringLength(8)]
        public string campaign_cd { get; set; }

        [Required]
        [StringLength(5)]
        public string prize_cd { get; set; }

        public byte status { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
