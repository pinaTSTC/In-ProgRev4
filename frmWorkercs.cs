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
    public partial class frmWorkercs : Form
    {
        private string connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
        private SqlDataReader reader = null;
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlConnection cnn = null;
        private SqlCommand cmd = null;
        private string sql = null;

        public frmWorkercs()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            //Closes the form when RETURN button is clicked
            this.Hide();
        }

        private void btn_createAcc_Click(object sender, EventArgs e)
        {
            //Opening CreateWorker Form 
            frmCreateWorker frmCreateWorker = new frmCreateWorker();
            //Hides this form
            this.Hide();
            //Opens CreateWorker Form
            frmCreateWorker.ShowDialog();
            //Opens THIS form when CreateWorker closes
            this.Show();
        }

        private void frmWorkercs_Load(object sender, EventArgs e)
        {
            //MUST BE EDITED TO ONLY PULL DONOR RECORDS

            cnn = new SqlConnection(connectionString);
            /// Open the connection  
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
            cnn.ConnectionString = connectionString;
            cnn.Open();

            // Create a data adapter  
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM test_table", cnn);
            // Create DataSet, fill it and view in data grid  
            DataSet ds = new DataSet("test_table");
            da.Fill(ds, "test_table");
            dgv_donorTable.DataSource = ds.Tables["test_table"].DefaultView;
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

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = dgv_donorTable.CurrentCell.RowIndex;
                //DataRow row = (dgv_donorTable.SelectedRows[selectedIndex].DataBoundItem as DataRowView).Row;

                if (selectedIndex > -1)
                {
                    dgv_donorTable.Rows.RemoveAt(selectedIndex);
                    dgv_donorTable.Refresh();

                    // ADD SQL STUFF 
                    cnn = new SqlConnection(connectionString);
                    /// Open the connection  
                    if (cnn.State == ConnectionState.Open)
                        cnn.Close();
                    connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6a;Password=group6a";
                    cnn.ConnectionString = connectionString;
                    cnn.Open();



                    //"DELETE FROM tem_order WHERE temp_orderID = " + row["ID-column-name"]

                    sql = "DELETE FROM test_table WHERE id = " + selectedIndex + "";

                    ExecuteSQLStmt(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
