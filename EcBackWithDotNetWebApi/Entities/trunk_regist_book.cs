namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_regist_book")]
    public partial class trunk_regist_book
    {
        [Key]
        [StringLength(36)]
        public string registid { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        public long sku { get; set; }

        [StringLength(36)]
        public string origin_pcid { get; set; }

        [Required]
        [StringLength(20)]
        public string bookid { get; set; }

        [StringLength(4)]
        public string langid { get; set; }

        public DateTime? bb_date { get; set; }

        public int folderid { get; set; }

        [StringLength(8000)]
        public string condition { get; set; }

        [StringLength(36)]
        public string ulpcid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? uldate { get; set; }

        [StringLength(36)]
        public string dlpcid { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dldate { get; set; }

        public byte status { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public bool del_flg { get; set; }
    }
}
