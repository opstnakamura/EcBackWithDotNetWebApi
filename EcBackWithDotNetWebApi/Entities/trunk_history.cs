namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_history")]
    public partial class trunk_history
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string procid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(36)]
        public string registid { get; set; }

        public long sku { get; set; }

        [StringLength(36)]
        public string origin_pcid { get; set; }

        [Required]
        [StringLength(20)]
        public string bookid { get; set; }

        [StringLength(4)]
        public string langid { get; set; }

        public DateTime? bb_date { get; set; }

        [StringLength(8000)]
        public string condition { get; set; }

        public byte procdiv { get; set; }

        public byte status { get; set; }

        [Required]
        [StringLength(6)]
        public string errcode { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        [StringLength(36)]
        public string pcid { get; set; }

        public bool commit_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public bool del_flg { get; set; }

        [StringLength(32)]
        public string download_id { get; set; }
    }
}
