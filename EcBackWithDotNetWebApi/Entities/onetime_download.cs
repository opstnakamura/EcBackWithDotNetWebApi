namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.onetime_download")]
    public partial class onetime_download
    {
        [Key]
        [StringLength(32)]
        public string download_id { get; set; }

        [Required]
        [StringLength(32)]
        public string entry_id { get; set; }

        [StringLength(32)]
        public string user_id { get; set; }

        public DateTime? date_created { get; set; }

        public DateTime? date_changed { get; set; }

        public int? status { get; set; }
    }
}
