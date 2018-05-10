using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ActionFiltersCoreMVC.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ActionFiltersCoreMVC.Controllers
{
    [Produces("application/json")]
    [Route("MyApi")]
    [TypeFilter(typeof(BasicAuthFilterAttribute), Arguments = new object[] { 14 })]
    public class MyApiController : Controller
    {
        [Route("Do")]
        public HttpResponseMessage Do()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}