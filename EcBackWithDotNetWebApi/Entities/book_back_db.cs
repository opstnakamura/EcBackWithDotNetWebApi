namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_back_db")]
    public partial class book_back_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sku { get; set; }

        [StringLength(255)]
        public string title_kana { get; set; }

        [StringLength(255)]
        public string author_kana { get; set; }

        [StringLength(255)]
        public string publisher_kana { get; set; }

        [StringLength(64)]
        public string isbn { get; set; }

        [StringLength(64)]
        public string c_code { get; set; }

        public DateTime? date_published { get; set; }

        [StringLength(20)]
        public string book_type_original { get; set; }

        public DateTime? date_published_original { get; set; }

        public DateTime? date_created { get; set; }

        public int? licenseid_1 { get; set; }

        public double? rate_1 { get; set; }

        public int? licenseid_2 { get; set; }

        public double? rate_2 { get; set; }

        public DateTime? contract_term { get; set; }

        public DateTime? contract_renewal { get; set; }

        public int? contract_flag { get; set; }

        public int? contract_no { get; set; }
    }
}
