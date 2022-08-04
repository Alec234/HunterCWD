using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HunterCwdWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string peachmanString;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.peachmanString = "Alec sucks...";
        }

        public void OnPostSubmit()
        {
            this.peachmanString = "Alec sucks... a big one";
        }

        public void OnPostTest()
        {
            this.peachmanString = "Alec sucks... a long one";
        }
    }
}