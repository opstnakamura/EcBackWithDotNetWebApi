namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.price_change_list_tbl")]
    public partial class price_change_list_tbl
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(256)]
        public string purpose { get; set; }

        public DateTime price_change_date { get; set; }

        public byte status { get; set; }

        public DateTime? reg_date { get; set; }

        public DateTime? mod_date { get; set; }
    }
}
