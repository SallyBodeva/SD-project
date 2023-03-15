using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
using ArchitectureCompany.Services;

namespace ArchitectureCompany.FormApplication
{
    public partial class OldClientFormApp : Form
    {
        private ClientService clientService;
        private AdditionalService adService;
        private ProjectService projectService;
        private int currentPage = 1;
        private int itemsPerPage = 5;
        private int totalPages = 0;
        private int currentClientIndex = 0;
        public OldClientFormApp()
        {
            InitializeComponent();
            clientService = new ClientService();
            adService = new AdditionalService();
            projectService = new ProjectService();
        }

        private void OldClientFormApp_Load(object sender, EventArgs e)
        {
            List<string> types = adService.GetBuildingsTypes();
            types.ForEach(x => cbBulidingType.Items.Add(x));
            cbBulidingType.SelectedIndex = 0;
            List<string> townsProject = adService.GetTownsNames();
            townsProject.ForEach(x => comboBoxProjectTown.Items.Add(x));
            comboBoxProjectTown.SelectedIndex = 0;
            totalPages = clientService.GetClientPagesCount(itemsPerPage);
            List<string> eS = clientService.GetClientBasicInfo(currentPage, itemsPerPage);
            eS.ForEach(x => listBoxClients.Items.Add(x));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }
        private void listBoxClients_DoubleClick(object sender, EventArgs e)
        {
            string clientInfo = listBoxClients.Text;
            currentClientIndex = int.Parse(clientInfo.Split(' ').First());
            tbClientId.Text = currentClientIndex.ToString();
            Client c = clientService.GetClientById(currentClientIndex);
            if (c != null)
            {
                tbClientId.Text = c.Id.ToString();
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage <= 1) { return; }
            listBoxClients.Items.Clear();
            List<string> list = clientService.GetClientBasicInfo(--currentPage, itemsPerPage);
            list.ForEach(p => listBoxClients.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentPage >= totalPages) { return; }
            listBoxClients.Items.Clear();
            List<string> list = clientService.GetClientBasicInfo(++currentPage, itemsPerPage);
            list.ForEach(p => listBoxClients.Items.Add(p));
            labelPages.Text = $"{currentPage} / {totalPages}";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = tbProjectName.Text;
            string buildinType = cbBulidingType.Text;
            int capacity = int.Parse(tbCapasity.Text);
            string releaseDate = tbReleasedDate.Text;
            int area = int.Parse(tbArea.Text);
            int floors = int.Parse(tbFllor.Text);
            string address = tbProjectAdress.Text;
            string town = comboBoxProjectTown.Text;
            string result = projectService.AddProject(name, buildinType, capacity, releaseDate, area, floors, address, town);
            MessageBox.Show(result);
            int clientId = int.Parse(tbClientId.Text);
            int projectId = projectService.GetProjectIdByName(tbProjectName.Text);
            string resultMatches = clientService.MatchClientToProject(clientId, projectId);
            MessageBox.Show(resultMatches);

            ClearProjectInfo();
        }

        private void ClearProjectInfo()
        {
            tbClientId.Text = string.Empty;
            tbProjectName.Text = string.Empty;
            cbBulidingType.SelectedIndex = 0;
            tbCapasity.Text = string.Empty;
            tbReleasedDate.Text = string.Empty;
            tbFllor.Text = string.Empty;
            tbArea.Text = string.Empty;
            tbProjectAdress.Text = string.Empty;
            comboBoxProjectTown.Text = string.Empty;
        }

        private void buttonAddmage_Click(object sender, EventArgs e)
        {
            ImageAddFormApp imageAddFormApp = new ImageAddFormApp();
            imageAddFormApp.ShowDialog();
        }
    }
}
