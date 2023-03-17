namespace ArchitectureCompany.FormApplication
{
    partial class ImageAddFormApp
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.btAddImageToProject = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(136, 59);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(365, 23);
            this.tbURL.TabIndex = 0;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProjectName.Location = new System.Drawing.Point(23, 28);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(103, 16);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Project name";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUrl.Location = new System.Drawing.Point(23, 62);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(31, 16);
            this.labelUrl.TabIndex = 3;
            this.labelUrl.Text = "Url";
            // 
            // btAddImageToProject
            // 
            this.btAddImageToProject.BackColor = System.Drawing.Color.DarkSalmon;
            this.btAddImageToProject.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAddImageToProject.Location = new System.Drawing.Point(126, 93);
            this.btAddImageToProject.Name = "btAddImageToProject";
            this.btAddImageToProject.Size = new System.Drawing.Size(220, 34);
            this.btAddImageToProject.TabIndex = 4;
            this.btAddImageToProject.Text = "Add image to project";
            this.btAddImageToProject.UseVisualStyleBackColor = false;
            this.btAddImageToProject.Click += new System.EventHandler(this.btAddImageToProject_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(365, 23);
            this.comboBox1.TabIndex = 5;
            // 
            // ImageAddFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(513, 139);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btAddImageToProject);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.tbURL);
            this.Name = "ImageAddFormApp";
            this.Text = "ImageAddFormApp";
            this.Load += new System.EventHandler(this.ImageAddFormApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Button btAddImageToProject;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}