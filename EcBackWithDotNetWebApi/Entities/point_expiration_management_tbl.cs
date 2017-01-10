namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_expiration_management_tbl")]
    public partial class point_expiration_management_tbl
    {
        [Key]
        [Column(Order = 0)]
        public byte current_pointer { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string expiration_complete_flg { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime reg_date { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime mod_date { get; set; }
    }
}
