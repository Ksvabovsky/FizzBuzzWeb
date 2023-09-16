using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace FizzBuzzWeb.Forms
{
    public class FizzBuzzForm
    {
		[Display(Name = "Rok urodzenia")]

		[Required(ErrorMessage = "Pole jest wymagane"),
		Range(1899, 2022, ErrorMessage = "Oczekiwana wartość {0} musi być z zakresu {1} i {2}.")]

		public int? Year { get; set; }

		[Display(Name = "Imie")]
		[Required(ErrorMessage = "Pole jest wymagane"),
		StringLength(100, ErrorMessage = "{0} wartość nie może przekraczać {1} znaków. ")]

		public String? Name { get; set; }

		public String isYearLeapYear()
		{
			if (Year % 400 == 0)
				return "przestępny";
			else if (Year % 100 == 0)
				return "nieprzestępny";
			else if (Year % 4 == 0)
				return "przestępny";
			else
				return "nieprzestępny";
		}

	}
}
