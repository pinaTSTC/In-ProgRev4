namespace Design_Document_Mock_Up
{
    partial class frmMain
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
            this.grp_Worker = new System.Windows.Forms.GroupBox();
            this.btn_Donor = new System.Windows.Forms.Button();
            this.btn_Worker = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.picb_Logo = new System.Windows.Forms.PictureBox();
            this.grp_Worker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_Worker
            // 
            this.grp_Worker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Worker.Controls.Add(this.btn_Donor);
            this.grp_Worker.Controls.Add(this.btn_Worker);
            this.grp_Worker.Controls.Add(this.lbl_Welcome);
            this.grp_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Worker.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grp_Worker.Location = new System.Drawing.Point(12, 114);
            this.grp_Worker.Name = "grp_Worker";
            this.grp_Worker.Size = new System.Drawing.Size(776, 324);
            this.grp_Worker.TabIndex = 0;
            this.grp_Worker.TabStop = false;
            this.grp_Worker.Text = "Login Selection";
            // 
            // btn_Donor
            // 
            this.btn_Donor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Donor.Location = new System.Drawing.Point(443, 136);
            this.btn_Donor.Name = "btn_Donor";
            this.btn_Donor.Size = new System.Drawing.Size(259, 104);
            this.btn_Donor.TabIndex = 1;
            this.btn_Donor.Text = "Donor";
            this.btn_Donor.UseVisualStyleBackColor = false;
            this.btn_Donor.Click += new System.EventHandler(this.btn_Donor_Click);
            // 
            // btn_Worker
            // 
            this.btn_Worker.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Worker.Location = new System.Drawing.Point(71, 136);
            this.btn_Worker.Name = "btn_Worker";
            this.btn_Worker.Size = new System.Drawing.Size(259, 104);
            this.btn_Worker.TabIndex = 0;
            this.btn_Worker.Text = "Worker";
            this.btn_Worker.UseVisualStyleBackColor = false;
            this.btn_Worker.Click += new System.EventHandler(this.btn_Worker_Click);
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(280, 41);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(218, 52);
            this.lbl_Welcome.TabIndex = 1;
            this.lbl_Welcome.Text = "Welcome!";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(140, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(590, 52);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Blood Donation Management System";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.Image = global::Design_Document_Mock_Up.Properties.Resources.gear_icon;
            this.btnSettings.Location = new System.Drawing.Point(737, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(51, 54);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // picb_Logo
            // 
            this.picb_Logo.Image = global::Design_Document_Mock_Up.Properties.Resources.logo___netclipart_com_blood_donation_clipart_2815010;
            this.picb_Logo.Location = new System.Drawing.Point(12, 12);
            this.picb_Logo.Name = "picb_Logo";
            this.picb_Logo.Size = new System.Drawing.Size(106, 96);
            this.picb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_Logo.TabIndex = 2;
            this.picb_Logo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.picb_Logo);
            this.Controls.Add(this.grp_Worker);
            this.Name = "frmMain";
            this.Text = "BDMS - Mock Up";
            this.grp_Worker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Worker;
        private System.Windows.Forms.Button btn_Donor;
        private System.Windows.Forms.Button btn_Worker;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox picb_Logo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnSettings;
    }
}

