namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.review_staff_division_tbl")]
    public partial class review_staff_division_tbl
    {
        [Key]
        public int division_id { get; set; }

        [Required]
        [StringLength(128)]
        public string division_name { get; set; }

        [Required]
        [StringLength(40)]
        public string tantou_name { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
