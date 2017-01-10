namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_unregist_envid")]
    public partial class trunk_unregist_envid
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(192)]
        public string envid { get; set; }

        [StringLength(36)]
        public string conflict_trunkid { get; set; }

        [StringLength(192)]
        public string conflict_envid { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime reg_date { get; set; }
    }
}
