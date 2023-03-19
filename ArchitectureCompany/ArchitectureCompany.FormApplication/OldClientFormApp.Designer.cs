namespace ArchitectureCompany.FormApplication
{
    partial class OldClientFormApp
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
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.groupBoxProject = new System.Windows.Forms.GroupBox();
            this.dTP = new System.Windows.Forms.DateTimePicker();
            this.labelClientId = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.buttonAddmage = new System.Windows.Forms.Button();
            this.comboBoxProjectTown = new System.Windows.Forms.ComboBox();
            this.labelProjectTown = new System.Windows.Forms.Label();
            this.lableReleasedDate = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.tbProjectAdress = new System.Windows.Forms.TextBox();
            this.tbFllor = new System.Windows.Forms.TextBox();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.cbBulidingType = new System.Windows.Forms.ComboBox();
            this.tbCapasity = new System.Windows.Forms.TextBox();
            this.labelProjectAddress = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelCapasity = new System.Windows.Forms.Label();
            this.labelBulidingType = new System.Windows.Forms.Label();
            this.labelProjctName = new System.Windows.Forms.Label();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.labelPages = new System.Windows.Forms.Label();
            this.groupBoxClients = new System.Windows.Forms.GroupBox();
            this.groupBoxProject.SuspendLayout();
            this.groupBoxClients.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.BackColor = System.Drawing.Color.Cornsilk;
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 16;
            this.listBoxClients.Location = new System.Drawing.Point(4, 21);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(271, 292);
            this.listBoxClients.TabIndex = 0;
            this.listBoxClients.DoubleClick += new System.EventHandler(this.listBoxClients_DoubleClick);
            // 
            // groupBoxProject
            // 
            this.groupBoxProject.Controls.Add(this.dTP);
            this.groupBoxProject.Controls.Add(this.labelClientId);
            this.groupBoxProject.Controls.Add(this.tbClientId);
            this.groupBoxProject.Controls.Add(this.buttonAddmage);
            this.groupBoxProject.Controls.Add(this.comboBoxProjectTown);
            this.groupBoxProject.Controls.Add(this.labelProjectTown);
            this.groupBoxProject.Controls.Add(this.lableReleasedDate);
            this.groupBoxProject.Controls.Add(this.tbProjectName);
            this.groupBoxProject.Controls.Add(this.buttonSubmit);
            this.groupBoxProject.Controls.Add(this.tbProjectAdress);
            this.groupBoxProject.Controls.Add(this.tbFllor);
            this.groupBoxProject.Controls.Add(this.tbArea);
            this.groupBoxProject.Controls.Add(this.cbBulidingType);
            this.groupBoxProject.Controls.Add(this.tbCapasity);
            this.groupBoxProject.Controls.Add(this.labelProjectAddress);
            this.groupBoxProject.Controls.Add(this.labelFloor);
            this.groupBoxProject.Controls.Add(this.labelArea);
            this.groupBoxProject.Controls.Add(this.labelCapasity);
            this.groupBoxProject.Controls.Add(this.labelBulidingType);
            this.groupBoxProject.Controls.Add(this.labelProjctName);
            this.groupBoxProject.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxProject.Location = new System.Drawing.Point(338, 54);
            this.groupBoxProject.Name = "groupBoxProject";
            this.groupBoxProject.Size = new System.Drawing.Size(345, 395);
            this.groupBoxProject.TabIndex = 34;
            this.groupBoxProject.TabStop = false;
            this.groupBoxProject.Text = "Project idea";
            // 
            // dTP
            // 
            this.dTP.Location = new System.Drawing.Point(173, 170);
            this.dTP.Name = "dTP";
            this.dTP.Size = new System.Drawing.Size(153, 26);
            this.dTP.TabIndex = 40;
            // 
            // labelClientId
            // 
            this.labelClientId.AutoSize = true;
            this.labelClientId.Location = new System.Drawing.Point(5, 34);
            this.labelClientId.Name = "labelClientId";
            this.labelClientId.Size = new System.Drawing.Size(79, 16);
            this.labelClientId.TabIndex = 39;
            this.labelClientId.Text = "Client Id";
            // 
            // tbClientId
            // 
            this.tbClientId.Location = new System.Drawing.Point(173, 27);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.Size = new System.Drawing.Size(153, 26);
            this.tbClientId.TabIndex = 38;
            // 
            // buttonAddmage
            // 
            this.buttonAddmage.BackColor = System.Drawing.Color.Wheat;
            this.buttonAddmage.Location = new System.Drawing.Point(185, 344);
            this.buttonAddmage.Name = "buttonAddmage";
            this.buttonAddmage.Size = new System.Drawing.Size(119, 41);
            this.buttonAddmage.TabIndex = 36;
            this.buttonAddmage.Text = "Add image";
            this.buttonAddmage.UseVisualStyleBackColor = false;
            this.buttonAddmage.Click += new System.EventHandler(this.buttonAddmage_Click);
            // 
            // comboBoxProjectTown
            // 
            this.comboBoxProjectTown.FormattingEnabled = true;
            this.comboBoxProjectTown.Location = new System.Drawing.Point(173, 315);
            this.comboBoxProjectTown.Name = "comboBoxProjectTown";
            this.comboBoxProjectTown.Size = new System.Drawing.Size(153, 24);
            this.comboBoxProjectTown.TabIndex = 35;
            // 
            // labelProjectTown
            // 
            this.labelProjectTown.AutoSize = true;
            this.labelProjectTown.Location = new System.Drawing.Point(6, 315);
            this.labelProjectTown.Name = "labelProjectTown";
            this.labelProjectTown.Size = new System.Drawing.Size(39, 16);
            this.labelProjectTown.TabIndex = 34;
            this.labelProjectTown.Text = "Town";
            // 
            // lableReleasedDate
            // 
            this.lableReleasedDate.AutoSize = true;
            this.lableReleasedDate.Location = new System.Drawing.Point(5, 175);
            this.lableReleasedDate.Name = "lableReleasedDate";
            this.lableReleasedDate.Size = new System.Drawing.Size(111, 16);
            this.lableReleasedDate.TabIndex = 32;
            this.lableReleasedDate.Text = "Released date";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(173, 58);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(153, 26);
            this.tbProjectName.TabIndex = 31;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Wheat;
            this.buttonSubmit.Location = new System.Drawing.Point(29, 348);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(141, 37);
            this.buttonSubmit.TabIndex = 30;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // tbProjectAdress
            // 
            this.tbProjectAdress.Location = new System.Drawing.Point(174, 278);
            this.tbProjectAdress.Name = "tbProjectAdress";
            this.tbProjectAdress.Size = new System.Drawing.Size(152, 26);
            this.tbProjectAdress.TabIndex = 28;
            // 
            // tbFllor
            // 
            this.tbFllor.Location = new System.Drawing.Point(174, 238);
            this.tbFllor.Name = "tbFllor";
            this.tbFllor.Size = new System.Drawing.Size(152, 26);
            this.tbFllor.TabIndex = 27;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(174, 202);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(152, 26);
            this.tbArea.TabIndex = 26;
            // 
            // cbBulidingType
            // 
            this.cbBulidingType.FormattingEnabled = true;
            this.cbBulidingType.Location = new System.Drawing.Point(174, 91);
            this.cbBulidingType.Name = "cbBulidingType";
            this.cbBulidingType.Size = new System.Drawing.Size(152, 24);
            this.cbBulidingType.TabIndex = 25;
            // 
            // tbCapasity
            // 
            this.tbCapasity.Location = new System.Drawing.Point(174, 132);
            this.tbCapasity.Name = "tbCapasity";
            this.tbCapasity.Size = new System.Drawing.Size(152, 26);
            this.tbCapasity.TabIndex = 24;
            // 
            // labelProjectAddress
            // 
            this.labelProjectAddress.AutoSize = true;
            this.labelProjectAddress.Location = new System.Drawing.Point(5, 283);
            this.labelProjectAddress.Name = "labelProjectAddress";
            this.labelProjectAddress.Size = new System.Drawing.Size(63, 16);
            this.labelProjectAddress.TabIndex = 20;
            this.labelProjectAddress.Text = "Address";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(5, 246);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(55, 16);
            this.labelFloor.TabIndex = 19;
            this.labelFloor.Text = "Floors";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(5, 209);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(39, 16);
            this.labelArea.TabIndex = 18;
            this.labelArea.Text = "Area";
            // 
            // labelCapasity
            // 
            this.labelCapasity.AutoSize = true;
            this.labelCapasity.Location = new System.Drawing.Point(5, 142);
            this.labelCapasity.Name = "labelCapasity";
            this.labelCapasity.Size = new System.Drawing.Size(71, 16);
            this.labelCapasity.TabIndex = 17;
            this.labelCapasity.Text = "Capacity";
            // 
            // labelBulidingType
            // 
            this.labelBulidingType.AutoSize = true;
            this.labelBulidingType.Location = new System.Drawing.Point(5, 101);
            this.labelBulidingType.Name = "labelBulidingType";
            this.labelBulidingType.Size = new System.Drawing.Size(111, 16);
            this.labelBulidingType.TabIndex = 16;
            this.labelBulidingType.Text = "Buliding Type";
            // 
            // labelProjctName
            // 
            this.labelProjctName.AutoSize = true;
            this.labelProjctName.Location = new System.Drawing.Point(5, 63);
            this.labelProjctName.Name = "labelProjctName";
            this.labelProjctName.Size = new System.Drawing.Size(103, 16);
            this.labelProjctName.TabIndex = 15;
            this.labelProjctName.Text = "Project name";
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.Wheat;
            this.buttonPrevious.Location = new System.Drawing.Point(37, 348);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(83, 40);
            this.buttonPrevious.TabIndex = 35;
            this.buttonPrevious.Text = "Previous page";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Wheat;
            this.button1.Location = new System.Drawing.Point(162, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 36;
            this.button1.Text = "Next page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(113, 323);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(55, 16);
            this.labelPages.TabIndex = 37;
            this.labelPages.Text = "label1";
            // 
            // groupBoxClients
            // 
            this.groupBoxClients.Controls.Add(this.labelPages);
            this.groupBoxClients.Controls.Add(this.button1);
            this.groupBoxClients.Controls.Add(this.buttonPrevious);
            this.groupBoxClients.Controls.Add(this.listBoxClients);
            this.groupBoxClients.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxClients.Location = new System.Drawing.Point(12, 54);
            this.groupBoxClients.Name = "groupBoxClients";
            this.groupBoxClients.Size = new System.Drawing.Size(294, 395);
            this.groupBoxClients.TabIndex = 39;
            this.groupBoxClients.TabStop = false;
            this.groupBoxClients.Text = "Clients";
            // 
            // OldClientFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(698, 474);
            this.Controls.Add(this.groupBoxClients);
            this.Controls.Add(this.groupBoxProject);
            this.Name = "OldClientFormApp";
            this.Text = "OldClientFormApp";
            this.Load += new System.EventHandler(this.OldClientFormApp_Load);
            this.groupBoxProject.ResumeLayout(false);
            this.groupBoxProject.PerformLayout();
            this.groupBoxClients.ResumeLayout(false);
            this.groupBoxClients.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.GroupBox groupBoxProject;
        private System.Windows.Forms.Button buttonAddmage;
        private System.Windows.Forms.ComboBox comboBoxProjectTown;
        private System.Windows.Forms.Label labelProjectTown;
        private System.Windows.Forms.Label lableReleasedDate;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox tbProjectAdress;
        private System.Windows.Forms.TextBox tbFllor;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.ComboBox cbBulidingType;
        private System.Windows.Forms.TextBox tbCapasity;
        private System.Windows.Forms.Label labelProjectAddress;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelCapasity;
        private System.Windows.Forms.Label labelBulidingType;
        private System.Windows.Forms.Label labelProjctName;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.GroupBox groupBoxClients;
        private System.Windows.Forms.Label labelClientId;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.DateTimePicker dTP;
    }
}