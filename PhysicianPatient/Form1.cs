/* 
 * Course:       DBAS-5206-02
 * Group Number: 6
 * Group member: Bei Jia, Yuqi Zhou, Vishwa Patel, Chiao-Yun Chung
 * Description:  Dashboard for DBAS Project
 */

using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhysicianPatient
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-CPJPFDQ;Initial Catalog=DB_LRCH;Integrated Security=True;");

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Assuming you have a TextBox named txtAdmissionId where users enter the Admission ID
            if (int.TryParse(txtAdmissionId.Text, out int admissionId))
            {
                con.Open();
                LoadRecordByAdmissionId(admissionId);
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid Admission ID.");
            }
        }

        // Load the record for a specific Admission ID
        void LoadRecordByAdmissionId(int admissionId)
        {
            SqlCommand com = new SqlCommand("dbo.GetPatientAdmissionById", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@admission_id", admissionId); // Use the correct parameter name as defined in your stored procedure

            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
