namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.trunk_regist_pc")]
    public partial class trunk_regist_pc
    {
        [Key]
        [StringLength(36)]
        public string pcid { get; set; }

        [Required]
        [StringLength(36)]
        public string trunkid { get; set; }

        [Required]
        [StringLength(192)]
        public string envid { get; set; }

        [Required]
        [StringLength(30)]
        public string pc_name { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }

        public bool del_flg { get; set; }
    }
}
