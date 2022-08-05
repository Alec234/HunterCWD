using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HunterCwdWebApp.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string fullName { get; set; }
        [BindProperty]
        public string email { get; set; }
        [BindProperty]
        public string subject { get; set; }
        [BindProperty]
        public string message { get; set; }
        public void OnGet()
        {
           //do something
        }

        public void OnPost()
        {
            //do something
        }
    }
}
