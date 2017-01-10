namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_delivery_tbl")]
    public partial class trunk_delivery_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trunk_delivery_id { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        [StringLength(64)]
        public string detail { get; set; }

        [Required]
        [StringLength(10)]
        public string titleid { get; set; }

        public DateTime delivery_start_date { get; set; }

        public DateTime delivery_end_date { get; set; }

        public bool valid_flg { get; set; }

        public int sort_no { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public byte order_type { get; set; }

        public bool visible_flg { get; set; }
    }
}
