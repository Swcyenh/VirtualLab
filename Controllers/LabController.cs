using Microsoft.AspNetCore.Mvc;

namespace VirtualLab.Controllers
{
    public class LabController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
