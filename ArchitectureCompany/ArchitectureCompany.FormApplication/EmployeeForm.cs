using ArchitectureCompany.Data;
using ArchitectureCompany.Models;
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
    public partial class EmployeeForm : Form
    {
        EmployeeService eService;
        DepartmentService dService;
        public EmployeeForm()
        {
            InitializeComponent();
            eService = new EmployeeService();
            dService = new DepartmentService();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            List<string> departments = dService.GetDepartmentName();
            departments.ForEach(x => comboBoxDepartment.Items.Add(x));
            comboBoxDepartment.SelectedIndex = 0;
        }
    }
}
