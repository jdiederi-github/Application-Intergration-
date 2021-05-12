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
    public partial class FamilyHistory : Form
    {
        public FamilyHistory()
        {
            InitializeComponent();
        }
        public FamilyHistory(string name)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = F:\\Final_Project\\General_Medical_History.accdb";

            using (OleDbConnection pubConnection = new OleDbConnection(connString))
            {
                OleDbCommand commandobject = pubConnection.CreateCommand();
                pubConnection.Open();
                commandobject.Connection = pubConnection;
                MessageBox.Show("Connection Succeeded");


                commandobject.CommandText = "SELECT familyName FROM familyHistoryTable";

                OleDbDataReader dr = commandobject.ExecuteReader();
                dr.Read();

                nameBox.Text = dr.GetValue(0).ToString();

                dr.Close();
                pubConnection.Close();
                commandobject.ExecuteNonQuery();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void FamilyHistory_Load(object sender, EventArgs e)
        {

        }
    }
}
