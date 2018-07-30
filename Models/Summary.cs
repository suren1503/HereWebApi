using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HereWebApi.Models
{
    public class Summary
    {
        public double? distance { get; set; }
        public int trafficTime { get; set; }
        public int baseTime { get; set; }
        public IList<string> flags { get; set; }
        public string text { get; set; }
        public int travelTime { get; set; }
        public string _type { get; set; }
    }
}
