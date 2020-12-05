using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Document_Mock_Up
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connectionString = null;
            SqlConnection tstc;

            connectionString = "Data Source=cstnt.tstc.edu;Initial Catalog=inew2330fa20;User ID=group6;Password=password6";
            tstc = new SqlConnection(connectionString);

            try 
            {
                tstc.Open();
                Console.WriteLine("Connection Open ! ");
                while (true)
                {
                    try
                    {
                        string query = "";
                        Console.WriteLine("Enter Query: ");
                        query = Console.ReadLine();

                        SqlCommand command = new SqlCommand(query, tstc);
                        SqlDataReader dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            for (int i = 0; i < dataReader.FieldCount; i++)
                            {
                                Console.Write(dataReader[i] + "\t");

                            }
                            dataReader.Close();
                        }
                    }
                    catch (SqlException x)
                    {
                        Console.WriteLine(x.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            tstc.Close();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
