using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using HereWebApi.Managers;
using HereWebApi.Models;

namespace HereWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Here")]
    public class HereController : Controller
    {
        // GET api/values
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/here
        [HttpGet]
        public double Get()
        {
            var obj = HereManager.Get();
            return obj;
        }
        [DataContract]
        public class Summary
        {
            [DataMember]
            public double distance { get; set; }
            [DataMember]
            public int trafficTime { get; set; }
            [DataMember]
            public int baseTime { get; set; }
            [DataMember]
            public IList<string> flags { get; set; }
            [DataMember]
            public string text { get; set; }
            [DataMember]
            public int travelTime { get; set; }
            [DataMember]
            public string _type { get; set; }
        }
    }
}