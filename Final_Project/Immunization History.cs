using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Final_Project
{
    public partial class ImmunizationHistory : Form
    {
        public ImmunizationHistory()
        {
            InitializeComponent();
        }
        //string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = H:\\ITS 245\\Final Project\\General_Medical_History.accdb";
        private void addButton_Click(object sender, EventArgs e)
        {
            //using (OleDbConnection pubConnection = new OleDbConnection(connString))
            //{
            //    OleDbCommand cmd = pubConnection.CreateCommand();
            //    pubConnection.Open();
            //    MessageBox.Show("Connection Succeeded");

            //    cmd.Connection = pubConnection;
            //    OleDbDataReader reader = cmd.ExecuteReader();
            //    cmd.CommandText = "Select patientID, vaccine, immunizationDate, experationDate, delivery, comments, hcpID, deleted From immunizationHistory ";


            //    reader.Close();
            //    pubConnection.Close();
            //}
        }

        private void ImmunizationHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
