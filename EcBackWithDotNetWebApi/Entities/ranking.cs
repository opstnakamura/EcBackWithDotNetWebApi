namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.ranking")]
    public partial class ranking
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int uni_genre_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string titleid { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte summarize_type { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime summarize_date { get; set; }

        [Key]
        [Column(Order = 4)]
        public byte summarize_unit_type { get; set; }

        public int sale_num { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte ranking_type { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int title_type { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string dealerid { get; set; }

        public DateTime? reg_date { get; set; }

        public DateTime? mod_date { get; set; }
    }
}
