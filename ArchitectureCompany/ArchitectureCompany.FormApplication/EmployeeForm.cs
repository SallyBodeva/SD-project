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
        AdditionalService adService;
        public EmployeeForm()
        {
            InitializeComponent();
            eService = new EmployeeService();
            dService = new DepartmentService();
            adService = new AdditionalService();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            List<string> departments = dService.GetDepartmentName();
            departments.ForEach(x => comboBoxDepartment.Items.Add(x));
            comboBoxDepartment.SelectedIndex = 0;
            List<string> cities = adService.GetTownsNames();
            cities.ForEach(x => comboBoxCities.Items.Add(x));
            comboBoxCities.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string lastName = textBoxLastName.Text;
            string address = txtBoxAddress.Text;
            string ciry = comboBoxCities.Text;
            string departments = comboBoxDepartment.Text;
            string phoneNum = textBoxPhoneNum.Text;
            string email = textBoxEmail.Text;

            string result = null;

             result = eService.AddEmployee(name, lastName, address,ciry, departments, phoneNum, email);

            MessageBox.Show(result);
        }
    }
}
