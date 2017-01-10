namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_basket")]
    public partial class trunk_basket
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        public DateTime lastmodify { get; set; }

        [Column(TypeName = "image")]
        public byte[] basketdata { get; set; }
    }
}
