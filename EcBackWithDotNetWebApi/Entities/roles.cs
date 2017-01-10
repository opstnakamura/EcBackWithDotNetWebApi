namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.roles")]
    public partial class roles
    {
        [Key]
        [StringLength(32)]
        public string role_id { get; set; }

        [StringLength(32)]
        public string role_name { get; set; }
    }
}
