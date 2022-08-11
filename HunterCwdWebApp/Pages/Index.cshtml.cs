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

            

        }

        public void OnPostSubmit()
        {
            this.peachmanString = "Alec sucks... a big one";
            string cwdState = Request.Form["txtState"];            

            //try
            //{
            //    Data.Cwdstat c = new Data.Cwdstat();
            //    c.State = "Wisconsin";
            //    c.County = "Adams";
            //    c.PositiveTestCount = 3;
            //    c.TotalTestCount = 90;
            //    c.Year = 2002;

            //    HuntersDBContext hContext = new HuntersDBContext();

            //    hContext.Add(c);
            //    hContext.SaveChanges();            
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }

        public void OnPostTest()
        {
            this.peachmanString = "Alec sucks... a long one";
        }
    }
}