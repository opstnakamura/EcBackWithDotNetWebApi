namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.campaign_enquete_db")]
    public partial class campaign_enquete_db
    {
        [Key]
        public int campaign_enquete_id { get; set; }

        public int campaign_history_id { get; set; }

        public int age { get; set; }

        public int sex { get; set; }

        [Required]
        [StringLength(128)]
        public string area { get; set; }

        public bool use1 { get; set; }

        public bool use2 { get; set; }

        public bool use3 { get; set; }

        public bool use4 { get; set; }

        public int know { get; set; }

        [StringLength(256)]
        public string title1 { get; set; }

        [StringLength(256)]
        public string title2 { get; set; }

        [StringLength(256)]
        public string title3 { get; set; }

        [StringLength(256)]
        public string author1 { get; set; }

        [StringLength(256)]
        public string author2 { get; set; }

        [StringLength(256)]
        public string author3 { get; set; }

        [StringLength(1500)]
        public string campaign_question { get; set; }

        public DateTime created { get; set; }
    }
}
