using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// needed for MsSql to work
using System.Data.SqlClient;

namespace Design_Document_Mock_Up
{
    public partial class frmWorkLogin : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmWorkLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            int match = 0;

            try
            {
                if (txt_ID.TextLength == 6)
                {
                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE UserName = '" +
                        txt_userName.Text + "' AND Password = '" +
                        txt_password.Text + "' AND PersonID = '" +
                        txt_ID.Text + "' AND IsAdmin = 'Y'", cnn);

                    SqlDataAdapter counter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    counter.Fill(ds);

                    // If unique return value, valid login
                    match = ds.Tables[0].Rows.Count;

                    if (match == 1)
                        adminLogin();
                    else
                    {
                        // Username should be searched upon to prevent duplicates!
                        // Email Address field needs proofing!
                        // Needs message for missing ID
                        string message = "Incorrect Username or Password!";
                        string caption = " ";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                }

                if (txt_ID.TextLength == 3)
                {
                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM test_table WHERE UserName = '" +
                        txt_userName.Text + "' AND Password = '" +
                        txt_password.Text + "' AND PersonID = '" +
                        txt_ID.Text + "' AND IsWorker = 'Y'", cnn);

                    SqlDataAdapter counter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    counter.Fill(ds);

                    // If unique return value, valid login
                    match = ds.Tables[0].Rows.Count;

                    if (match == 1)
                        loginSuccess();
                    else
                    {
                        // Username should be searched upon to prevent duplicates!
                        // Email Address field needs proofing!
                        // Needs message for missing ID
                        string message = "Incorrect Username or Password!";
                        string caption = " ";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result;
                        result = MessageBox.Show(message, caption, buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                        {
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_adminCreate_Click(object sender, EventArgs e)
        {
            //Opening Workers Form 
            frmCreateAdmin frmCreateAdmin = new frmCreateAdmin();
            //Hides this form
            this.Hide();
            //Opens Workers Form
            frmCreateAdmin.ShowDialog();
            //Opens THIS form when Workers closes
            this.Show();
        }

        private void loginSuccess()
        {
            txt_userName.Text = "";
            txt_password.Text = "";
            txt_ID.Text = "";
            //Opening Workers Form 
            frmWorkercs frmWorkercs = new frmWorkercs();
            //Hides this form
            this.Hide();
            //Opens Workers Form
            frmWorkercs.ShowDialog();
            //Opens THIS form when Workers closes
            this.Show();
        }

        private void adminLogin()
        {
            txt_userName.Text = "";
            txt_password.Text = "";
            txt_ID.Text = "";
            //Opening Workers Form 
            frmAdminForm frmAdminForm = new frmAdminForm();
            //Hides this form
            this.Hide();
            //Opens Workers Form
            frmAdminForm.ShowDialog();
            //Opens THIS form when Workers closes
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_userName.Text = "";
            txt_password.Text = "";
            txt_ID.Text = "";
            //Opening Workers Form 
            frmWorkercs frmWorkercs = new frmWorkercs();
            //Hides this form
            this.Hide();
            //Opens Workers Form
            frmWorkercs.ShowDialog();
            //Opens THIS form when Workers closes
            this.Show();
        }
    }
}
