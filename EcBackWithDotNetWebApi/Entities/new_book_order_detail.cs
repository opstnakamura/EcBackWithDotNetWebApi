namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.new_book_order_detail")]
    public partial class new_book_order_detail
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long book_no { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime sales_day { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uni_genre_id { get; set; }

        [Key]
        [Column(Order = 3)]
        public byte display_order { get; set; }

        [Required]
        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
