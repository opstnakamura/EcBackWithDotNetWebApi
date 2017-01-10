namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.contribution_db")]
    public partial class contribution_db
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long contribution_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long reply_id { get; set; }

        [StringLength(15)]
        public string ip_address { get; set; }

        public int disp_flag { get; set; }

        [StringLength(800)]
        public string msg1 { get; set; }

        [StringLength(800)]
        public string msg2 { get; set; }

        [StringLength(800)]
        public string msg3 { get; set; }

        [StringLength(800)]
        public string msg4 { get; set; }

        [StringLength(800)]
        public string msg5 { get; set; }

        public DateTime create_date { get; set; }

        public int res_flag { get; set; }
    }
}
