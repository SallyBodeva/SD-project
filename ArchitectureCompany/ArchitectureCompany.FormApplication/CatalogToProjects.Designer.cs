﻿namespace ArchitectureCompany.FormApplication
{
    partial class CatalogToProjects
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbProject = new System.Windows.Forms.ComboBox();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbClientid = new System.Windows.Forms.TextBox();
            this.labelArrow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbClient
            // 
            this.cbClient.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(113, 25);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(172, 24);
            this.cbClient.TabIndex = 0;
            this.cbClient.SelectedIndexChanged += new System.EventHandler(this.cbClient_SelectedIndexChanged);
            // 
            // cbProject
            // 
            this.cbProject.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbProject.FormattingEnabled = true;
            this.cbProject.Location = new System.Drawing.Point(508, 27);
            this.cbProject.Name = "cbProject";
            this.cbProject.Size = new System.Drawing.Size(196, 24);
            this.cbProject.TabIndex = 1;
            this.cbProject.SelectedIndexChanged += new System.EventHandler(this.cbProject_SelectedIndexChanged);
            this.cbProject.TextChanged += new System.EventHandler(this.cbProject_TextChanged);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClients.Location = new System.Drawing.Point(52, 28);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(55, 16);
            this.labelClients.TabIndex = 2;
            this.labelClients.Text = "Client";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProject.Location = new System.Drawing.Point(439, 27);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(63, 16);
            this.labelProject.TabIndex = 3;
            this.labelProject.Text = "Project";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(62, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 279);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPrevious.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(438, 382);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(117, 35);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnNext.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(587, 382);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(117, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbClientid
            // 
            this.tbClientid.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbClientid.Location = new System.Drawing.Point(352, 25);
            this.tbClientid.Name = "tbClientid";
            this.tbClientid.Size = new System.Drawing.Size(46, 26);
            this.tbClientid.TabIndex = 7;
            this.tbClientid.TextChanged += new System.EventHandler(this.tbClientid_TextChanged);
            // 
            // labelArrow
            // 
            this.labelArrow.AutoSize = true;
            this.labelArrow.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelArrow.Location = new System.Drawing.Point(302, 30);
            this.labelArrow.Name = "labelArrow";
            this.labelArrow.Size = new System.Drawing.Size(23, 16);
            this.labelArrow.TabIndex = 8;
            this.labelArrow.Text = "=>";
            // 
            // CatalogToProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelArrow);
            this.Controls.Add(this.tbClientid);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.cbProject);
            this.Controls.Add(this.cbClient);
            this.Name = "CatalogToProjects";
            this.Text = "CatalogToProjects";
            this.Load += new System.EventHandler(this.CatalogToProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.ComboBox cbProject;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbClientid;
        private System.Windows.Forms.Label labelArrow;
    }
}