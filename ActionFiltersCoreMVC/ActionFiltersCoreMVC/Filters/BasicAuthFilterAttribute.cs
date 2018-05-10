using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using SQLitePCL;

namespace ActionFiltersCoreMVC.Filters
{
    public class BasicAuthFilterAttribute : Attribute, IActionFilter
    {
        private readonly IBasicAuthChecker _authChecker;
        public BasicAuthFilterAttribute(IBasicAuthChecker authChecker, int sessionId)
        {
            _authChecker = authChecker;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            const string HeaderKey = "Authorization";
            const string HeaderValue = "BASIC MyAuthKey";

            _authChecker.Check(context.HttpContext, HeaderKey, HeaderValue);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }
    }
}
