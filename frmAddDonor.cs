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
    public partial class frmAddDonor : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmAddDonor()
        {
            InitializeComponent();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
        }

        private void btn_addDonor_Click(object sender, EventArgs e)
        {
            try
            {
                if (chk_Agreement.Checked == false)
                {
                    string message = "Please Agree to the Privacy Policy!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_firstName.Text == "")
                {
                    string message = "Add your Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_Age.Text == "")
                {
                    string message = "Add your Age!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_phNum.Text == "")
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
                else if (txt_streetNum.Text == "")
                {
                    string message = "Add your Street Number!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_streetName.Text == "")
                {
                    string message = "Add your Street Name!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (radb_Male.Checked == false && radb_Female.Checked == false)
                {
                    string message = "Select your Gender!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (radb_TypeA.Checked == false 
                    && radb_TypeB.Checked == false
                    && radb_TypeAB.Checked == false
                    && radb_O.Checked == false)
                {
                    string message = "Select your Blood Type!";
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
                    string message = "Enter your Username!";
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
                    string message = "Enter your Password!";
                    string caption = " ";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        this.Close();
                    }
                }
                else if (txt_confirmPass.Text == "")
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
                else if (txt_passWord.Text != txt_confirmPass.Text)
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

                    string gender = genderSelect();
                    string bGroup = bloodGroup();
                    string address = fullAddress();

                    sql = "INSERT INTO test_table(LastName, " +
               "FirstName, Password, PhoneNumber, EmailAddress, " +
               "Gender, BloodGroup, UserName, Address, Age, Schedule, " +
               "Appointment, IsDonor, IsAdmin, IsWorker) " +
               //values 
               "Values ('"+ txt_lastName.Text.ToString() +
               "', '"+ txt_firstName.Text.ToString() +
               "', '"+ txt_passWord.Text.ToString() +
               "', '"+ txt_phNum.Text.ToString() +
               "', '"+ txt_emailAdd.Text.ToString() + 
               "', '"+ gender +
               "', '"+ bGroup +
               "', '"+ txt_userName.Text.ToString() +
               "', '"+ address +
               "', '"+ txt_Age.Text.ToString() +
               "', 'N/A', 'None', 'Y', 'N', 'N')";
                    // Codes for identifying donors, workers, and admins on the database
                    ExecuteSQLStmt(sql);


                    // Username should be searched upon to prevent duplicates!
                    // Email Address field needs proofing!
                    string message = "Donor Account Created!";
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

        public string genderSelect()
        {
            string temp = "";

            if (radb_Male.Checked == true)
                temp = "Male";
            if (radb_Female.Checked == true)
                temp = "Female";

            return temp;
        }

        public string bloodGroup()
        {
            string temp = "";

            if (radb_TypeA.Checked == true)
                temp = "A";
            if (radb_TypeB.Checked == true)
                temp = "B";
            if (radb_TypeAB.Checked == true)
                temp = "AB";
            if (radb_O.Checked == true)
                temp = "O";

            return temp;
        }

        public string fullAddress()
        {
            string temp = "";

            temp = txt_streetNum.Text.ToString() + " " + txt_streetName.Text.ToString();

            return temp;
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

        private void txt_streetNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt_phNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
