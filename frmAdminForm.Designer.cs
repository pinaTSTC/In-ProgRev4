namespace Design_Document_Mock_Up
{
    partial class frmAdminForm
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
            this.btn_createAcc = new System.Windows.Forms.Button();
            this.btn_sendEmail = new System.Windows.Forms.Button();
            this.grp_donorDB = new System.Windows.Forms.GroupBox();
            this.dgv_donorTable = new System.Windows.Forms.DataGridView();
            this.grp_Worker = new System.Windows.Forms.GroupBox();
            this.dgv_workerTable = new System.Windows.Forms.DataGridView();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_reportPrint = new System.Windows.Forms.Button();
            this.grp_donorDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donorTable)).BeginInit();
            this.grp_Worker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_createAcc
            // 
            this.btn_createAcc.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_createAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_createAcc.Location = new System.Drawing.Point(12, 444);
            this.btn_createAcc.Name = "btn_createAcc";
            this.btn_createAcc.Size = new System.Drawing.Size(320, 152);
            this.btn_createAcc.TabIndex = 5;
            this.btn_createAcc.Text = "Create Account";
            this.btn_createAcc.UseVisualStyleBackColor = false;
            this.btn_createAcc.Click += new System.EventHandler(this.btn_createAcc_Click);
            // 
            // btn_sendEmail
            // 
            this.btn_sendEmail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_sendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendEmail.Location = new System.Drawing.Point(505, 444);
            this.btn_sendEmail.Name = "btn_sendEmail";
            this.btn_sendEmail.Size = new System.Drawing.Size(153, 152);
            this.btn_sendEmail.TabIndex = 4;
            this.btn_sendEmail.Text = "Send Email";
            this.btn_sendEmail.UseVisualStyleBackColor = false;
            // 
            // grp_donorDB
            // 
            this.grp_donorDB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_donorDB.Controls.Add(this.dgv_donorTable);
            this.grp_donorDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_donorDB.Location = new System.Drawing.Point(12, 12);
            this.grp_donorDB.Name = "grp_donorDB";
            this.grp_donorDB.Size = new System.Drawing.Size(487, 426);
            this.grp_donorDB.TabIndex = 3;
            this.grp_donorDB.TabStop = false;
            this.grp_donorDB.Text = "Donor Table";
            // 
            // dgv_donorTable
            // 
            this.dgv_donorTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donorTable.Location = new System.Drawing.Point(7, 26);
            this.dgv_donorTable.Name = "dgv_donorTable";
            this.dgv_donorTable.Size = new System.Drawing.Size(474, 394);
            this.dgv_donorTable.TabIndex = 0;
            // 
            // grp_Worker
            // 
            this.grp_Worker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_Worker.Controls.Add(this.dgv_workerTable);
            this.grp_Worker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Worker.Location = new System.Drawing.Point(505, 12);
            this.grp_Worker.Name = "grp_Worker";
            this.grp_Worker.Size = new System.Drawing.Size(480, 426);
            this.grp_Worker.TabIndex = 4;
            this.grp_Worker.TabStop = false;
            this.grp_Worker.Text = "Worker Table";
            // 
            // dgv_workerTable
            // 
            this.dgv_workerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_workerTable.Location = new System.Drawing.Point(7, 26);
            this.dgv_workerTable.Name = "dgv_workerTable";
            this.dgv_workerTable.Size = new System.Drawing.Size(467, 394);
            this.dgv_workerTable.TabIndex = 0;
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(664, 444);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(320, 152);
            this.btn_Return.TabIndex = 6;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_reportPrint
            // 
            this.btn_reportPrint.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_reportPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportPrint.Location = new System.Drawing.Point(338, 444);
            this.btn_reportPrint.Name = "btn_reportPrint";
            this.btn_reportPrint.Size = new System.Drawing.Size(161, 152);
            this.btn_reportPrint.TabIndex = 7;
            this.btn_reportPrint.Text = "Print Report";
            this.btn_reportPrint.UseVisualStyleBackColor = false;
            // 
            // frmAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(997, 602);
            this.Controls.Add(this.btn_reportPrint);
            this.Controls.Add(this.btn_sendEmail);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.grp_Worker);
            this.Controls.Add(this.btn_createAcc);
            this.Controls.Add(this.grp_donorDB);
            this.Name = "frmAdminForm";
            this.Text = "Admin_Form";
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.grp_donorDB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donorTable)).EndInit();
            this.grp_Worker.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_workerTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createAcc;
        private System.Windows.Forms.Button btn_sendEmail;
        private System.Windows.Forms.GroupBox grp_donorDB;
        private System.Windows.Forms.GroupBox grp_Worker;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_reportPrint;
        private System.Windows.Forms.DataGridView dgv_donorTable;
        private System.Windows.Forms.DataGridView dgv_workerTable;
    }
}