namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.members_ticket")]
    public partial class members_ticket
    {
        [Key]
        [StringLength(32)]
        public string ticket_id { get; set; }

        [StringLength(32)]
        public string member_id { get; set; }

        public DateTime? date_created { get; set; }

        public DateTime? date_changed { get; set; }

        public DateTime? date_limit { get; set; }

        public int? status { get; set; }
    }
}
