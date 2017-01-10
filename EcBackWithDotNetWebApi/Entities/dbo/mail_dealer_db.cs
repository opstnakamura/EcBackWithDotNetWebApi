namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mail_dealer_db
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(36)]
        public string mailmagazineid { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dealerid { get; set; }

        public bool sendflg { get; set; }
    }
}
