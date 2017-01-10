namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_front_db")]
    public partial class book_front_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        public DateTime? saleday { get; set; }

        [StringLength(64)]
        public string bookid { get; set; }

        [StringLength(64)]
        public string contentkey { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string author { get; set; }

        [StringLength(255)]
        public string publisher { get; set; }

        [StringLength(64)]
        public string img_url { get; set; }

        [StringLength(64)]
        public string data_url { get; set; }

        [StringLength(128)]
        public string folder_url { get; set; }

        public bool? trialflag { get; set; }

        [Column(TypeName = "money")]
        public decimal? datasize { get; set; }

        public int? totalpage { get; set; }

        public int? trialpage { get; set; }

        [Column(TypeName = "text")]
        public string content { get; set; }

        [Column(TypeName = "text")]
        public string summary { get; set; }

        public int? price { get; set; }

        public bool? dmtflag { get; set; }

        public int? genrecode { get; set; }

        [Column(TypeName = "text")]
        public string keyword { get; set; }

        public int? priority { get; set; }

        public short? formatid { get; set; }

        public short? reflowtype { get; set; }

        public bool? linkflg { get; set; }

        public short? langid { get; set; }

        public int? volume { get; set; }

        [StringLength(255)]
        public string volumename { get; set; }

        public DateTime? reg_date { get; set; }

        public DateTime? mod_date { get; set; }

        public int? ref_sku { get; set; }

        public long? book_template_no { get; set; }

        public int? book_type { get; set; }

        public decimal? initial_price { get; set; }

        public decimal? paper_book_price { get; set; }

        public DateTime? paper_book_sale_day { get; set; }

        public int? set_type { get; set; }

        public long? middle_genre_no { get; set; }

        public int? title_rating_type { get; set; }

        public int? title_complete_flag { get; set; }

        [StringLength(128)]
        public string journal_name { get; set; }

        public int? title_type { get; set; }

        public int thumbnail_size { get; set; }

        [Required]
        [StringLength(255)]
        public string title_kana { get; set; }

        [Required]
        [StringLength(255)]
        public string author_kana { get; set; }

        [Required]
        [StringLength(255)]
        public string publisher_kana { get; set; }

        [Required]
        [StringLength(64)]
        public string isbn { get; set; }

        [Required]
        [StringLength(10)]
        public string authorid_1 { get; set; }

        [Required]
        [StringLength(10)]
        public string authorid_2 { get; set; }

        [StringLength(255)]
        public string author_name_1 { get; set; }

        [StringLength(255)]
        public string author_name_2 { get; set; }

        [Required]
        [StringLength(10)]
        public string titleid { get; set; }

        [StringLength(10)]
        public string publishid { get; set; }
    }
}
