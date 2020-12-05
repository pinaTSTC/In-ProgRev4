namespace Design_Document_Mock_Up
{
    partial class frmCreateWorker
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
            this.grp_logCred = new System.Windows.Forms.GroupBox();
            this.lbl_First = new System.Windows.Forms.Label();
            this.txt_Afternoon = new System.Windows.Forms.TextBox();
            this.txt_First = new System.Windows.Forms.TextBox();
            this.txt_Noon = new System.Windows.Forms.TextBox();
            this.lbl_Last = new System.Windows.Forms.Label();
            this.txt_Morning = new System.Windows.Forms.TextBox();
            this.txt_Last = new System.Windows.Forms.TextBox();
            this.radb_Afternoon = new System.Windows.Forms.RadioButton();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.radb_Noon = new System.Windows.Forms.RadioButton();
            this.lbl_Phone = new System.Windows.Forms.Label();
            this.radb_Morning = new System.Windows.Forms.RadioButton();
            this.txt_passConf = new System.Windows.Forms.TextBox();
            this.lbl_IDCode = new System.Windows.Forms.Label();
            this.txt_passWord = new System.Windows.Forms.TextBox();
            this.btn_addWorker = new System.Windows.Forms.Button();
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_emailAdd = new System.Windows.Forms.TextBox();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.lbl_Emailadd = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_genIDCode = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_randCode = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.grp_logCred.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_logCred
            // 
            this.grp_logCred.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_logCred.Controls.Add(this.lbl_First);
            this.grp_logCred.Controls.Add(this.txt_Afternoon);
            this.grp_logCred.Controls.Add(this.txt_First);
            this.grp_logCred.Controls.Add(this.txt_Noon);
            this.grp_logCred.Controls.Add(this.lbl_Last);
            this.grp_logCred.Controls.Add(this.txt_Morning);
            this.grp_logCred.Controls.Add(this.txt_Last);
            this.grp_logCred.Controls.Add(this.radb_Afternoon);
            this.grp_logCred.Controls.Add(this.txt_phoneNum);
            this.grp_logCred.Controls.Add(this.radb_Noon);
            this.grp_logCred.Controls.Add(this.lbl_Phone);
            this.grp_logCred.Controls.Add(this.radb_Morning);
            this.grp_logCred.Controls.Add(this.txt_passConf);
            this.grp_logCred.Controls.Add(this.lbl_IDCode);
            this.grp_logCred.Controls.Add(this.txt_passWord);
            this.grp_logCred.Controls.Add(this.btn_addWorker);
            this.grp_logCred.Controls.Add(this.txt_userName);
            this.grp_logCred.Controls.Add(this.txt_emailAdd);
            this.grp_logCred.Controls.Add(this.lbl_confirmPass);
            this.grp_logCred.Controls.Add(this.lbl_Emailadd);
            this.grp_logCred.Controls.Add(this.lbl_password);
            this.grp_logCred.Controls.Add(this.btn_genIDCode);
            this.grp_logCred.Controls.Add(this.lbl_userName);
            this.grp_logCred.Controls.Add(this.lbl_randCode);
            this.grp_logCred.Controls.Add(this.btn_Cancel);
            this.grp_logCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_logCred.Location = new System.Drawing.Point(12, 12);
            this.grp_logCred.Name = "grp_logCred";
            this.grp_logCred.Size = new System.Drawing.Size(667, 426);
            this.grp_logCred.TabIndex = 22;
            this.grp_logCred.TabStop = false;
            this.grp_logCred.Text = "Schedule";
            // 
            // lbl_First
            // 
            this.lbl_First.AutoSize = true;
            this.lbl_First.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_First.Location = new System.Drawing.Point(374, 102);
            this.lbl_First.Name = "lbl_First";
            this.lbl_First.Size = new System.Drawing.Size(106, 24);
            this.lbl_First.TabIndex = 26;
            this.lbl_First.Text = "First Name:";
            // 
            // txt_Afternoon
            // 
            this.txt_Afternoon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Afternoon.Location = new System.Drawing.Point(63, 322);
            this.txt_Afternoon.Multiline = true;
            this.txt_Afternoon.Name = "txt_Afternoon";
            this.txt_Afternoon.ReadOnly = true;
            this.txt_Afternoon.Size = new System.Drawing.Size(216, 58);
            this.txt_Afternoon.TabIndex = 5;
            this.txt_Afternoon.Text = "4PM - 8PM M-F\r\n4PM - 8PM Saturday";
            // 
            // txt_First
            // 
            this.txt_First.Location = new System.Drawing.Point(481, 99);
            this.txt_First.MaxLength = 22;
            this.txt_First.Name = "txt_First";
            this.txt_First.Size = new System.Drawing.Size(136, 26);
            this.txt_First.TabIndex = 27;
            // 
            // txt_Noon
            // 
            this.txt_Noon.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Noon.Location = new System.Drawing.Point(63, 203);
            this.txt_Noon.Multiline = true;
            this.txt_Noon.Name = "txt_Noon";
            this.txt_Noon.ReadOnly = true;
            this.txt_Noon.Size = new System.Drawing.Size(216, 70);
            this.txt_Noon.TabIndex = 3;
            this.txt_Noon.Text = "12PM - 4PM M-F\r\n12PM - 4PM Saturday\r\n12PM - 4PM Sunday";
            // 
            // lbl_Last
            // 
            this.lbl_Last.AutoSize = true;
            this.lbl_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Last.Location = new System.Drawing.Point(374, 133);
            this.lbl_Last.Name = "lbl_Last";
            this.lbl_Last.Size = new System.Drawing.Size(48, 24);
            this.lbl_Last.TabIndex = 28;
            this.lbl_Last.Text = "Last:";
            // 
            // txt_Morning
            // 
            this.txt_Morning.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Morning.Location = new System.Drawing.Point(63, 84);
            this.txt_Morning.Multiline = true;
            this.txt_Morning.Name = "txt_Morning";
            this.txt_Morning.ReadOnly = true;
            this.txt_Morning.Size = new System.Drawing.Size(216, 70);
            this.txt_Morning.TabIndex = 1;
            this.txt_Morning.Text = "8AM - 12PM M-F\r\n9AM - 12PM Saturday\r\n9AM - 12PM Sunday";
            // 
            // txt_Last
            // 
            this.txt_Last.Location = new System.Drawing.Point(481, 130);
            this.txt_Last.MaxLength = 22;
            this.txt_Last.Name = "txt_Last";
            this.txt_Last.Size = new System.Drawing.Size(136, 26);
            this.txt_Last.TabIndex = 29;
            // 
            // radb_Afternoon
            // 
            this.radb_Afternoon.AutoSize = true;
            this.radb_Afternoon.Location = new System.Drawing.Point(21, 292);
            this.radb_Afternoon.Name = "radb_Afternoon";
            this.radb_Afternoon.Size = new System.Drawing.Size(112, 24);
            this.radb_Afternoon.TabIndex = 6;
            this.radb_Afternoon.TabStop = true;
            this.radb_Afternoon.Text = "Afternoon:";
            this.radb_Afternoon.UseVisualStyleBackColor = true;
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Location = new System.Drawing.Point(474, 274);
            this.txt_phoneNum.MaxLength = 10;
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(162, 26);
            this.txt_phoneNum.TabIndex = 37;
            // 
            // radb_Noon
            // 
            this.radb_Noon.AutoSize = true;
            this.radb_Noon.Location = new System.Drawing.Point(21, 173);
            this.radb_Noon.Name = "radb_Noon";
            this.radb_Noon.Size = new System.Drawing.Size(74, 24);
            this.radb_Noon.TabIndex = 4;
            this.radb_Noon.TabStop = true;
            this.radb_Noon.Text = "Noon:";
            this.radb_Noon.UseVisualStyleBackColor = true;
            // 
            // lbl_Phone
            // 
            this.lbl_Phone.AutoSize = true;
            this.lbl_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Phone.Location = new System.Drawing.Point(314, 274);
            this.lbl_Phone.Name = "lbl_Phone";
            this.lbl_Phone.Size = new System.Drawing.Size(145, 24);
            this.lbl_Phone.TabIndex = 36;
            this.lbl_Phone.Text = "Phone Number:";
            // 
            // radb_Morning
            // 
            this.radb_Morning.AutoSize = true;
            this.radb_Morning.Location = new System.Drawing.Point(21, 54);
            this.radb_Morning.Name = "radb_Morning";
            this.radb_Morning.Size = new System.Drawing.Size(96, 24);
            this.radb_Morning.TabIndex = 2;
            this.radb_Morning.TabStop = true;
            this.radb_Morning.Text = "Morning:";
            this.radb_Morning.UseVisualStyleBackColor = true;
            // 
            // txt_passConf
            // 
            this.txt_passConf.Location = new System.Drawing.Point(486, 238);
            this.txt_passConf.MaxLength = 28;
            this.txt_passConf.Name = "txt_passConf";
            this.txt_passConf.Size = new System.Drawing.Size(151, 26);
            this.txt_passConf.TabIndex = 35;
            // 
            // lbl_IDCode
            // 
            this.lbl_IDCode.AutoSize = true;
            this.lbl_IDCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IDCode.Location = new System.Drawing.Point(331, 22);
            this.lbl_IDCode.Name = "lbl_IDCode";
            this.lbl_IDCode.Size = new System.Drawing.Size(80, 20);
            this.lbl_IDCode.TabIndex = 38;
            this.lbl_IDCode.Text = "IDCode: ";
            // 
            // txt_passWord
            // 
            this.txt_passWord.Location = new System.Drawing.Point(486, 201);
            this.txt_passWord.MaxLength = 28;
            this.txt_passWord.Name = "txt_passWord";
            this.txt_passWord.Size = new System.Drawing.Size(154, 26);
            this.txt_passWord.TabIndex = 33;
            // 
            // btn_addWorker
            // 
            this.btn_addWorker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_addWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addWorker.Location = new System.Drawing.Point(313, 343);
            this.btn_addWorker.Name = "btn_addWorker";
            this.btn_addWorker.Size = new System.Drawing.Size(335, 67);
            this.btn_addWorker.TabIndex = 0;
            this.btn_addWorker.Text = "Submit Info";
            this.btn_addWorker.UseVisualStyleBackColor = false;
            this.btn_addWorker.Click += new System.EventHandler(this.btn_addWorker_Click);
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(486, 167);
            this.txt_userName.MaxLength = 28;
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(154, 26);
            this.txt_userName.TabIndex = 31;
            // 
            // txt_emailAdd
            // 
            this.txt_emailAdd.Location = new System.Drawing.Point(454, 311);
            this.txt_emailAdd.MaxLength = 28;
            this.txt_emailAdd.Name = "txt_emailAdd";
            this.txt_emailAdd.Size = new System.Drawing.Size(183, 26);
            this.txt_emailAdd.TabIndex = 42;
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPass.Location = new System.Drawing.Point(302, 225);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(191, 40);
            this.lbl_confirmPass.TabIndex = 34;
            this.lbl_confirmPass.Text = "Confirm Password:";
            this.lbl_confirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Emailadd
            // 
            this.lbl_Emailadd.AutoSize = true;
            this.lbl_Emailadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Emailadd.Location = new System.Drawing.Point(314, 309);
            this.lbl_Emailadd.Name = "lbl_Emailadd";
            this.lbl_Emailadd.Size = new System.Drawing.Size(142, 24);
            this.lbl_Emailadd.TabIndex = 41;
            this.lbl_Emailadd.Text = "Email Address: ";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(383, 201);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(97, 24);
            this.lbl_password.TabIndex = 32;
            this.lbl_password.Text = "Password:";
            // 
            // btn_genIDCode
            // 
            this.btn_genIDCode.Location = new System.Drawing.Point(319, 50);
            this.btn_genIDCode.Name = "btn_genIDCode";
            this.btn_genIDCode.Size = new System.Drawing.Size(190, 32);
            this.btn_genIDCode.TabIndex = 40;
            this.btn_genIDCode.Text = "Generate New ID";
            this.btn_genIDCode.UseVisualStyleBackColor = true;
            this.btn_genIDCode.Click += new System.EventHandler(this.btn_genIDCode_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(378, 167);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(102, 24);
            this.lbl_userName.TabIndex = 30;
            this.lbl_userName.Text = "Username:";
            // 
            // lbl_randCode
            // 
            this.lbl_randCode.AutoSize = true;
            this.lbl_randCode.Location = new System.Drawing.Point(417, 24);
            this.lbl_randCode.Name = "lbl_randCode";
            this.lbl_randCode.Size = new System.Drawing.Size(75, 20);
            this.lbl_randCode.TabIndex = 39;
            this.lbl_randCode.Text = "ABC123";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(558, 39);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 43);
            this.btn_Cancel.TabIndex = 44;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmCreateWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.grp_logCred);
            this.Name = "frmCreateWorker";
            this.Text = "Create Worker Login";
            this.Load += new System.EventHandler(this.frmCreateWorker_Load);
            this.grp_logCred.ResumeLayout(false);
            this.grp_logCred.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_logCred;
        private System.Windows.Forms.TextBox txt_Afternoon;
        private System.Windows.Forms.TextBox txt_Noon;
        private System.Windows.Forms.TextBox txt_Morning;
        private System.Windows.Forms.RadioButton radb_Afternoon;
        private System.Windows.Forms.RadioButton radb_Noon;
        private System.Windows.Forms.RadioButton radb_Morning;
        private System.Windows.Forms.Label lbl_First;
        private System.Windows.Forms.TextBox txt_First;
        private System.Windows.Forms.Label lbl_Last;
        private System.Windows.Forms.TextBox txt_Last;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_passConf;
        private System.Windows.Forms.TextBox txt_passWord;
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_randCode;
        private System.Windows.Forms.Label lbl_IDCode;
        private System.Windows.Forms.Button btn_genIDCode;
        private System.Windows.Forms.Label lbl_Emailadd;
        private System.Windows.Forms.TextBox txt_emailAdd;
        private System.Windows.Forms.Button btn_addWorker;
    }
}