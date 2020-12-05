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
    public partial class frmAdminForm : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmAdminForm()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            // WORKERS
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsWorker = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_workerTable.DataSource = ds.Tables["test_table"].DefaultView;

            // DONORS
            SqlDataAdapter dd = new SqlDataAdapter("SELECT * FROM test_table" +
                " WHERE IsDonor = 'Y'", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet dsd = new DataSet("test_table");
            dd.Fill(dsd, "test_table");
            dgv_donorTable.DataSource = dsd.Tables["test_table"].DefaultView;

            
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            //Opening CreateAdmin Form 
            frmCreateAdmin frmCreateAdmin = new frmCreateAdmin();
            //Hides this form
            this.Hide();
            //Opens CreateAdmin Form
            frmCreateAdmin.ShowDialog();
            //Opens THIS form when CreateAdmin closes
            this.Show();
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }
    }
}
