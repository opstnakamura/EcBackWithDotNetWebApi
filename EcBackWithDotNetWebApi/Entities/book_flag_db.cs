namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_flag_db")]
    public partial class book_flag_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long sku { get; set; }

        [StringLength(10)]
        public string titleid { get; set; }

        [StringLength(10)]
        public string authorid_1 { get; set; }

        [StringLength(10)]
        public string authorid_2 { get; set; }

        public int? volume { get; set; }
    }
}
