namespace EcBackWithDotNetWebApi.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ebiadmin.point_campaign_list_db")]
    public partial class point_campaign_list_db
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int campaignid { get; set; }

        [Required]
        [StringLength(64)]
        public string name { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        [Required]
        [StringLength(64)]
        public string owner { get; set; }

        public byte status { get; set; }

        [StringLength(1024)]
        public string buffer { get; set; }

        public DateTime mod_date { get; set; }

        [StringLength(64)]
        public string approver { get; set; }

        public byte campaign_type { get; set; }

        public DateTime reg_date { get; set; }

        public byte point_given_type { get; set; }

        public int campaign_point { get; set; }

        public bool is_deleted { get; set; }

        [StringLength(36)]
        public string last_modified_user_id { get; set; }

        [StringLength(64)]
        public string display_name { get; set; }
    }
}
