namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.goods")]
    public partial class goods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long goods_no { get; set; }

        [Required]
        [StringLength(128)]
        public string goods_cd { get; set; }

        public long book_no { get; set; }

        public int set_type { get; set; }

        public int book_type { get; set; }

        public int price_type { get; set; }

        public long goods_type_no { get; set; }

        public DateTime application_start_date { get; set; }

        public DateTime application_end_date { get; set; }

        public DateTime reservation_start_date { get; set; }

        public DateTime reservation_end_date { get; set; }

        public DateTime information_disclosure_Date { get; set; }

        [Required]
        [StringLength(10)]
        public string dealer_id { get; set; }

        public decimal price { get; set; }

        public int reservation_flag { get; set; }
    }
}
