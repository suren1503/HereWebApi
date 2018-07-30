using System.Runtime.Serialization;

namespace HereWebApi.Models
{
    [DataContract]
    public class ETASummary
    {
        [DataMember]
        public float distance { get; set; }
    }
}