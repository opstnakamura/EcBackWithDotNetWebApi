namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ua_device_db")]
    public partial class ua_device_db
    {
        [Key]
        public int ua_device_id { get; set; }

        [Required]
        [StringLength(32)]
        public string pattern { get; set; }

        [Required]
        [StringLength(32)]
        public string type_name { get; set; }

        [StringLength(128)]
        public string description { get; set; }

        public DateTime created { get; set; }
    }
}
