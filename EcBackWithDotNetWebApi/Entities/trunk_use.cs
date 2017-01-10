namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_use")]
    public partial class trunk_use
    {
        [Key]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Required]
        [StringLength(36)]
        public string pcid { get; set; }

        public DateTime mod_date { get; set; }
    }
}
