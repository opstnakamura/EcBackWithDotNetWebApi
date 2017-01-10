namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.newbook_notify_history_book_tbl")]
    public partial class newbook_notify_history_book_tbl
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int historyid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string titleid { get; set; }

        [Required]
        [StringLength(10)]
        public string authorid_1 { get; set; }

        [StringLength(10)]
        public string authorid_2 { get; set; }

        public int min_sku { get; set; }

        public int? max_sku { get; set; }

        public int book_num { get; set; }

        public DateTime reg_date { get; set; }
    }
}
