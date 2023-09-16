using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace FizzBuzzWeb.Pages
{
	public class IndexModel : PageModel
	{
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzzForm FizzBuzz { get; set; }

        public String Success{ get; set; }
        public ArrayList InformationsAboutLeapYear { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var Data = HttpContext.Session.GetString("SessionVariable1");
                if (Data != null)
                {
                    InformationsAboutLeapYear = JsonConvert.DeserializeObject<ArrayList>(Data);
                }
                else
                    InformationsAboutLeapYear = new ArrayList();
                Success = FizzBuzz.Name + " urodził się w " + FizzBuzz.Year +
                    " roku. To był rok " + FizzBuzz.isYearLeapYear() + ".";

                var stringToCache = InformationsAboutLeapYear.Count + ". " + FizzBuzz.Name + "," +
                    FizzBuzz.Year + " - rok " + FizzBuzz.isYearLeapYear();

                InformationsAboutLeapYear.Insert(0, stringToCache);
                HttpContext.Session.SetString("SessionVariable1", JsonConvert.SerializeObject(InformationsAboutLeapYear));
            }
            return Page();
        }
    }
}