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

namespace ArchitectureCompany.FormApplication
{
    public partial class FormAppClient : Form
    {
        private ClientService clientService;
        private AdditionalService aService;
        private ProjectService projectService;
        public FormAppClient()
        {
            InitializeComponent();
            clientService = new ClientService();
            aService = new AdditionalService();
            projectService = new ProjectService();
        }
        private void FormAppClient_Load(object sender, EventArgs e)
        {
            try
            {
                List<string> towns = aService.GetTownsNames();
                towns.ForEach(x => cbTown.Items.Add(x));
                cbTown.SelectedIndex = 0;
                List<string> types = aService.GetBuildingsTypes();
                types.ForEach(x => cbBulidingType.Items.Add(x));
                cbTown.SelectedIndex = 0;
                List<string> townsProject = aService.GetTownsNames();
                towns.ForEach(x => comboBoxProjectTown.Items.Add(x));
                comboBoxProjectTown.SelectedIndex = 0;
                groupBoxProject.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbFirstName.Text;
                string lastName = tbLastName.Text;
                string addressClient = tbAddress.Text;
                string town = cbTown.Text;
                string phoneNum = tbPhoneNumber.Text;
                if (phoneNum.Count()!=10)
                {
                    MessageBox.Show("Phone number should be 10 symbols...");
                    return;
                }
                string email = tbEmail.Text;

                string result = clientService.AddClient(name, lastName, addressClient, town, phoneNum, email);

                MessageBox.Show(result);

                groupBoxClient.Enabled = false;
                labelStem1.Text = "Step 2";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void labelStem1_TextChanged(object sender, EventArgs e)
        {
            if (labelStem1.Text == "Step 1")
            {
                groupBoxClient.Enabled = true;
                groupBoxProject.Enabled = false;
            }
            else
            {
                groupBoxClient.Enabled = false;
                buttonAddmage.Enabled = false;
                groupBoxProject.Enabled = true;
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = tbProjectName.Text;
                string buildingType = cbBulidingType.Text;
                int capacity = int.Parse(tbCapasity.Text);
                DateTime releasedDate = dTP.Value;
                int totalFloorArea = int.Parse(tbArea.Text);
                int floors = int.Parse(tbFllor.Text);
                string address = tbProjectAdress.Text;
                string town = comboBoxProjectTown.Text;
                string result = projectService.AddProject(projectName, buildingType, capacity, releasedDate, totalFloorArea, floors, address, town);

                MessageBox.Show(result);
                int clientId = clientService.GetClientIdByPhoneNum(tbPhoneNumber.Text);
                int projectId = projectService.GetProjectIdByName(tbProjectName.Text);
                string resultMatches = clientService.MatchClientToProject(clientId, projectId);
                MessageBox.Show(resultMatches);
                buttonSubmit.Enabled = false;
                buttonAddmage.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonAddmage_Click(object sender, EventArgs e)
        {
            try
            {
                ImageAddFormApp imageAddFormApp = new ImageAddFormApp();
                imageAddFormApp.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
