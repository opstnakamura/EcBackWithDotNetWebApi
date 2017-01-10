namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_session")]
    public partial class trunk_session
    {
        [Key]
        [StringLength(36)]
        public string sessionid { get; set; }

        [Required]
        [StringLength(32)]
        public string cid { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Required]
        [StringLength(192)]
        public string envid { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        [StringLength(32)]
        public string reader_version { get; set; }
    }
}
