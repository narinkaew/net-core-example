using Microsoft.AspNetCore.Mvc;
using Humanizer;

namespace BlogExample.Controllers
{
    public class HumanizerController : Controller
    {
        public IActionResult Index()
        {
            string TitleCaseFrom = "john doe";
            ViewData["TitleCaseFrom"] = TitleCaseFrom;
            ViewData["TitleCaseTo"] = TitleCaseFrom.Transform(To.TitleCase);

            string LowerCaseFrom = "JOHN DOE";
            ViewData["LowerCaseFrom"] = LowerCaseFrom;
            ViewData["LowerCaseTo"] = LowerCaseFrom.Transform(To.LowerCase);

            return View();
        }
    }
}
