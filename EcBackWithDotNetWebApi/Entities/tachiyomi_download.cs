namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.tachiyomi_download")]
    public partial class tachiyomi_download
    {
        [Key]
        [StringLength(26)]
        public string download_id { get; set; }

        [Required]
        [StringLength(32)]
        public string user_id { get; set; }

        public int? status { get; set; }

        [StringLength(10)]
        public string dealer_id { get; set; }

        [StringLength(48)]
        public string env_id1 { get; set; }

        [StringLength(48)]
        public string env_id2 { get; set; }

        [StringLength(48)]
        public string env_id3 { get; set; }

        [StringLength(48)]
        public string env_id4 { get; set; }

        [StringLength(20)]
        public string remote_addr { get; set; }

        [StringLength(32)]
        public string remote_host { get; set; }

        public DateTime? created { get; set; }

        public DateTime? changed { get; set; }
    }
}
