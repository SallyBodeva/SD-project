using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArchitectureCompany.Models;
using ArchitectureCompany.Services;
using Microsoft.Practices.EnterpriseLibrary.Common.Utility;

namespace ArchitectureCompany.FormApplication
{
    public partial class CatalogToProjects : Form
    {
        private ClientService clientService;
        private ProjectService projectService;
        private int imageIndex = 0;
        private static List<string> urls;
        public CatalogToProjects()
        {
            InitializeComponent();
            clientService = new ClientService();
            projectService = new ProjectService();
        }

        private void CatalogToProjects_Load(object sender, EventArgs e)
        {
            List<string> clients = clientService.GetClientBasicInfo();
            clients.ForEach(x => cbClient.Items.Add(x));
            cbClient.SelectedIndex = 0;

        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

            string pilotInfo = cbClient.Text;
            int currentClientId = int.Parse(pilotInfo.Split(' ').First());
            tbClientid.Text = currentClientId.ToString();
        }

        private void cbProject_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbClientid_TextChanged(object sender, EventArgs e)
        {
            int cliendId = int.Parse(tbClientid.Text);
            List<string> projects = clientService.GetClientsProjects(cliendId);
            projects.ForEach(x => cbProject.Items.Add(x));

        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            urls = projectService.GetProjectImages(cbProject.Text);

            pictureBox1.Load(urls[imageIndex]);

        }
    }
}
