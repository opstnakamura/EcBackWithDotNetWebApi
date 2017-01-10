namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.faq_list")]
    public partial class faq_list
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(256)]
        public string genre { get; set; }

        [Required]
        [StringLength(256)]
        public string device { get; set; }

        [StringLength(256)]
        public string keyword { get; set; }

        [StringLength(256)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        public string detail { get; set; }

        public DateTime createdate { get; set; }

        public bool valid { get; set; }
    }
}
