namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.rss_config")]
    public partial class rss_config
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int rssid { get; set; }

        [StringLength(80)]
        public string title { get; set; }

        [StringLength(50)]
        public string filepath { get; set; }

        [StringLength(100)]
        public string toplink { get; set; }

        [StringLength(200)]
        public string description { get; set; }

        [StringLength(50)]
        public string genrecode { get; set; }
    }
}
