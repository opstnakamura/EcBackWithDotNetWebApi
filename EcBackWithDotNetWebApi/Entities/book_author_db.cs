namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_author_db")]
    public partial class book_author_db
    {
        [Key]
        [StringLength(10)]
        public string authorid { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(255)]
        public string kana { get; set; }

        [StringLength(128)]
        public string incfile { get; set; }

        public byte sale_status { get; set; }

        public short sale_cnt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? new_saleday { get; set; }

        public DateTime? reg_date { get; set; }

        public DateTime? mod_date { get; set; }

        [Required]
        [StringLength(20)]
        public string author_cd { get; set; }

        public int sale_price { get; set; }
    }
}
