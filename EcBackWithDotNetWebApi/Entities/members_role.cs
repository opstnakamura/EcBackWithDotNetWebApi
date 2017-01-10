namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.members_role")]
    public partial class members_role
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(32)]
        public string member_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(32)]
        public string role_id { get; set; }
    }
}
