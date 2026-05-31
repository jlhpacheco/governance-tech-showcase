using Microsoft.AspNetCore.Mvc;

namespace GovernanceTechShowcase.AspNetCore.Controllers
{
    public class RecordsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
