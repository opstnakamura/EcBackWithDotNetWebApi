namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.giftPic_db")]
    public partial class giftPic_db
    {
        [Key]
        public int giftPictureId { get; set; }

        public int fk_giftPic_cateId { get; set; }

        [StringLength(256)]
        public string giftPic_fileName { get; set; }

        [StringLength(50)]
        public string giftPic_name { get; set; }

        public bool giftPic_delete { get; set; }
    }
}
