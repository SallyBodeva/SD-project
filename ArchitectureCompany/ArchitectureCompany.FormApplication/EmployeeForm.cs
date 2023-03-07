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
using System.Linq;
using Microsoft.Practices.EnterpriseLibrary.Common.Utility;

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
            List<string> employees = eService.GetEmployeeBasicInfo();
            employees.ForEach(x => listBoxEmployee.Items.Add(x));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string result = null;
            if (btnAdd.Text=="Add")
            {
                string name = textBoxName.Text;
                string lastName = textBoxLastName.Text;
                string address = txtBoxAddress.Text;
                string ciry = comboBoxCities.Text;
                string departments = comboBoxDepartment.Text;
                string phoneNum = textBoxPhoneNum.Text;
                string email = textBoxEmail.Text;

                result = eService.AddEmployee(name, lastName, address, ciry, departments, phoneNum, email);

                MessageBox.Show(result);
            }
            else if (btnAdd.Text== "Discharge")
            {
                result = eService.DeleteEmployeeById(listBoxEmployee.SelectedIndex+1);
                MessageBox.Show(result);
            }
            ClearAddGroupBox();
        }
        private void ClearAddGroupBox()
        {
            textBoxName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            txtBoxAddress.Text = string.Empty;
            textBoxPhoneNum.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            comboBoxDepartment.SelectedIndex = 0;
            comboBoxCities.SelectedIndex = 0;
        }


        private void rBtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            //textBoxName.Enabled = false;
            //textBoxLastName.Enabled = false
            btnAdd.Text = "Discharge";
            txtBoxAddress.Enabled = false;
            comboBoxCities.Enabled = false;
            comboBoxDepartment.Enabled = false;
            textBoxPhoneNum.Enabled = false;
            textBoxEmail.Enabled = false;
        }

        private void rBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
        }
    }
}
