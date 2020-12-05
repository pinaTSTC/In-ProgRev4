namespace Design_Document_Mock_Up
{
    partial class frmPreferences
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
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_SavenExit = new System.Windows.Forms.Button();
            this.radb_fSmall = new System.Windows.Forms.RadioButton();
            this.radb_fMedium = new System.Windows.Forms.RadioButton();
            this.radb_fLarge = new System.Windows.Forms.RadioButton();
            this.grpb_ColorSch = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grp_Classic = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_example1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radb_Dark = new System.Windows.Forms.RadioButton();
            this.radb_Bright = new System.Windows.Forms.RadioButton();
            this.radb_Classic = new System.Windows.Forms.RadioButton();
            this.grpb_Font = new System.Windows.Forms.GroupBox();
            this.grpb_ColorSch.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_Classic.SuspendLayout();
            this.grp_example1.SuspendLayout();
            this.grpb_Font.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Return
            // 
            this.btn_Return.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(646, 384);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(142, 54);
            this.btn_Return.TabIndex = 0;
            this.btn_Return.Text = "Return";
            this.btn_Return.UseVisualStyleBackColor = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_SavenExit
            // 
            this.btn_SavenExit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_SavenExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SavenExit.Location = new System.Drawing.Point(463, 384);
            this.btn_SavenExit.Name = "btn_SavenExit";
            this.btn_SavenExit.Size = new System.Drawing.Size(177, 54);
            this.btn_SavenExit.TabIndex = 1;
            this.btn_SavenExit.Text = "Save And Return";
            this.btn_SavenExit.UseVisualStyleBackColor = false;
            this.btn_SavenExit.Click += new System.EventHandler(this.btn_SavenExit_Click);
            // 
            // radb_fSmall
            // 
            this.radb_fSmall.AutoSize = true;
            this.radb_fSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_fSmall.Location = new System.Drawing.Point(78, 52);
            this.radb_fSmall.Name = "radb_fSmall";
            this.radb_fSmall.Size = new System.Drawing.Size(86, 30);
            this.radb_fSmall.TabIndex = 3;
            this.radb_fSmall.TabStop = true;
            this.radb_fSmall.Text = "Small";
            this.radb_fSmall.UseVisualStyleBackColor = true;
            // 
            // radb_fMedium
            // 
            this.radb_fMedium.AutoSize = true;
            this.radb_fMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_fMedium.Location = new System.Drawing.Point(299, 47);
            this.radb_fMedium.Name = "radb_fMedium";
            this.radb_fMedium.Size = new System.Drawing.Size(127, 35);
            this.radb_fMedium.TabIndex = 4;
            this.radb_fMedium.TabStop = true;
            this.radb_fMedium.Text = "Medium";
            this.radb_fMedium.UseVisualStyleBackColor = true;
            // 
            // radb_fLarge
            // 
            this.radb_fLarge.AutoSize = true;
            this.radb_fLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radb_fLarge.Location = new System.Drawing.Point(560, 44);
            this.radb_fLarge.Name = "radb_fLarge";
            this.radb_fLarge.Size = new System.Drawing.Size(117, 41);
            this.radb_fLarge.TabIndex = 5;
            this.radb_fLarge.TabStop = true;
            this.radb_fLarge.Text = "Large";
            this.radb_fLarge.UseVisualStyleBackColor = true;
            // 
            // grpb_ColorSch
            // 
            this.grpb_ColorSch.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpb_ColorSch.Controls.Add(this.groupBox3);
            this.grpb_ColorSch.Controls.Add(this.groupBox1);
            this.grpb_ColorSch.Controls.Add(this.grp_Classic);
            this.grpb_ColorSch.Controls.Add(this.radb_Dark);
            this.grpb_ColorSch.Controls.Add(this.radb_Bright);
            this.grpb_ColorSch.Controls.Add(this.radb_Classic);
            this.grpb_ColorSch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_ColorSch.Location = new System.Drawing.Point(12, 143);
            this.grpb_ColorSch.Name = "grpb_ColorSch";
            this.grpb_ColorSch.Size = new System.Drawing.Size(776, 235);
            this.grpb_ColorSch.TabIndex = 7;
            this.grpb_ColorSch.TabStop = false;
            this.grpb_ColorSch.Text = "Color Scheme";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(520, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 140);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(94, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 32);
            this.button3.TabIndex = 1;
            this.button3.Text = "button";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DimGray;
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(6, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 94);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Menu";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 32);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "text";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(274, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCyan;
            this.button2.Location = new System.Drawing.Point(94, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "button";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(6, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 94);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(82, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 32);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "text";
            // 
            // grp_Classic
            // 
            this.grp_Classic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grp_Classic.Controls.Add(this.button1);
            this.grp_Classic.Controls.Add(this.grp_example1);
            this.grp_Classic.Location = new System.Drawing.Point(33, 76);
            this.grp_Classic.Name = "grp_Classic";
            this.grp_Classic.Size = new System.Drawing.Size(200, 140);
            this.grp_Classic.TabIndex = 3;
            this.grp_Classic.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(94, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "button";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // grp_example1
            // 
            this.grp_example1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grp_example1.Controls.Add(this.textBox1);
            this.grp_example1.Location = new System.Drawing.Point(6, 11);
            this.grp_example1.Name = "grp_example1";
            this.grp_example1.Size = new System.Drawing.Size(188, 94);
            this.grp_example1.TabIndex = 0;
            this.grp_example1.TabStop = false;
            this.grp_example1.Text = "Menu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 32);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "text";
            // 
            // radb_Dark
            // 
            this.radb_Dark.AutoSize = true;
            this.radb_Dark.Location = new System.Drawing.Point(581, 40);
            this.radb_Dark.Name = "radb_Dark";
            this.radb_Dark.Size = new System.Drawing.Size(76, 30);
            this.radb_Dark.TabIndex = 2;
            this.radb_Dark.TabStop = true;
            this.radb_Dark.Text = "Dark";
            this.radb_Dark.UseVisualStyleBackColor = true;
            // 
            // radb_Bright
            // 
            this.radb_Bright.AutoSize = true;
            this.radb_Bright.Location = new System.Drawing.Point(289, 40);
            this.radb_Bright.Name = "radb_Bright";
            this.radb_Bright.Size = new System.Drawing.Size(179, 30);
            this.radb_Bright.TabIndex = 1;
            this.radb_Bright.TabStop = true;
            this.radb_Bright.Text = "Bright and Blue";
            this.radb_Bright.UseVisualStyleBackColor = true;
            // 
            // radb_Classic
            // 
            this.radb_Classic.AutoSize = true;
            this.radb_Classic.Location = new System.Drawing.Point(78, 40);
            this.radb_Classic.Name = "radb_Classic";
            this.radb_Classic.Size = new System.Drawing.Size(101, 30);
            this.radb_Classic.TabIndex = 0;
            this.radb_Classic.TabStop = true;
            this.radb_Classic.Text = "Classic";
            this.radb_Classic.UseVisualStyleBackColor = true;
            // 
            // grpb_Font
            // 
            this.grpb_Font.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpb_Font.Controls.Add(this.radb_fSmall);
            this.grpb_Font.Controls.Add(this.radb_fMedium);
            this.grpb_Font.Controls.Add(this.radb_fLarge);
            this.grpb_Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpb_Font.Location = new System.Drawing.Point(12, 12);
            this.grpb_Font.Name = "grpb_Font";
            this.grpb_Font.Size = new System.Drawing.Size(776, 125);
            this.grpb_Font.TabIndex = 8;
            this.grpb_Font.TabStop = false;
            this.grpb_Font.Text = "Select a Font";
            // 
            // frmPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpb_Font);
            this.Controls.Add(this.grpb_ColorSch);
            this.Controls.Add(this.btn_SavenExit);
            this.Controls.Add(this.btn_Return);
            this.Name = "frmPreferences";
            this.Text = "frmPreferences";
            this.Load += new System.EventHandler(this.frmPreferences_Load);
            this.grpb_ColorSch.ResumeLayout(false);
            this.grpb_ColorSch.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_Classic.ResumeLayout(false);
            this.grp_example1.ResumeLayout(false);
            this.grp_example1.PerformLayout();
            this.grpb_Font.ResumeLayout(false);
            this.grpb_Font.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_SavenExit;
        private System.Windows.Forms.RadioButton radb_fSmall;
        private System.Windows.Forms.RadioButton radb_fMedium;
        private System.Windows.Forms.RadioButton radb_fLarge;
        private System.Windows.Forms.GroupBox grpb_ColorSch;
        private System.Windows.Forms.GroupBox grpb_Font;
        private System.Windows.Forms.GroupBox grp_Classic;
        private System.Windows.Forms.RadioButton radb_Dark;
        private System.Windows.Forms.RadioButton radb_Bright;
        private System.Windows.Forms.RadioButton radb_Classic;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_example1;
        private System.Windows.Forms.TextBox textBox1;
    }
}