using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ActionFiltersCoreMVC.Filters
{
    public class DummyBasicAuthChecker : IBasicAuthChecker
    {
        public void Check(HttpContext context, string key, string value)
        {
            //dummy checker for unit tests, do nothing
        }
    }
}
