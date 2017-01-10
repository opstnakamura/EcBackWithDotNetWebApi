namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_property")]
    public partial class trunk_property
    {
        [Key]
        [StringLength(36)]
        public string trunkid { get; set; }

        public byte styleid { get; set; }

        public byte sortid { get; set; }

        public byte sizeid { get; set; }

        [StringLength(256)]
        public string buffer1 { get; set; }

        [StringLength(256)]
        public string buffer2 { get; set; }
    }
}
