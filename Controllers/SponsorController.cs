using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ImpactNowWebApp.Controllers
{
    //accessed by: http://localhost:10281/api/sponsors
    public class SponsorsController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            List<Sponsor> sponsors = new List<Sponsor>();
            sponsors.Add(new Sponsor() { Name = "Chevron", Url = "images/chev_1.jpg", UrlAlt = "images/chev_2.jpg" });
            sponsors.Add(new Sponsor() { Name = "NRG", Url = "images/nrg_1.jpg", UrlAlt = "images/nrg_2.jpg" });
            sponsors.Add(new Sponsor() { Name = "Ericsson", Url = "images/ericsson_1.jpg", UrlAlt = "images/ericsson_2.jpg" });
            sponsors.Add(new Sponsor() { Name = "Pfizer", Url = "images/pfizer_1.jpg", UrlAlt = "images/pfizer_2.jpg" });

            return Request.CreateResponse(HttpStatusCode.OK, sponsors, Request.GetConfiguration());
        }

    }

    public class Sponsor
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string UrlAlt { get; set; }
    }

}
