using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;


		[BindProperty]
		public FizzBuzzForm FizzBuzz { set; get; }

		[BindProperty(SupportsGet = true)]
		public string? Name { get; set; }

		[BindProperty(SupportsGet = true)]
		public String? Number { get; set; }

		[BindProperty(SupportsGet = true)]
		public String? Success { get; set; }

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
			//if (string.IsNullOrWhiteSpace(Name))
			//{
			//	Name = "User";
			//}
		}
		public IActionResult OnPost()
		{

            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("Data",
                JsonConvert.SerializeObject(FizzBuzz));
				return RedirectToPage("./SavedInSession");

			}
			return Page();

		}
	}
}