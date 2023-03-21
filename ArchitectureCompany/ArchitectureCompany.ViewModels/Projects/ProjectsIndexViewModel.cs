using System.Collections.Generic;

namespace ArchitectureCompany.WebApp.Models
{
    public class ProjectsIndexViewModel:PagingViewModel
    {
        public List<ProjectIndexViewModel> Destinations { get; set; } = new List<ProjectIndexViewModel>();
    }
}
