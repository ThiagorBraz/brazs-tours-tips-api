using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BrazsToursTipsAPI.Models;

namespace BrazsToursTipsAPI.Controllers
{
    public class TourTipsController : ApiController
    {

        [Route("api/GetTourTips/{tourName}")]
        public string Get(string tourName)
        {
            using (BrazsToursTipsDBConToString db = new BrazsToursTipsDBConToString())
            {
                string returnThisToClient = db.TourTips.FirstOrDefault(s => s.TourName == tourName).TourTip1;
                return returnThisToClient;
            }
        }
    }
}
