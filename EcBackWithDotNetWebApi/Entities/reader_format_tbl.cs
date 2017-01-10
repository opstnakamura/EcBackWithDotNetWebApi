namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.reader_format_tbl")]
    public partial class reader_format_tbl
    {
        [Key]
        [Column(Order = 0)]
        public byte cid { get; set; }

        [Key]
        [Column(Order = 1)]
        public byte majarversion { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte minorversion { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int formatid { get; set; }

        public bool valid { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
