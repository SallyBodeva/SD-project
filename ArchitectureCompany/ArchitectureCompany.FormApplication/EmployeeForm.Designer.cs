namespace ArchitectureCompany.FormApplication
{
    partial class EmployeeForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.rBtnDelete = new System.Windows.Forms.RadioButton();
            this.rBtnAdd = new System.Windows.Forms.RadioButton();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.labelTown = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxEmployee = new System.Windows.Forms.ListBox();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelPageNum = new System.Windows.Forms.Label();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(31, 36);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(47, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(31, 67);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(71, 15);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Surname:";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(31, 101);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(63, 15);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(31, 182);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(87, 15);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(31, 219);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(111, 15);
            this.labelPhoneNumber.TabIndex = 4;
            this.labelPhoneNumber.Text = "Phone number:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(31, 252);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(55, 15);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.radioButtonUpdate);
            this.groupBoxInfo.Controls.Add(this.rBtnDelete);
            this.groupBoxInfo.Controls.Add(this.rBtnAdd);
            this.groupBoxInfo.Controls.Add(this.txtBoxAddress);
            this.groupBoxInfo.Controls.Add(this.comboBoxCities);
            this.groupBoxInfo.Controls.Add(this.labelTown);
            this.groupBoxInfo.Controls.Add(this.comboBoxDepartment);
            this.groupBoxInfo.Controls.Add(this.textBoxEmail);
            this.groupBoxInfo.Controls.Add(this.textBoxPhoneNum);
            this.groupBoxInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.labelPhoneNumber);
            this.groupBoxInfo.Controls.Add(this.labelEmail);
            this.groupBoxInfo.Controls.Add(this.labelDepartment);
            this.groupBoxInfo.Controls.Add(this.labelAddress);
            this.groupBoxInfo.Controls.Add(this.labelLastName);
            this.groupBoxInfo.Controls.Add(this.labelName);
            this.groupBoxInfo.Font = new System.Drawing.Font("SimSun-ExtB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxInfo.Location = new System.Drawing.Point(16, 25);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(342, 330);
            this.groupBoxInfo.TabIndex = 6;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Information";
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(203, 294);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(73, 19);
            this.radioButtonUpdate.TabIndex = 17;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Update";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            this.radioButtonUpdate.CheckedChanged += new System.EventHandler(this.radioButtonUpdate_CheckedChanged);
            // 
            // rBtnDelete
            // 
            this.rBtnDelete.AutoSize = true;
            this.rBtnDelete.Location = new System.Drawing.Point(93, 293);
            this.rBtnDelete.Name = "rBtnDelete";
            this.rBtnDelete.Size = new System.Drawing.Size(97, 19);
            this.rBtnDelete.TabIndex = 16;
            this.rBtnDelete.TabStop = true;
            this.rBtnDelete.Text = "Discharge";
            this.rBtnDelete.UseVisualStyleBackColor = true;
            this.rBtnDelete.CheckedChanged += new System.EventHandler(this.rBtnDelete_CheckedChanged);
            // 
            // rBtnAdd
            // 
            this.rBtnAdd.AutoSize = true;
            this.rBtnAdd.Location = new System.Drawing.Point(16, 293);
            this.rBtnAdd.Name = "rBtnAdd";
            this.rBtnAdd.Size = new System.Drawing.Size(57, 19);
            this.rBtnAdd.TabIndex = 15;
            this.rBtnAdd.TabStop = true;
            this.rBtnAdd.Text = "Hire";
            this.rBtnAdd.UseVisualStyleBackColor = true;
            this.rBtnAdd.CheckedChanged += new System.EventHandler(this.rBtnAdd_CheckedChanged);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Location = new System.Drawing.Point(171, 99);
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(147, 22);
            this.txtBoxAddress.TabIndex = 14;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(171, 138);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(144, 23);
            this.comboBoxCities.TabIndex = 13;
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(31, 140);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(47, 15);
            this.labelTown.TabIndex = 12;
            this.labelTown.Text = "City:";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(171, 175);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(144, 23);
            this.comboBoxDepartment.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(171, 250);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(144, 22);
            this.textBoxEmail.TabIndex = 9;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(171, 217);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(144, 22);
            this.textBoxPhoneNum.TabIndex = 8;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(171, 65);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(144, 22);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(171, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(144, 22);
            this.textBoxName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(16, 376);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Hire";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // listBoxEmployee
            // 
            this.listBoxEmployee.BackColor = System.Drawing.Color.LavenderBlush;
            this.listBoxEmployee.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEmployee.FormattingEnabled = true;
            this.listBoxEmployee.ItemHeight = 29;
            this.listBoxEmployee.Location = new System.Drawing.Point(383, 29);
            this.listBoxEmployee.Name = "listBoxEmployee";
            this.listBoxEmployee.Size = new System.Drawing.Size(317, 265);
            this.listBoxEmployee.TabIndex = 8;
            this.listBoxEmployee.DoubleClick += new System.EventHandler(this.listBoxEmployee_DoubleClick_1);
            // 
            // btnDischarge
            // 
            this.btnDischarge.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDischarge.Location = new System.Drawing.Point(187, 376);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(171, 31);
            this.btnDischarge.TabIndex = 9;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(97, 413);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(174, 37);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update phone number";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Sitka Display", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.Location = new System.Drawing.Point(415, 332);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(120, 31);
            this.btnPrevious.TabIndex = 11;
            this.btnPrevious.Text = "Previous page";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Sitka Display", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.Location = new System.Drawing.Point(565, 332);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 31);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next page";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelPageNum
            // 
            this.labelPageNum.AutoSize = true;
            this.labelPageNum.Location = new System.Drawing.Point(528, 315);
            this.labelPageNum.Name = "labelPageNum";
            this.labelPageNum.Size = new System.Drawing.Size(32, 15);
            this.labelPageNum.TabIndex = 13;
            this.labelPageNum.Text = "label";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(721, 462);
            this.Controls.Add(this.labelPageNum);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.listBoxEmployee);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxInfo);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label labelTown;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.RadioButton rBtnDelete;
        private System.Windows.Forms.RadioButton rBtnAdd;
        private System.Windows.Forms.ListBox listBoxEmployee;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelPageNum;
    }
}