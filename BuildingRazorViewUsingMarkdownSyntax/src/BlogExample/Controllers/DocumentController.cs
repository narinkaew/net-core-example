using Microsoft.AspNetCore.Mvc;

namespace BlogExample.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
