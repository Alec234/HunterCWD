using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HunterCwdWebApp.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public string fName { get; set; }
        public string lName { get; set; }
        public string message { get; set; }
        public Dictionary<string, string> data = new();


        public void OnGet(Dictionary<string, string> data)
        {
            this.data = data;
        }

        public void OnPost(string fName, string lName, string message)
        {
            this.data["fName"] = fName;
            this.data["lName"] = lName;
            this.data["message"] = message;
        }
    }
}