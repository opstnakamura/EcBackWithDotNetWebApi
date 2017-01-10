namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.card_regist_db")]
    public partial class card_regist_db
    {
        [Required]
        [StringLength(32)]
        public string userid { get; set; }

        [Key]
        [StringLength(32)]
        public string custid { get; set; }

        public int? cardstatemode { get; set; }

        public DateTime? cardchanged { get; set; }

        public int payid { get; set; }

        [StringLength(3)]
        public string branch_code { get; set; }

        [StringLength(7)]
        public string account_number { get; set; }

        [StringLength(100)]
        public string kana_name { get; set; }

        public DateTime? created { get; set; }
    }
}
