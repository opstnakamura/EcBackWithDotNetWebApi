namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_title_db")]
    public partial class book_title_db
    {
        [Key]
        [StringLength(10)]
        public string titleid { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string kana { get; set; }

        [StringLength(128)]
        public string incfile { get; set; }

        public int? priority { get; set; }

        public byte sale_status { get; set; }

        public short sale_cnt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? new_saleday { get; set; }

        public long? volume1_sku { get; set; }

        public long? newbook_sku { get; set; }

        public DateTime? reg_date { get; set; }

        public DateTime? mod_date { get; set; }

        public int? dynamites_flag { get; set; }

        public int? title_rating_type { get; set; }

        public int? title_complete_flag { get; set; }

        [StringLength(128)]
        public string journal_name { get; set; }

        public int? title_type { get; set; }

        public long? middle_genre_no { get; set; }

        [StringLength(128)]
        public string title_cd { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string author { get; set; }

        [StringLength(255)]
        public string publisher { get; set; }

        [StringLength(255)]
        public string img_url { get; set; }

        public int? thumbnail_size { get; set; }

        [Column(TypeName = "money")]
        public decimal? datasize { get; set; }

        public int? totalpage { get; set; }

        public int? trialpage { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        [Column(TypeName = "text")]
        public string summary { get; set; }

        public int? sale_price { get; set; }

        public short? formatid { get; set; }

        public short? reflowtype { get; set; }

        [StringLength(10)]
        public string publishid { get; set; }
    }
}
