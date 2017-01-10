namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.dealer_db")]
    public partial class dealer_db
    {
        [Key]
        [StringLength(10)]
        public string dealerid { get; set; }

        [StringLength(128)]
        public string name { get; set; }

        [StringLength(128)]
        public string kana { get; set; }

        public int? rate { get; set; }

        public bool? b_credit { get; set; }

        public bool? b_biglobe { get; set; }

        public bool? b_ocn { get; set; }

        public bool? b_nifty { get; set; }

        public bool? b_dion { get; set; }

        public bool? b_odn { get; set; }

        public bool? b_smash { get; set; }

        public bool? b_aii { get; set; }

        public bool? b_webmoney { get; set; }

        [StringLength(16)]
        public string cid { get; set; }

        [StringLength(16)]
        public string agentid { get; set; }

        [StringLength(16)]
        public string branchid { get; set; }

        [StringLength(16)]
        public string passwd { get; set; }

        [StringLength(16)]
        public string passwd2 { get; set; }

        public bool? mailmagazine { get; set; }

        [StringLength(26)]
        public string dirname { get; set; }

        public int sales_partners_type { get; set; }

        public int? dmt_sale_flag { get; set; }

        public int? dmt_rating_flag { get; set; }
    }
}
