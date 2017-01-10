namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.gift_db")]
    public partial class gift_db
    {
        [Key]
        [StringLength(16)]
        public string giftId { get; set; }

        [Required]
        [StringLength(32)]
        public string fk_gift_SendUserId { get; set; }

        [StringLength(100)]
        public string senderName { get; set; }

        public DateTime? linkDate { get; set; }

        public int fk_gift_pictureId { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(1200)]
        public string gift_text { get; set; }

        [StringLength(32)]
        public string receiveUserId { get; set; }

        [StringLength(100)]
        public string receiverName { get; set; }

        [Required]
        [StringLength(26)]
        public string fk_orderId { get; set; }

        public DateTime? downloadDate { get; set; }

        public bool denyFlag { get; set; }
    }
}
