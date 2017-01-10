namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.products_link_tbl")]
    public partial class products_link_tbl
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sku { get; set; }

        public int link_sku { get; set; }

        public bool valid_flg { get; set; }

        public DateTime reg_date { get; set; }

        public DateTime mod_date { get; set; }
    }
}
