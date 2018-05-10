using Microsoft.AspNetCore.Http;

namespace ActionFiltersCoreMVC.Filters
{
    public interface IBasicAuthChecker
    {
        void Check(HttpContext context, string key, string value);
    }
}