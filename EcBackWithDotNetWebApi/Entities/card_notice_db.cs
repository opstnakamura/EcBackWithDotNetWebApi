namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.card_notice_db")]
    public partial class card_notice_db
    {
        [Key]
        [StringLength(32)]
        public string userid { get; set; }

        [StringLength(50)]
        public string noticestate { get; set; }

        public DateTime? cardchanged { get; set; }

        public DateTime? created { get; set; }
    }
}
