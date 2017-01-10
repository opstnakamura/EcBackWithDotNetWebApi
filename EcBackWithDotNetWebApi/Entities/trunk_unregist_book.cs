namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_unregist_book")]
    public partial class trunk_unregist_book
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string bookid { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string langid { get; set; }

        public DateTime? bb_date { get; set; }

        [Required]
        [StringLength(64)]
        public string data_url { get; set; }

        [StringLength(256)]
        public string title { get; set; }

        public long? regular_sku { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime reg_date { get; set; }

        public byte cope_flg { get; set; }

        public DateTime? cope_date { get; set; }
    }
}
