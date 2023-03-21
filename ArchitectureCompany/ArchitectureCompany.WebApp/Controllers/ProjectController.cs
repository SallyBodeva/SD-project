using Microsoft.AspNetCore.Mvc;

namespace ArchitectureCompany.WebApp.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
