namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dealer_url_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dealerid { get; set; }

        [StringLength(20)]
        public string replace_key { get; set; }

        [Column(TypeName = "text")]
        public string url { get; set; }

        [StringLength(10)]
        public string key1 { get; set; }

        [StringLength(500)]
        public string url1 { get; set; }

        [StringLength(10)]
        public string key2 { get; set; }

        [StringLength(500)]
        public string url2 { get; set; }

        [StringLength(10)]
        public string key3 { get; set; }

        [StringLength(500)]
        public string url3 { get; set; }

        [StringLength(10)]
        public string key4 { get; set; }

        [StringLength(500)]
        public string url4 { get; set; }

        [StringLength(10)]
        public string key5 { get; set; }

        [StringLength(500)]
        public string url5 { get; set; }

        [StringLength(50)]
        public string description { get; set; }
    }
}
