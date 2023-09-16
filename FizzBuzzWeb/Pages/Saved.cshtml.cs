using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections;


namespace FizzBuzzWeb.Pages
{

    public class SavedModel : PageModel
	{
		public ArrayList InformationsAboutLeapYear { get; set; }

		public void OnGet()
		{
			var Data = HttpContext.Session.GetString("SessionVariable1");
			if (Data != null)
				InformationsAboutLeapYear = JsonConvert.DeserializeObject<ArrayList>(Data);
			else
				InformationsAboutLeapYear = new ArrayList();
		}
	}
}
