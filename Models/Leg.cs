using System.Collections.Generic;

namespace HereWebApi.Models
{
    public class Leg
    {
        public Endpoint start { get; set; }
        public Endpoint end { get; set; }
        public int length { get; set; }
        public int travleTime { get; set; }
        public int baseTime { get; set; }
        public List<Link> list { get; set; }
        public IList<Maneuver> maneuver { get; set; }
    }
}