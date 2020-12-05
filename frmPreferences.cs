using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Document_Mock_Up
{
    public partial class frmPreferences : Form
    {

        
        public frmPreferences()
        {
            InitializeComponent();
            
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void frmPreferences_Load(object sender, EventArgs e)
        {
            //radio "SMALL" button is checked by default
            radb_fSmall.Checked = true;
        }

        private void btn_SavenExit_Click(object sender, EventArgs e) 
        {
            //If User checks Dark; change forms color scheme to Black
            if(radb_Dark.Checked)
            {
                this.BackColor = Color.Black;
                this.Hide();
            }
        }
    }
}
