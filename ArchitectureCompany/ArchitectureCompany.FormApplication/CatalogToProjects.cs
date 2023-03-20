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
using Microsoft.Practices.EnterpriseLibrary.Common.Utility;

namespace ArchitectureCompany.FormApplication
{
    public partial class CatalogToProjects : Form
    {
        private ClientService clientService;
        private ProjectService projectService;
        private int imageIndex = 0;
        private static List<string> urls;
        public CatalogToProjects()
        {
            InitializeComponent();
            clientService = new ClientService();
            projectService = new ProjectService();
        }

        private void CatalogToProjects_Load(object sender, EventArgs e)
        {
            try
            {

                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                List<string> clients = clientService.GetClientBasicInfo();
                clients.ForEach(x => cbClient.Items.Add(x));
                cbClient.SelectedIndex = 0;

                pictureBox1.Load("https://cdn.vectorstock.com/i/preview-1x/82/99/no-image-available-like-missing-picture-vector-43938299.jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string pilotInfo = cbClient.Text;
                int currentClientId = int.Parse(pilotInfo.Split(' ').First());
                tbClientid.Text = currentClientId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbProject_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbClientid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cbProject.Items.Clear();
                cbProject.Text = string.Empty;
                int cliendId = int.Parse(tbClientid.Text);
                List<string> projects = clientService.GetClientsProjects(cliendId);
                projects.ForEach(x => cbProject.Items.Add(x));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                urls = projectService.GetProjectImages(cbProject.Text);
                if (!urls.Any())
                {
                    pictureBox1.Load("https://cdn.vectorstock.com/i/preview-1x/82/99/no-image-available-like-missing-picture-vector-43938299.jpg");
                }
                else
                {
                    pictureBox1.Load(urls[imageIndex]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                urls = projectService.GetProjectImages(cbProject.Text);

                if (imageIndex < urls.Count - 1)
                {
                    imageIndex++;
                }
                else if (imageIndex == urls.Count - 1)
                {
                    imageIndex = 0;
                }
                try
                {
                    pictureBox1.Load(urls[imageIndex]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image");
                    pictureBox1.Load(urls[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try{
                urls = projectService.GetProjectImages(cbProject.Text);
                if (imageIndex >= 1)
                {
                    imageIndex--;
                }
                try
                {
                    pictureBox1.Load(urls[imageIndex]);
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid image");
                    pictureBox1.Load(urls[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
