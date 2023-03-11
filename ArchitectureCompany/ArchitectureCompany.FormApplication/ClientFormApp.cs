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
    public partial class ClientFormApp : Form
    {
        ClientService cService;
        public ClientFormApp()
        {
            InitializeComponent();
            cService = new ClientService();
        }
        private void ClientFormApp_Load(object sender, EventArgs e)
        {
            string name = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string address = tbAdresses.Text;
            string town = tbTown.Text;
            string phoneNum = tbPhoneNumber.Text;
            string email = tbEmail.Text;

            string result = cService.AddClient(name, lastName, address, town, phoneNum, email);
            MessageBox.Show(result);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
