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
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.btAddImageToProject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(136, 59);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(365, 23);
            this.tbURL.TabIndex = 0;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(137, 25);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(364, 23);
            this.tbProjectName.TabIndex = 1;
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(23, 28);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(77, 15);
            this.labelProjectName.TabIndex = 2;
            this.labelProjectName.Text = "Project name";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(23, 62);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(22, 15);
            this.labelUrl.TabIndex = 3;
            this.labelUrl.Text = "Url";
            // 
            // btAddImageToProject
            // 
            this.btAddImageToProject.Location = new System.Drawing.Point(160, 93);
            this.btAddImageToProject.Name = "btAddImageToProject";
            this.btAddImageToProject.Size = new System.Drawing.Size(147, 34);
            this.btAddImageToProject.TabIndex = 4;
            this.btAddImageToProject.Text = "Add image to project";
            this.btAddImageToProject.UseVisualStyleBackColor = true;
            this.btAddImageToProject.Click += new System.EventHandler(this.btAddImageToProject_Click);
            // 
            // ImageAddFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 139);
            this.Controls.Add(this.btAddImageToProject);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.tbURL);
            this.Name = "ImageAddFormApp";
            this.Text = "ImageAddFormApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Button btAddImageToProject;
    }
}