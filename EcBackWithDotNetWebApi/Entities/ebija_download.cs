namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ebija_download")]
    public partial class ebija_download
    {
        public int id { get; set; }

        [Required]
        [StringLength(64)]
        public string sessionid { get; set; }

        [StringLength(256)]
        public string ebi { get; set; }

        [Required]
        [StringLength(192)]
        public string envid { get; set; }

        [StringLength(32)]
        public string contentkey { get; set; }

        public DateTime createdate { get; set; }
    }
}
