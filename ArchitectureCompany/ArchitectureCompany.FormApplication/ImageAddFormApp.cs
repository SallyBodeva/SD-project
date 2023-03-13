using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ArchitectureCompany.Services;

namespace ArchitectureCompany.FormApplication
{
    public partial class ImageAddFormApp : Form
    {
        private ProjectService projectService;
        public ImageAddFormApp()
        {
            InitializeComponent();
            projectService = new ProjectService();
        }

        private void btAddImageToProject_Click(object sender, EventArgs e)
        {
            string projectName = tbProjectName.Text;
            string url = tbURL.Text;
            string result = projectService.AddImageToProject(projectName, url);
            MessageBox.Show(result);
        }
    }
}
