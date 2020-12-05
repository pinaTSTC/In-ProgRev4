using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// needed for MySql to work
using System.Data.SqlClient;

namespace Design_Document_Mock_Up
{
    public partial class frmCreateAdmin : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmCreateAdmin()
        {
            InitializeComponent();
        }

        private void btn_addAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_First.Text == "")
                {
                    string message = "Add your First Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_Last.Text == "")
                {
                    string message = "Add your Last Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_userName.Text == "")
                {
                    string message = "Add your User Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passWord.Text == "")
                {
                    string message = "Add your Password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passConf.Text == "")
                {
                    string message = "Confirm your password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_passWord.Text != txt_passConf.Text)
                {
                    string message = "Passwords do not match!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_phoneNum.Text == "")
                {
                    string message = "Add your Phone Number!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_emailAdd.Text == "")
                {
                    string message = "Add your Email Address!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else
                {
                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();

                    string gender = "";
                    string bGroup = "";
                    string address = "";
                    string schedule = "";
                    string IDcode = lbl_randCode.Text.ToString();

                    sql = "INSERT INTO test_table(PersonID, LastName, " +
               "FirstName, Password, PhoneNumber, EmailAddress, " +
               "Gender, BloodGroup, UserName, Address, Age, Schedule, " +
               "Appointment, IsDonor, IsAdmin, IsWorker) " +
               //values 
               "Values ('"+ IDcode +
               "', '" + txt_Last.Text.ToString() +
               "', '" + txt_First.Text.ToString() +
               "', '" + txt_passWord.Text.ToString() +
               "', '" + txt_phoneNum.Text.ToString() +
               "', '" + txt_emailAdd.Text.ToString() +
               "', '" + gender +
               "', '" + bGroup +
               "', '" + txt_userName.Text.ToString() +
               "', '" + address +
               "', '" + "" +
               "', '" + schedule +
               "', 'None', 'N', 'Y', 'N')";
                    // Codes for identifying donors, workers, and admins on the database
                    ExecuteSQLStmt(sql);

                    // To DO
                    // Username should be searched upon to prevent duplicates!
                    // ID code needs random generation!
                    //      ID code must also not be a duplicate
                    // Email Address field needs proofing!
                    string message = "Admin Account Created!";
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string randID()
        {
            string strID = "";
            Random r = new Random();
            int getRand = r.Next(100, 999);
            strID = "ADM" + getRand.ToString();

            // prevent duplicate IDs from being accepted

            return strID;
        }

        private void btn_genIDCode_Click(object sender, EventArgs e)
        {
            lbl_randCode.Text = "";
            lbl_randCode.Text = randID();
        }

        private void frmCreateAdmin_Load(object sender, EventArgs e)
        {
            lbl_randCode.Text = randID();
        }

        private void ExecuteSQLStmt(string sql)
        {
            cnn = new SqlConnection(connectionString);
            // Open the connection  
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
            //cnn = new SqlConnection(connectionString);
            //if (cnn.State == ConnectionState.Open)
            //    cnn.Close();
            //cnn.Open();
            cmd = new SqlCommand(sql, cnn);
            adapter.InsertCommand = new SqlCommand(sql, cnn);
            try
            {
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
        }

        private void txt_phoneNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}