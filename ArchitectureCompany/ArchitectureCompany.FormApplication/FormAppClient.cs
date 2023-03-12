using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private int ClientThatWorkWithUs = 0;
        public FormAppClient()
        {
            InitializeComponent();
            clientService = new ClientService();
            aService = new AdditionalService();
        }

        private void FormAppClient_Load(object sender, EventArgs e)
        {
            List<string> towns = aService.GetTownsNames();
            towns.ForEach(x => cbTown.Items.Add(x));
            cbTown.SelectedIndex = 0;
            groupBoxProject.Enabled = false;
        }

        private void bSingIn_Click(object sender, EventArgs e)
        {
            string name = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string addressClient = tbAddress.Text;
            string town = cbTown.Text;
            string phoneNum = tbPhoneNumber.Text;
            string email = tbEmail.Text;

            string result = clientService.AddClient(name, lastName, addressClient, town, phoneNum, email);
            MessageBox.Show(result);

            groupBoxClient.Enabled = false;
            labelStem1.Text = "Step 2";

        }

        private void labelStem1_TextChanged(object sender, EventArgs e)
        {
            if (labelStem1.Text=="Step 1")
            {
                groupBoxClient.Enabled = true;
                groupBoxProject.Enabled = false;
            }
            else
            {
                groupBoxClient.Enabled = false;
                groupBoxProject.Enabled = true;
            }
        }

        private void btnAlradyWork_Click(object sender, EventArgs e)
        {
            ClientThatWorkWithUs = clientService.GetClientIdByPhoneNum(tbPhoneNumber.Text);
            List<string> projectNames = clientService.GetProjectsName(ClientThatWorkWithUs);
            projectNames.ForEach(x => comboBoxProjects.Items.Add(x));
            List<string> buildingsNames = aService.GetBuildingsTypes();
            buildingsNames.ForEach(x => cbBulidingType.Items.Add(x));
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
