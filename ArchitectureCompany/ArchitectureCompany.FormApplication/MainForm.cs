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
            ShowDialog();
        }

    }
}
