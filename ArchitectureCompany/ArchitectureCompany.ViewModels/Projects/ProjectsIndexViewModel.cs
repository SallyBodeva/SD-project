using ArchitectureCompany.ViewModels.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArchitectureCompany.ViewModels.Projects
{
    public class ProjectsIndexViewModel:PagingViewModel
    {
        public List<ProjectIndexViewModel> Projects { get; set; } = new List<ProjectIndexViewModel>();
    }
}
