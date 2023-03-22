using ArchitectureCompany.Services;
using ArchitectureCompany.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ArchitectureCompany.ViewModels.Projects;

namespace ArchitectureCompany.WebApp.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ProjectService projectService;
        public ProjectsController()
        {
            projectService = new ProjectService();
        }
        public IActionResult Index(int page =1)
        {
            ProjectsIndexViewModel models = new ProjectsIndexViewModel();
            models.PageNumber = page;
            models = projectService.GetProjects(models);
            return View(models);
        }

        public IActionResult Finished()
        {
            List<ProjectIndexViewModel> model = projectService.GetFinishedProjects();
            return View(model);
        }
        public IActionResult Unfinished()
        {
            List<ProjectIndexViewModel> model = projectService.GetUnFinishedProjects();
            return View(model);
        }
    }
}
