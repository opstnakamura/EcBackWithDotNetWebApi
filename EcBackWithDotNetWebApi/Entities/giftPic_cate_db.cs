namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.giftPic_cate_db")]
    public partial class giftPic_cate_db
    {
        [Key]
        public int giftPic_cateId { get; set; }

        [Required]
        [StringLength(40)]
        public string giftPic_cateName { get; set; }

        public bool giftPic_cateDelete { get; set; }
    }
}
