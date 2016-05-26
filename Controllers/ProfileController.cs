using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace ImpactNowWebApp.Controllers
{
    public class ProfileController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Post(dynamic profile)
        {
            var x = profile;

            return Request.CreateResponse(HttpStatusCode.OK, "Profile Saved", Request.GetConfiguration());
        }
    }

}
