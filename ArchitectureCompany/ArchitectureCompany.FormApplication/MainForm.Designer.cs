namespace ArchitectureCompany.FormApplication
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnEmployee = new System.Windows.Forms.Button();
            this.Welcomelabel = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelArtLife = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(26, 367);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(153, 55);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Our Employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // Welcomelabel
            // 
            this.Welcomelabel.AutoSize = true;
            this.Welcomelabel.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelabel.CausesValidation = false;
            this.Welcomelabel.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Welcomelabel.Location = new System.Drawing.Point(221, 12);
            this.Welcomelabel.Name = "Welcomelabel";
            this.Welcomelabel.Size = new System.Drawing.Size(274, 78);
            this.Welcomelabel.TabIndex = 1;
            this.Welcomelabel.Text = "Welcome";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.Color.Transparent;
            this.labelTo.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTo.Location = new System.Drawing.Point(310, 95);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(89, 78);
            this.labelTo.TabIndex = 2;
            this.labelTo.Text = "to";
            // 
            // labelArtLife
            // 
            this.labelArtLife.AutoSize = true;
            this.labelArtLife.BackColor = System.Drawing.Color.Transparent;
            this.labelArtLife.Font = new System.Drawing.Font("Pristina", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelArtLife.Location = new System.Drawing.Point(184, 165);
            this.labelArtLife.Name = "labelArtLife";
            this.labelArtLife.Size = new System.Drawing.Size(367, 158);
            this.labelArtLife.TabIndex = 3;
            this.labelArtLife.Text = "ArtLife";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(202, 367);
            this.btnClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(153, 55);
            this.btnClient.TabIndex = 4;
            this.btnClient.Text = "Become our client";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Choose your team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(697, 448);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.labelArtLife);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.Welcomelabel);
            this.Controls.Add(this.btnEmployee);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "MainFormApp";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label Welcomelabel;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelArtLife;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button button1;
    }
}
