namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.marathon_db")]
    public partial class marathon_db
    {
        [Key]
        [StringLength(8)]
        public string campaign_cd { get; set; }

        [Required]
        [StringLength(128)]
        public string campaign_name { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime end_date { get; set; }

        public int panel_num { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
