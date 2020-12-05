namespace Design_Document_Mock_Up
{
    partial class frmCreateAdmin
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
            this.txt_passConf = new System.Windows.Forms.TextBox();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_Emailadd = new System.Windows.Forms.Label();
            this.txt_emailAdd = new System.Windows.Forms.TextBox();
            this.btn_addAdmin = new System.Windows.Forms.Button();
            this.grp_logCred = new System.Windows.Forms.GroupBox();
            this.lbl_randCode = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_IDCode = new System.Windows.Forms.Label();
            this.btn_genIDCode = new System.Windows.Forms.Button();
            this.lbl_First = new System.Windows.Forms.Label();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.grp_logCred.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_passConf
            // 
            this.txt_passConf.Location = new System.Drawing.Point(159, 231);
            this.txt_passConf.Name = "txt_passConf";
            this.txt_passConf.Size = new System.Drawing.Size(185, 26);
            this.txt_passConf.TabIndex = 9;
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(160, 188);
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(185, 26);
            this.txt_passWord.TabIndex = 7;
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(160, 144);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(185, 26);
            this.txt_userName.TabIndex = 5;
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.AutoSize = true;
            this.lbl_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPass.Location = new System.Drawing.Point(45, 231);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(91, 40);
            this.lbl_confirmPass.TabIndex = 8;
            this.lbl_confirmPass.Text = "Confirm\r\nPassword:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(45, 188);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 20);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(45, 144);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(96, 20);
            this.lbl_userName.TabIndex = 4;
            this.lbl_userName.Text = "Username:";
            // 
            // lbl_Emailadd
            // 
            this.lbl_Emailadd.AutoSize = true;
            this.lbl_Emailadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emailadd.Location = new System.Drawing.Point(393, 208);
            this.lbl_Emailadd.Name = "lbl_Emailadd";
            this.lbl_Emailadd.Size = new System.Drawing.Size(134, 20);
            this.lbl_Emailadd.TabIndex = 15;
            this.lbl_Emailadd.Text = "Email Address: ";
            // 
            // txt_emailAdd
            // 
            this.txt_emailAdd.Location = new System.Drawing.Point(397, 231);
            this.txt_emailAdd.Name = "txt_emailAdd";
            this.txt_emailAdd.Size = new System.Drawing.Size(296, 26);
            this.txt_emailAdd.TabIndex = 16;
            // 
            // btn_addAdmin
            // 
            this.btn_addAdmin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addAdmin.Location = new System.Drawing.Point(396, 299);
            this.btn_addAdmin.Name = "btn_addAdmin";
            this.btn_addAdmin.Size = new System.Drawing.Size(296, 67);
            this.btn_addAdmin.TabIndex = 17;
            this.btn_addAdmin.Text = "Submit Info";
            this.btn_addAdmin.UseVisualStyleBackColor = false;
            this.btn_addAdmin.Click += new System.EventHandler(this.btn_addAdmin_Click);
            // 
            // grp_logCred
            // 
            this.grp_logCred.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_logCred.Controls.Add(this.lbl_randCode);
            this.grp_logCred.Controls.Add(this.btn_Cancel);
            this.grp_logCred.Controls.Add(this.lbl_IDCode);
            this.grp_logCred.Controls.Add(this.btn_genIDCode);
            this.grp_logCred.Controls.Add(this.lbl_First);
            this.grp_logCred.Controls.Add(this.txt_First);
            this.grp_logCred.Controls.Add(this.lbl_Last);
            this.grp_logCred.Controls.Add(this.txt_Last);
            this.grp_logCred.Controls.Add(this.txt_phoneNum);
            this.grp_logCred.Controls.Add(this.lbl_Phone);
            this.grp_logCred.Controls.Add(this.txt_passConf);
            this.grp_logCred.Controls.Add(this.txt_passWord);
            this.grp_logCred.Controls.Add(this.txt_userName);
            this.grp_logCred.Controls.Add(this.lbl_confirmPass);
            this.grp_logCred.Controls.Add(this.lbl_password);
            this.grp_logCred.Controls.Add(this.lbl_userName);
            this.grp_logCred.Controls.Add(this.lbl_Emailadd);
            this.grp_logCred.Controls.Add(this.txt_emailAdd);
            this.grp_logCred.Controls.Add(this.btn_addAdmin);
            this.grp_logCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_logCred.Location = new System.Drawing.Point(12, 12);
            this.grp_logCred.Name = "grp_logCred";
            this.grp_logCred.Size = new System.Drawing.Size(776, 426);
            this.grp_logCred.TabIndex = 0;
            this.grp_logCred.TabStop = false;
            this.grp_logCred.Text = "Admin Credentials";
            // 
            // lbl_randCode
            // 
            this.lbl_randCode.AutoSize = true;
            this.lbl_randCode.Location = new System.Drawing.Point(147, 310);
            this.lbl_randCode.Name = "lbl_randCode";
            this.lbl_randCode.Size = new System.Drawing.Size(78, 20);
            this.lbl_randCode.TabIndex = 11;
            this.lbl_randCode.Text = "ADM123";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(269, 308);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 58);
            this.btn_Cancel.TabIndex = 18;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_IDCode
            // 
            this.lbl_IDCode.AutoSize = true;
            this.lbl_IDCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDCode.Location = new System.Drawing.Point(45, 308);
            this.lbl_IDCode.Name = "lbl_IDCode";
            this.lbl_IDCode.Size = new System.Drawing.Size(80, 20);
            this.lbl_IDCode.TabIndex = 10;
            this.lbl_IDCode.Text = "IDCode: ";
            // 
            // btn_genIDCode
            // 
            this.btn_genIDCode.Location = new System.Drawing.Point(49, 336);
            this.btn_genIDCode.Name = "btn_genIDCode";
            this.btn_genIDCode.Size = new System.Drawing.Size(190, 32);
            this.btn_genIDCode.TabIndex = 12;
            this.btn_genIDCode.Text = "Generate New ID";
            this.btn_genIDCode.UseVisualStyleBackColor = true;
            this.btn_genIDCode.Click += new System.EventHandler(this.btn_genIDCode_Click);
            // 
            // lbl_First
            // 
            this.lbl_First.AutoSize = true;
            this.lbl_First.Location = new System.Drawing.Point(155, 80);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(101, 20);
            this.lbl_First.TabIndex = 0;
            this.lbl_First.Text = "First Name:";
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(262, 77);
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(136, 26);
            this.txt_First.TabIndex = 1;
            // 
            // lbl_Last
            // 
            this.lbl_Last.AutoSize = true;
            this.lbl_Last.Location = new System.Drawing.Point(428, 80);
            this.lbl_Last.Name = "lbl_Last";
            this.lbl_Last.Size = new System.Drawing.Size(49, 20);
            this.lbl_Last.TabIndex = 2;
            this.lbl_Last.Text = "Last:";
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(483, 77);
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(120, 26);
            this.txt_Last.TabIndex = 3;
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Location = new System.Drawing.Point(531, 144);
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(162, 26);
            this.txt_phoneNum.TabIndex = 14;
            this.txt_phoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phoneNum_KeyPress);
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Location = new System.Drawing.Point(393, 147);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(132, 20);
            this.lbl_Phone.TabIndex = 13;
            this.lbl_Phone.Text = "Phone Number:";
            // 
            // frmCreateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_logCred);
            this.Name = "frmCreateAdmin";
            this.Text = "frmCreateAdmin";
            this.Load += new System.EventHandler(this.frmCreateAdmin_Load);
            this.grp_logCred.ResumeLayout(false);
            this.grp_logCred.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txt_passConf;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_Emailadd;
        private System.Windows.Forms.TextBox txt_emailAdd;
        private System.Windows.Forms.Button btn_addAdmin;
        private System.Windows.Forms.GroupBox grp_logCred;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.TextBox txt_First;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.TextBox txt_Last;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_randCode;
        private System.Windows.Forms.Label lbl_IDCode;
        private System.Windows.Forms.Button btn_genIDCode;
    }
}