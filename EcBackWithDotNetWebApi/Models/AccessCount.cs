using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace EcBackWithDotNetWebApi.Models
{
    [DataContract]
    public partial class AccessCountViewModel
    {
        [DataMember]
        public string PageId { get; set; }

        [DataMember]
        public DateTime? ADate { get; set; }

        [DataMember]
        public string Url { get; set; }
    }

    [DataContract]
    public partial class AccessCountBindingModel
    {

        [DataMember]
        public DateTime? ADate { get; set; }

        [DataMember]
        [Required(AllowEmptyStrings = false)]
        public string Url { get; set; }
    }
}
