﻿namespace ArchitectureCompany.FormApplication
{
    partial class ClientFormApp
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
            this.labelEnterInfo = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.labelAdresses = new System.Windows.Forms.Label();
            this.tbAdresses = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.buttonRegist = new System.Windows.Forms.Button();
            this.labelProject = new System.Windows.Forms.Label();
            this.labelProjectName = new System.Windows.Forms.Label();
            this.tbProjectName = new System.Windows.Forms.TextBox();
            this.labelBulidingType = new System.Windows.Forms.Label();
            this.cbBulidingTypes = new System.Windows.Forms.ComboBox();
            this.labelCapasity = new System.Windows.Forms.Label();
            this.tbCapasity = new System.Windows.Forms.TextBox();
            this.labelArea = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.labelFloors = new System.Windows.Forms.Label();
            this.tbFloors = new System.Windows.Forms.TextBox();
            this.labelprojectAdress = new System.Windows.Forms.Label();
            this.tbProjectAdress = new System.Windows.Forms.TextBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleat = new System.Windows.Forms.Button();
            this.groupBoxClientInfo = new System.Windows.Forms.GroupBox();
            this.labelTown = new System.Windows.Forms.Label();
            this.tbTown = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.groupBoxClientInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEnterInfo
            // 
            this.labelEnterInfo.AutoSize = true;
            this.labelEnterInfo.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnterInfo.Location = new System.Drawing.Point(24, 11);
            this.labelEnterInfo.Name = "labelEnterInfo";
            this.labelEnterInfo.Size = new System.Drawing.Size(271, 66);
            this.labelEnterInfo.TabIndex = 0;
            this.labelEnterInfo.Text = "Enter info";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(28, 31);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(62, 15);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First name";
            this.labelFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(123, 23);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(165, 23);
            this.tbFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(29, 69);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 15);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last name";
            this.labelLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(123, 59);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(165, 23);
            this.tbLastName.TabIndex = 5;
            // 
            // labelAdresses
            // 
            this.labelAdresses.AutoSize = true;
            this.labelAdresses.Location = new System.Drawing.Point(30, 102);
            this.labelAdresses.Name = "labelAdresses";
            this.labelAdresses.Size = new System.Drawing.Size(49, 15);
            this.labelAdresses.TabIndex = 6;
            this.labelAdresses.Text = "Address";
            this.labelAdresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbAdresses
            // 
            this.tbAdresses.Location = new System.Drawing.Point(123, 94);
            this.tbAdresses.Name = "tbAdresses";
            this.tbAdresses.Size = new System.Drawing.Size(165, 23);
            this.tbAdresses.TabIndex = 7;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(29, 163);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(86, 15);
            this.labelPhoneNumber.TabIndex = 8;
            this.labelPhoneNumber.Text = "Phone number";
            this.labelPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(123, 155);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(165, 23);
            this.tbPhoneNumber.TabIndex = 9;
            this.tbPhoneNumber.TextChanged += new System.EventHandler(this.tbPhoneNumber_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(30, 196);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(36, 15);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(123, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(165, 23);
            this.tbEmail.TabIndex = 11;
            // 
            // buttonRegist
            // 
            this.buttonRegist.Location = new System.Drawing.Point(30, 233);
            this.buttonRegist.Name = "buttonRegist";
            this.buttonRegist.Size = new System.Drawing.Size(258, 70);
            this.buttonRegist.TabIndex = 12;
            this.buttonRegist.Text = "Sign up";
            this.buttonRegist.UseVisualStyleBackColor = true;
            // 
            // labelProject
            // 
            this.labelProject.AutoSize = true;
            this.labelProject.Location = new System.Drawing.Point(516, 18);
            this.labelProject.Name = "labelProject";
            this.labelProject.Size = new System.Drawing.Size(38, 15);
            this.labelProject.TabIndex = 13;
            this.labelProject.Text = "label1";
            // 
            // labelProjectName
            // 
            this.labelProjectName.AutoSize = true;
            this.labelProjectName.Location = new System.Drawing.Point(516, 44);
            this.labelProjectName.Name = "labelProjectName";
            this.labelProjectName.Size = new System.Drawing.Size(38, 15);
            this.labelProjectName.TabIndex = 14;
            this.labelProjectName.Text = "label1";
            // 
            // tbProjectName
            // 
            this.tbProjectName.Location = new System.Drawing.Point(567, 45);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(100, 23);
            this.tbProjectName.TabIndex = 15;
            // 
            // labelBulidingType
            // 
            this.labelBulidingType.AutoSize = true;
            this.labelBulidingType.Location = new System.Drawing.Point(519, 70);
            this.labelBulidingType.Name = "labelBulidingType";
            this.labelBulidingType.Size = new System.Drawing.Size(38, 15);
            this.labelBulidingType.TabIndex = 16;
            this.labelBulidingType.Text = "label1";
            // 
            // cbBulidingTypes
            // 
            this.cbBulidingTypes.FormattingEnabled = true;
            this.cbBulidingTypes.Location = new System.Drawing.Point(563, 70);
            this.cbBulidingTypes.Name = "cbBulidingTypes";
            this.cbBulidingTypes.Size = new System.Drawing.Size(121, 23);
            this.cbBulidingTypes.TabIndex = 17;
            // 
            // labelCapasity
            // 
            this.labelCapasity.AutoSize = true;
            this.labelCapasity.Location = new System.Drawing.Point(524, 100);
            this.labelCapasity.Name = "labelCapasity";
            this.labelCapasity.Size = new System.Drawing.Size(38, 15);
            this.labelCapasity.TabIndex = 18;
            this.labelCapasity.Text = "label1";
            // 
            // tbCapasity
            // 
            this.tbCapasity.Location = new System.Drawing.Point(568, 97);
            this.tbCapasity.Name = "tbCapasity";
            this.tbCapasity.Size = new System.Drawing.Size(100, 23);
            this.tbCapasity.TabIndex = 19;
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(529, 126);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(38, 15);
            this.labelArea.TabIndex = 20;
            this.labelArea.Text = "label1";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(573, 123);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(100, 23);
            this.tbArea.TabIndex = 21;
            // 
            // labelFloors
            // 
            this.labelFloors.AutoSize = true;
            this.labelFloors.Location = new System.Drawing.Point(529, 156);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(38, 15);
            this.labelFloors.TabIndex = 22;
            this.labelFloors.Text = "label1";
            // 
            // tbFloors
            // 
            this.tbFloors.Location = new System.Drawing.Point(579, 153);
            this.tbFloors.Name = "tbFloors";
            this.tbFloors.Size = new System.Drawing.Size(100, 23);
            this.tbFloors.TabIndex = 23;
            // 
            // labelprojectAdress
            // 
            this.labelprojectAdress.AutoSize = true;
            this.labelprojectAdress.Location = new System.Drawing.Point(535, 184);
            this.labelprojectAdress.Name = "labelprojectAdress";
            this.labelprojectAdress.Size = new System.Drawing.Size(38, 15);
            this.labelprojectAdress.TabIndex = 24;
            this.labelprojectAdress.Text = "label1";
            // 
            // tbProjectAdress
            // 
            this.tbProjectAdress.Location = new System.Drawing.Point(579, 181);
            this.tbProjectAdress.Name = "tbProjectAdress";
            this.tbProjectAdress.Size = new System.Drawing.Size(100, 23);
            this.tbProjectAdress.TabIndex = 25;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(540, 215);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(38, 15);
            this.labelImage.TabIndex = 26;
            this.labelImage.Text = "label1";
            // 
            // pBImage
            // 
            this.pBImage.Location = new System.Drawing.Point(584, 215);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(100, 50);
            this.pBImage.TabIndex = 27;
            this.pBImage.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(535, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 38);
            this.buttonAdd.TabIndex = 28;
            this.buttonAdd.Text = "button1";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDeleat
            // 
            this.buttonDeleat.Location = new System.Drawing.Point(640, 289);
            this.buttonDeleat.Name = "buttonDeleat";
            this.buttonDeleat.Size = new System.Drawing.Size(75, 35);
            this.buttonDeleat.TabIndex = 29;
            this.buttonDeleat.Text = "button1";
            this.buttonDeleat.UseVisualStyleBackColor = true;
            // 
            // groupBoxClientInfo
            // 
            this.groupBoxClientInfo.Controls.Add(this.tbTown);
            this.groupBoxClientInfo.Controls.Add(this.labelTown);
            this.groupBoxClientInfo.Controls.Add(this.buttonRegist);
            this.groupBoxClientInfo.Controls.Add(this.tbEmail);
            this.groupBoxClientInfo.Controls.Add(this.labelEmail);
            this.groupBoxClientInfo.Controls.Add(this.tbPhoneNumber);
            this.groupBoxClientInfo.Controls.Add(this.labelPhoneNumber);
            this.groupBoxClientInfo.Controls.Add(this.tbAdresses);
            this.groupBoxClientInfo.Controls.Add(this.labelAdresses);
            this.groupBoxClientInfo.Controls.Add(this.tbLastName);
            this.groupBoxClientInfo.Controls.Add(this.labelLastName);
            this.groupBoxClientInfo.Controls.Add(this.tbFirstName);
            this.groupBoxClientInfo.Controls.Add(this.labelFirstName);
            this.groupBoxClientInfo.Location = new System.Drawing.Point(24, 87);
            this.groupBoxClientInfo.Name = "groupBoxClientInfo";
            this.groupBoxClientInfo.Size = new System.Drawing.Size(334, 334);
            this.groupBoxClientInfo.TabIndex = 30;
            this.groupBoxClientInfo.TabStop = false;
            this.groupBoxClientInfo.Text = "Be our client";
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(31, 133);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(35, 15);
            this.labelTown.TabIndex = 31;
            this.labelTown.Text = "Town";
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(123, 125);
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(165, 23);
            this.tbTown.TabIndex = 32;
            // 
            // ClientFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxClientInfo);
            this.Controls.Add(this.buttonDeleat);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pBImage);
            this.Controls.Add(this.labelImage);
            this.Controls.Add(this.tbProjectAdress);
            this.Controls.Add(this.labelprojectAdress);
            this.Controls.Add(this.tbFloors);
            this.Controls.Add(this.labelFloors);
            this.Controls.Add(this.tbArea);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.tbCapasity);
            this.Controls.Add(this.labelCapasity);
            this.Controls.Add(this.cbBulidingTypes);
            this.Controls.Add(this.labelBulidingType);
            this.Controls.Add(this.tbProjectName);
            this.Controls.Add(this.labelProjectName);
            this.Controls.Add(this.labelProject);
            this.Controls.Add(this.labelEnterInfo);
            this.Name = "ClientFormApp";
            this.Text = "ClientFormApp";
            this.Load += new System.EventHandler(this.ClientFormApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.groupBoxClientInfo.ResumeLayout(false);
            this.groupBoxClientInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnterInfo;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label labelAdresses;
        private System.Windows.Forms.TextBox tbAdresses;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button buttonRegist;
        private System.Windows.Forms.Label labelProject;
        private System.Windows.Forms.Label labelProjectName;
        private System.Windows.Forms.TextBox tbProjectName;
        private System.Windows.Forms.Label labelBulidingType;
        private System.Windows.Forms.ComboBox cbBulidingTypes;
        private System.Windows.Forms.Label labelCapasity;
        private System.Windows.Forms.TextBox tbCapasity;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.Label labelFloors;
        private System.Windows.Forms.TextBox tbFloors;
        private System.Windows.Forms.Label labelprojectAdress;
        private System.Windows.Forms.TextBox tbProjectAdress;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.PictureBox pBImage;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleat;
        private System.Windows.Forms.GroupBox groupBoxClientInfo;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.Label labelTown;
    }
}