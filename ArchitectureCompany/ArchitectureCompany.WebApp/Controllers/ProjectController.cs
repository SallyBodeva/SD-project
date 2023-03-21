using ArchitectureCompany.Services;
using ArchitectureCompany.WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArchitectureCompany.WebApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ProjectService projectService;
        public ProjectController()
        {
            this.projectService = new ProjectService();
        }
        public IActionResult Index(int page =1)
        {
            ProjectsIndexViewModel model = new ProjectsIndexViewModel();
            model.PageNumber = page;
            model = projectService.GetProjects(model);
            return View(model);
        }
    }
}
