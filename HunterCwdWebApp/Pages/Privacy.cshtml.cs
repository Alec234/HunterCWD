using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HunterCwdWebApp.Pages
{
    [BindProperties]
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
        public HuntersDBContext dbContext = new();
        public List<Data.MessageBoard> displayItem { get; set; } = new List<Data.MessageBoard>();


        public void OnGet()
        {
            displayItem = dbContext.MessageBoards.ToList();

        }

        public void OnPostSubmit()
        {
            Data.MessageBoard addItem = new Data.MessageBoard();
            addItem.FirstName = fName;
            addItem.LastName = lName;
            addItem.Message = message; 
            dbContext.MessageBoards.Add(addItem);
            dbContext.SaveChanges();

            displayItem = dbContext.MessageBoards.ToList();

        }

        public void OnPostRemove()
        {
            displayItem = dbContext.MessageBoards.ToList();

            int iteration = Int32.Parse(Request.Form["iteration"]);
            // var itemToRemove = from x in dbContext.MessageBoards
            //                  where x.FirstName ==  displayItem[iteration - 1].FirstName
            //                  && x.LastName == displayItem[iteration - 1].LastName
            //                  select x;
            //exception here
            dbContext.Remove(displayItem[iteration-1]);
            dbContext.SaveChanges();

            displayItem = dbContext.MessageBoards.ToList();
           
        }
    }
}