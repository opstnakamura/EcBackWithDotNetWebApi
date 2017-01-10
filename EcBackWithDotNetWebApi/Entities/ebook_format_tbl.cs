namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ebook_format_tbl")]
    public partial class ebook_format_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short formatid { get; set; }

        [Required]
        [StringLength(16)]
        public string name { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
