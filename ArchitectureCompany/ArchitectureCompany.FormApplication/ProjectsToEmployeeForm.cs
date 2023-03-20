using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ArchitectureCompany.Services;

namespace ArchitectureCompany.FormApplication
{
    public partial class ProjectsToEmployeeForm : Form
    {
        ProjectService projectService;
        EmployeeService employeeService;

        int currentProjectPage = 1;
        int totalProjectPage = 1;


        int currentEmployeesPage = 1;
        int totalEmployeesPage = 1;

        public ProjectsToEmployeeForm()
        {
            InitializeComponent();
            projectService = new ProjectService();
            employeeService = new EmployeeService();

        }

        private void labelEmployeesPages_Click(object sender, EventArgs e)
        {

        }

        private void ProjectsToEmployeeForm_Load(object sender, EventArgs e)
        {
            try
            {


                listBoxEmployees.Items.Clear();
                listBoxProjects.Items.Clear();
                listBoxTeam.Items.Clear();
                labelProject.Text = "-";

                List<string> projects = projectService.GetProjectsInfo();
                projects.ForEach(a => listBoxProjects.Items.Add(a));

                List<string> employees = employeeService.GetEmployeeBasicInfo();
                employees.ForEach(p => listBoxEmployees.Items.Add(p));

                comboBoxECount.SelectedIndex = 0;
                comboBoxECount.Enabled = false;

                labelSteps.Text = "Step 1: choose project";

                totalProjectPage = projectService.GetProjectsPagesCount();
                labelProjectPages.Text = $"{currentProjectPage} / {totalProjectPage}";
                btnPreviousP.Enabled = true;
                btnNextP.Enabled = true;

                totalEmployeesPage = employeeService.GetEmployeePagesCount(10);
                labelEmployeesPages.Text = $"{currentEmployeesPage} / {totalEmployeesPage}";
                btnPreviousE.Enabled = false;
                btnNextE.Enabled = false;

                listBoxEmployees.Enabled = false;
                listBoxProjects.Enabled = true;
                listBoxTeam.Enabled = false;

                btnAdd.Enabled = false;


                btnPreviousE.Enabled = true;
                btnNextE.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxProjects_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                comboBoxECount.Enabled = true;
                listBoxEmployees.Enabled = true;
                listBoxProjects.Enabled = false;
                labelSteps.Text = "Step 2 - select employees";

                labelProject.Text = listBoxProjects.Text;
                btnPreviousP.Enabled = false;
                btnNextP.Enabled = false;

                btnNextE.Enabled = true;
                btnPreviousE.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxEmployees_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string employee = listBoxEmployees.Text;
                string employeeId = employee.Split(" - ").FirstOrDefault();
                foreach (var item in listBoxTeam.Items)
                {
                    string id = item.ToString().Split(" - ").FirstOrDefault();
                    if (employeeId == id)
                    {
                        MessageBox.Show("This employee is already selected");
                        return;
                    }
                }
                listBoxTeam.Items.Add(employee);

                if (listBoxTeam.Items.Count >= int.Parse(comboBoxECount.Text))
                {
                    listBoxEmployees.Enabled = false;
                    btnAdd.Enabled = true;

                    btnNextE.Enabled = false;
                    btnPreviousE.Enabled = false;

                    labelSteps.Text = "Step 3 - Confirm data";
                    comboBoxECount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int project = int.Parse(labelProject.Text.Split(" - ").FirstOrDefault());
                List<int> employees = new List<int>();
                foreach (var item in listBoxTeam.Items)
                {
                    int employeeId = int.Parse(item.ToString().Split(" - ").FirstOrDefault());
                    employees.Add(employeeId);
                }
                string result = employeeService.AddProjectTeam(project, employees);
                MessageBox.Show(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

             this.ProjectsToEmployeeForm_Load(sender, e);
        }

        private void btnPreviousP_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentProjectPage > 1)
                {
                    currentProjectPage--;
                    labelProjectPages.Text = $"{currentProjectPage} / {totalProjectPage}";
                    listBoxProjects.Items.Clear();

                    List<string> projects = projectService.GetProjectsInfo(currentProjectPage);
                    projects.ForEach(a => listBoxProjects.Items.Add(a));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextP_Click(object sender, EventArgs e)
        {
            try
            {

                if (currentProjectPage < totalProjectPage)
                {
                    currentProjectPage++;
                    labelProjectPages.Text = $"{currentProjectPage} / {totalProjectPage}";
                    listBoxProjects.Items.Clear();

                    List<string> aircrafts = projectService.GetProjectsInfo(currentProjectPage);
                    aircrafts.ForEach(a => listBoxProjects.Items.Add(a));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPreviousE_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentEmployeesPage > 1)
                {
                    currentEmployeesPage--;
                    labelEmployeesPages.Text = $"{currentEmployeesPage} / {totalEmployeesPage}";
                    listBoxEmployees.Items.Clear();

                    List<string> pilots = employeeService.GetEmployeeBasicInfo(currentEmployeesPage);
                    pilots.ForEach(p => listBoxEmployees.Items.Add(p));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNextE_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentEmployeesPage < totalEmployeesPage)
                {
                    currentEmployeesPage++;
                    labelEmployeesPages.Text = $"{currentEmployeesPage} / {totalEmployeesPage}";
                    listBoxEmployees.Items.Clear();

                    List<string> pilots = employeeService.GetEmployeeBasicInfo(currentEmployeesPage);
                    pilots.ForEach(p => listBoxEmployees.Items.Add(p));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxECount_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxTeam.Items.Clear();
        }
    }
}
