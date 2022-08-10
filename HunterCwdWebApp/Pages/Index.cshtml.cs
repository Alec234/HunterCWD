using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

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

            try
            {
                Data.Cwdstat c = new Data.Cwdstat();
                c.State = "Illinois";
                c.County = "Kane";
                c.PositiveTestCount = 2;
                c.TotalTestCount = 80;
                c.Year = 2002;

                HuntersDBContext hContext = new HuntersDBContext();

                hContext.Add(c);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

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