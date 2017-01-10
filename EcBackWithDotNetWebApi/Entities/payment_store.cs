namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.payment_store")]
    public partial class payment_store
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int payid { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string dealerid { get; set; }

        public bool? available_flg { get; set; }

        public bool? superdynamites_flg { get; set; }

        public int? disporder1 { get; set; }

        [StringLength(256)]
        public string dispitem1 { get; set; }

        [StringLength(256)]
        public string dispname1 { get; set; }

        [StringLength(256)]
        public string dispname2 { get; set; }
    }
}
