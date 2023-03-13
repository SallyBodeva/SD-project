using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchitectureCompany.FormApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormAppClient formAppClient = new FormAppClient();
            formAppClient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProjectsToEmployeeForm projectsToEmployeeForm = new ProjectsToEmployeeForm();
            projectsToEmployeeForm.ShowDialog();
        }

        private void btnOldClient_Click(object sender, EventArgs e)
        {
            OldClientFormApp oldClientFormApp = new OldClientFormApp();
            oldClientFormApp.ShowDialog();
        }
    }
}
