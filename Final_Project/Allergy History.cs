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
    public partial class Allergy_History : Form
    {
        public Allergy_History()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Allergy_History_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allergryAddButton_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\\Final_ProjectWithEdits\\General_Medical_History.accdb";


            using (OleDbConnection pubConnection = new OleDbConnection(connString))
            {

                OleDbCommand cmd = pubConnection.CreateCommand();
                pubConnection.Open();
           

                //var patientIDToDisplay = Convert.ToInt32(patientIDBox.Text); //important. Converts the text entered in the patientID box into an int and sets that int equal to a variable  
                var allergyIDToAdd = Convert.ToInt32(allergyIDBox.Text);

                cmd.CommandText = "INSERT INTO allergyHistoryTable(AllergyID, allergen) VALUES('" + allergyIDBox.Text + "'" + allergenBox.Text + "')";
                //try using VALUES = ?,?,?", allergyIDBox.Text, ect. 
               

                cmd.Connection = pubConnection;
                //OleDbDataReader reader = cmd.ExecuteReader(); //reader reads in the data to display in labels or whatever. 
                //reader.Read();

                //displayLabel4.Text = reader.GetValue(0).ToString(); //reading in the value and setting it equal to patientIDBOX.text
               cmd.ExecuteNonQuery();
                MessageBox.Show("Addition Succeeded");
                //reader.Close();
                pubConnection.Close(); 
               // cmd.ExecuteNonQuery();
            }
        }

        private void allergyDeleteButton_Click(object sender, EventArgs e)
        {

        }

        private void displayLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
