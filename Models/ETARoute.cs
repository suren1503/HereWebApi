using System.Collections.Generic;

namespace HereWebApi.Models
{
    public class ETARoute
    {
        public ETASummary summary { get; set; }
        public List<Leg>  leg { get; set; }
    }
}