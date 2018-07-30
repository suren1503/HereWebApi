using HereWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace HereWebApi.Managers
{
    public class HereManager
    {
        public static double Get()
        {
            //41.8916325,-87.607513 - Navy pier
            //41.8823309,-87.6436586 - BMW

            string app_id = "WlnP9aNlJkqDeU8Lh36I";
            string app_code = "V3ZMnrzfDUEwf4j6LZ2q1w";
            string waypoint0 = "geo!41.8916325,-87.607513";
            string waypoint1 = "geo!41.8823309,-87.6436586";
            string mode = "fastest;car;traffic:disabled";

            string hereApi = "https://route.cit.api.here.com/routing/7.2/calculateroute.json?" +
                            "app_id=" + app_id +
                            "&app_code=" + app_code +
                            "&waypoint0=" + waypoint0 +
                            "&waypoint1=" + waypoint1 +
                            "&mode=" + mode +
                            "&summaryAttributes=tt,cf,di&departure=now";

            using (var httpClient = new HttpClient())
            {
                var response = httpClient.GetAsync(hereApi).Result;

                // This works:
                dynamic obj = JsonConvert.DeserializeObject(response.Content.ReadAsStringAsync().Result);
                return obj.response.route[0].summary.distance * 0.000621371;
            }
        }
    }
}
