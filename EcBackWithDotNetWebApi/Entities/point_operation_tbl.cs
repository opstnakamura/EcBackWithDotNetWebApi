namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_operation_tbl")]
    public partial class point_operation_tbl
    {
        [Key]
        public int point_operation_id { get; set; }

        public byte status { get; set; }

        public byte point_status { get; set; }

        public int total_point { get; set; }

        public int total_count { get; set; }

        [Column(TypeName = "date")]
        public DateTime? point_available_date { get; set; }

        [Required]
        [StringLength(20)]
        public string display_name { get; set; }

        [Required]
        [StringLength(100)]
        public string note { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
