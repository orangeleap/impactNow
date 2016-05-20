using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class CategoryController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            List<Category> cats = new List<Category>();
            cats.Add(new Category(){Name = "End Hunger", Num=1, Text="text"});

            return Request.CreateResponse(HttpStatusCode.OK, cats, Request.GetConfiguration());
        }

    }
}
