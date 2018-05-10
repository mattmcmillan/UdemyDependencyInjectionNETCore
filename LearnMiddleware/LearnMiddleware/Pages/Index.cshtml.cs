using LearnMiddleware.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LearnMiddleware.Pages
{
    public class IndexModel : PageModel
    {
        private IMonitoring _monitoring;
        public IndexModel(IMonitoring monitoring)
        {
            _monitoring = monitoring;
        }

        public void OnGet()
        {
            _monitoring.Monitor("website.index.load:1|c");
        }
    }
}
