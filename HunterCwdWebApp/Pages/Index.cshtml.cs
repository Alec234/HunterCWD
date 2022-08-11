using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;

namespace HunterCwdWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HuntersDBContext _dbContext = new HuntersDBContext();
        public Data.Cwdstat c = new Data.Cwdstat();
        public List<Data.Cwdstat> display = new List<Data.Cwdstat>();
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
             display = _dbContext.Cwdstats.ToList();
        }

        public void OnPostSubmit()
        {
            string cwdState = Request.Form["txtState"];

            try
            {

                display = (from s in _dbContext.Cwdstats
                           where s.State == cwdState
                           select s).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}