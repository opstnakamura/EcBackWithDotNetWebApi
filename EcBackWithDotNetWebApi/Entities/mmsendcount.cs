namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.mmsendcount")]
    public partial class mmsendcount
    {
        [Key]
        [StringLength(10)]
        public string dealerid { get; set; }

        [Required]
        [StringLength(128)]
        public string dealername { get; set; }

        public bool mailmagazine { get; set; }

        public int mm_manga { get; set; }

        public int mm_sogo { get; set; }

        public int mm_dyna { get; set; }

        public int mm_post { get; set; }

        public int mm_girl { get; set; }

        public int mm_slow { get; set; }

        public int mm_temp { get; set; }

        public int mm_manga2 { get; set; }

        public int mm_period { get; set; }

        public DateTime mod_date { get; set; }

        public int mm_temp1 { get; set; }

        public int mm_temp2 { get; set; }

        public int mm_temp3 { get; set; }

        public int mm_temp4 { get; set; }

        public int mm_temp5 { get; set; }

        public int mm_temp6 { get; set; }

        public int mm_temp7 { get; set; }

        public int mm_temp8 { get; set; }

        public int mm_temp9 { get; set; }

        public int mm_temp10 { get; set; }
    }
}
