namespace Design_Document_Mock_Up
{
    partial class frmDonorLogin
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
            this.btn_accCreate = new System.Windows.Forms.Button();
            this.grp_Login = new System.Windows.Forms.GroupBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.grp_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_accCreate
            // 
            this.btn_accCreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_accCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accCreate.Location = new System.Drawing.Point(429, 106);
            this.btn_accCreate.Name = "btn_accCreate";
            this.btn_accCreate.Size = new System.Drawing.Size(359, 214);
            this.btn_accCreate.TabIndex = 0;
            this.btn_accCreate.Text = "Create Account";
            this.btn_accCreate.UseVisualStyleBackColor = false;
            this.btn_accCreate.Click += new System.EventHandler(this.btn_accCreate_Click);
            // 
            // grp_Login
            // 
            this.grp_Login.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Login.Controls.Add(this.btn_Login);
            this.grp_Login.Controls.Add(this.lbl_Password);
            this.grp_Login.Controls.Add(this.txt_password);
            this.grp_Login.Controls.Add(this.txt_userName);
            this.grp_Login.Controls.Add(this.lbl_userName);
            this.grp_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Login.Location = new System.Drawing.Point(12, 72);
            this.grp_Login.Name = "grp_Login";
            this.grp_Login.Size = new System.Drawing.Size(411, 298);
            this.grp_Login.TabIndex = 1;
            this.grp_Login.TabStop = false;
            this.grp_Login.Text = "Login";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(133, 189);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(111, 32);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "&Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(23, 144);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(91, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "Password:";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(133, 141);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(221, 26);
            this.txt_password.TabIndex = 2;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(133, 92);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(199, 26);
            this.txt_userName.TabIndex = 1;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(23, 93);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 20);
            this.lbl_userName.TabIndex = 0;
            this.lbl_userName.Text = "Username:";
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(145, 376);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(111, 44);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "R&eturn";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // frmDonorLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.grp_Login);
            this.Controls.Add(this.btn_accCreate);
            this.Name = "frmDonorLogin";
            this.Text = "frmDonorLogin";
            this.grp_Login.ResumeLayout(false);
            this.grp_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_accCreate;
        private System.Windows.Forms.GroupBox grp_Login;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_Return;
    }
}