using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages.Zad2
{
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public int number { set; get; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/zad2/index", new { number = number });
        }
    }
}
