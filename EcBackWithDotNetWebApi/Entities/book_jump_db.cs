namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.book_jump_db")]
    public partial class book_jump_db
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(64)]
        public string bookid { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short jumpindex { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short deviceid { get; set; }

        [StringLength(50)]
        public string pageid { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1024)]
        public string url { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool validflg { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime modifydate { get; set; }
    }
}
