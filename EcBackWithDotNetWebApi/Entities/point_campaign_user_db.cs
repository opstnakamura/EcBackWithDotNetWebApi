namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_user_db")]
    public partial class point_campaign_user_db
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int summarizeid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string userid { get; set; }

        public int basic_point { get; set; }

        public int campaign_point { get; set; }
    }
}
