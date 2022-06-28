using Microsoft.AspNetCore.Mvc;

namespace LogicBack.Areas.LogisArea.Controllers
{
    [Area("LogisAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
