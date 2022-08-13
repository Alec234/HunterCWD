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
        [BindProperty]
        public string fName { get; set; }
        [BindProperty]
        public string lName { get; set; }
        [BindProperty]
        public string message { get; set; }
        public HuntersDBContext dbContext = new();
        public List<Data.messageBoard> displayItem { get; set; } = new List<Data.messageBoard>();


        public void OnGet()
        {
            displayItem = dbContext.messageBoard.ToList();

        }

        public void OnPostSubmit()
        {
            Data.messageBoard addItem = new Data.messageBoard();
            addItem.FirstName = fName;
            addItem.LastName = lName;
            addItem.Message = message;
            dbContext.messageBoard.Add(addItem);
            dbContext.SaveChanges();

            displayItem = dbContext.messageBoard.ToList();

        }
    }
}