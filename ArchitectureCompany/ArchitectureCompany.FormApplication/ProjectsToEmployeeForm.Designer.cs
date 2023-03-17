namespace ArchitectureCompany.FormApplication
{
    partial class ProjectsToEmployeeForm
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
            this.listBoxProjects = new System.Windows.Forms.ListBox();
            this.listBoxEmployees = new System.Windows.Forms.ListBox();
            this.labelSteps = new System.Windows.Forms.Label();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelProjectPages = new System.Windows.Forms.Label();
            this.labelEmployeesPages = new System.Windows.Forms.Label();
            this.btnPreviousE = new System.Windows.Forms.Button();
            this.btnNextE = new System.Windows.Forms.Button();
            this.btnPreviousP = new System.Windows.Forms.Button();
            this.btnNextP = new System.Windows.Forms.Button();
            this.listBoxTeam = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxECount = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBoxProjects
            // 
            this.listBoxProjects.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxProjects.FormattingEnabled = true;
            this.listBoxProjects.ItemHeight = 16;
            this.listBoxProjects.Location = new System.Drawing.Point(24, 64);
            this.listBoxProjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProjects.Name = "listBoxProjects";
            this.listBoxProjects.Size = new System.Drawing.Size(237, 244);
            this.listBoxProjects.TabIndex = 0;
            this.listBoxProjects.DoubleClick += new System.EventHandler(this.listBoxProjects_DoubleClick);
            // 
            // listBoxEmployees
            // 
            this.listBoxEmployees.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEmployees.FormattingEnabled = true;
            this.listBoxEmployees.ItemHeight = 16;
            this.listBoxEmployees.Location = new System.Drawing.Point(340, 64);
            this.listBoxEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxEmployees.Name = "listBoxEmployees";
            this.listBoxEmployees.Size = new System.Drawing.Size(241, 244);
            this.listBoxEmployees.TabIndex = 1;
            this.listBoxEmployees.DoubleClick += new System.EventHandler(this.listBoxEmployees_DoubleClick);
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.ForeColor = System.Drawing.Color.Black;
            this.labelSteps.Location = new System.Drawing.Point(408, 28);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(38, 15);
            this.labelSteps.TabIndex = 2;
            this.labelSteps.Text = "label1";
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.ForeColor = System.Drawing.Color.Black;
            this.labelProject.Location = new System.Drawing.Point(691, 28);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(38, 15);
            this.labelProject.TabIndex = 3;
            this.labelProject.Text = "label1";
            // 
            // labelProjectPages
            // 
            this.labelProjectPages.AutoSize = true;
            this.labelProjectPages.ForeColor = System.Drawing.Color.Black;
            this.labelProjectPages.Location = new System.Drawing.Point(113, 324);
            this.labelProjectPages.Name = "labelProjectPages";
            this.labelProjectPages.Size = new System.Drawing.Size(38, 15);
            this.labelProjectPages.TabIndex = 4;
            this.labelProjectPages.Text = "label1";
            // 
            // labelEmployeesPages
            // 
            this.labelEmployeesPages.AutoSize = true;
            this.labelEmployeesPages.ForeColor = System.Drawing.Color.Black;
            this.labelEmployeesPages.Location = new System.Drawing.Point(408, 324);
            this.labelEmployeesPages.Name = "labelEmployeesPages";
            this.labelEmployeesPages.Size = new System.Drawing.Size(38, 15);
            this.labelEmployeesPages.TabIndex = 5;
            this.labelEmployeesPages.Text = "label1";
            this.labelEmployeesPages.Click += new System.EventHandler(this.labelEmployeesPages_Click);
            // 
            // btnPreviousE
            // 
            this.btnPreviousE.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPreviousE.ForeColor = System.Drawing.Color.Black;
            this.btnPreviousE.Location = new System.Drawing.Point(340, 348);
            this.btnPreviousE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousE.Name = "btnPreviousE";
            this.btnPreviousE.Size = new System.Drawing.Size(82, 22);
            this.btnPreviousE.TabIndex = 6;
            this.btnPreviousE.Text = "<<";
            this.btnPreviousE.UseVisualStyleBackColor = false;
            this.btnPreviousE.Click += new System.EventHandler(this.btnPreviousE_Click);
            // 
            // btnNextE
            // 
            this.btnNextE.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNextE.ForeColor = System.Drawing.Color.Black;
            this.btnNextE.Location = new System.Drawing.Point(440, 348);
            this.btnNextE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextE.Name = "btnNextE";
            this.btnNextE.Size = new System.Drawing.Size(82, 22);
            this.btnNextE.TabIndex = 7;
            this.btnNextE.Text = ">>";
            this.btnNextE.UseVisualStyleBackColor = false;
            this.btnNextE.Click += new System.EventHandler(this.btnNextE_Click);
            // 
            // btnPreviousP
            // 
            this.btnPreviousP.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPreviousP.ForeColor = System.Drawing.Color.Black;
            this.btnPreviousP.Location = new System.Drawing.Point(33, 348);
            this.btnPreviousP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreviousP.Name = "btnPreviousP";
            this.btnPreviousP.Size = new System.Drawing.Size(82, 22);
            this.btnPreviousP.TabIndex = 8;
            this.btnPreviousP.Text = "<<";
            this.btnPreviousP.UseVisualStyleBackColor = false;
            this.btnPreviousP.Click += new System.EventHandler(this.btnPreviousP_Click);
            // 
            // btnNextP
            // 
            this.btnNextP.BackColor = System.Drawing.Color.PeachPuff;
            this.btnNextP.ForeColor = System.Drawing.Color.Black;
            this.btnNextP.Location = new System.Drawing.Point(143, 347);
            this.btnNextP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNextP.Name = "btnNextP";
            this.btnNextP.Size = new System.Drawing.Size(82, 22);
            this.btnNextP.TabIndex = 9;
            this.btnNextP.Text = ">>";
            this.btnNextP.UseVisualStyleBackColor = false;
            this.btnNextP.Click += new System.EventHandler(this.btnNextP_Click);
            // 
            // listBoxTeam
            // 
            this.listBoxTeam.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxTeam.FormattingEnabled = true;
            this.listBoxTeam.ItemHeight = 16;
            this.listBoxTeam.Location = new System.Drawing.Point(675, 64);
            this.listBoxTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxTeam.Name = "listBoxTeam";
            this.listBoxTeam.Size = new System.Drawing.Size(202, 244);
            this.listBoxTeam.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(721, 339);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // comboBoxECount
            // 
            this.comboBoxECount.FormattingEnabled = true;
            this.comboBoxECount.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxECount.Location = new System.Drawing.Point(543, 326);
            this.comboBoxECount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxECount.Name = "comboBoxECount";
            this.comboBoxECount.Size = new System.Drawing.Size(37, 23);
            this.comboBoxECount.TabIndex = 12;
            this.comboBoxECount.SelectedIndexChanged += new System.EventHandler(this.comboBoxECount_SelectedIndexChanged);
            // 
            // ProjectsToEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(964, 386);
            this.Controls.Add(this.comboBoxECount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxTeam);
            this.Controls.Add(this.btnNextP);
            this.Controls.Add(this.btnPreviousP);
            this.Controls.Add(this.btnNextE);
            this.Controls.Add(this.btnPreviousE);
            this.Controls.Add(this.labelEmployeesPages);
            this.Controls.Add(this.labelProjectPages);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.listBoxEmployees);
            this.Controls.Add(this.listBoxProjects);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProjectsToEmployeeForm";
            this.Text = "ProjectsToEmployee";
            this.Load += new System.EventHandler(this.ProjectsToEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProjects;
        private System.Windows.Forms.ListBox listBoxEmployees;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelProjectPages;
        private System.Windows.Forms.Label labelEmployeesPages;
        private System.Windows.Forms.Button btnPreviousE;
        private System.Windows.Forms.Button btnNextE;
        private System.Windows.Forms.Button btnPreviousP;
        private System.Windows.Forms.Button btnNextP;
        private System.Windows.Forms.ListBox listBoxTeam;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxECount;
    }
}