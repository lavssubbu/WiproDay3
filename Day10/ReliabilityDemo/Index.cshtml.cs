using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ReliabiltyDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
       

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
             _logger.LogInformation("Index page loaded at {Time}", DateTime.UtcNow);            
           
        }
        public IActionResult OnPostTrigger500()
        {
            try
            {
                _logger.LogInformation("Trigger Internal Server Error");
                int res = 10 / int.Parse("0");
                return Page();
            }
            catch(Exception ex)
            {
                _logger.LogError("An error occored {Message}", ex.Message);
                return RedirectToPage("/Error", new { code = 500 });
            }
        }
        public IActionResult OnPostTrigger404()
        {
          
                _logger.LogWarning("Trigger File Not Found Error");         
                return RedirectToPage("/Error", new { code = 404 });
            
        }
    }
}
