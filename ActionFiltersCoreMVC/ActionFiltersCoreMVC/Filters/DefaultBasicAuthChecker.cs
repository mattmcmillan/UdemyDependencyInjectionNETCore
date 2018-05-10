using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ActionFiltersCoreMVC.Filters
{
    public class DefaultBasicAuthChecker : IBasicAuthChecker
    {
        public void Check(HttpContext context, string key, string value)
        {
            var authHeader = context.Request.Headers[key];
            if (string.IsNullOrEmpty(authHeader) || authHeader != value)
            {
                throw new Exception("Not authorized");
            }
        }
    }
}
