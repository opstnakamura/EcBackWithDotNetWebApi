namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.serial_db")]
    public partial class serial_db
    {
        [Key]
        [StringLength(16)]
        public string serialid { get; set; }

        [Required]
        [StringLength(4)]
        public string packageid { get; set; }

        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime? date_created { get; set; }

        public int? status { get; set; }

        public int? type { get; set; }

        [StringLength(200)]
        public string envid { get; set; }
    }
}
