namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_summarize_db")]
    public partial class point_campaign_summarize_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int summarizeid { get; set; }

        public int year { get; set; }

        public int month { get; set; }

        public int total_basic_point { get; set; }

        public int total_campaign_point { get; set; }

        public DateTime mod_date { get; set; }

        public byte status { get; set; }
    }
}
