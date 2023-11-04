/* 
 * Course:       DBAS 5206 02
 * Group Number: 6
 * Group member: Bei Jia, Yuqi Zhou, Vishwa Patel, Chiao-Yun Chung
 * Description:  Dashboard made for Project
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

namespace Room
{
    public partial class fomMain : Form
    {
        public fomMain()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-ECN134CA;Initial Catalog=DB_LRCH;User ID=sa;Password=123");
        //Click to display bed occupancy
        private void btnBedOccupancy_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand com = new SqlCommand("exec dbo.sp_GetBedOccupancy", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoGenerateColumns = false;
            // lblNumber.Text = com2.Parameters["@OutputVariableName"].Value.ToString();

            con.Close();

        }
        //Click to display Room occupancy
        private void btnRoomOccupancy_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.RoomOccupancy", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.AutoGenerateColumns = false;
            con.Close();
        }
        //Click to display Occupancy By Type occupancy
        private void btnOccupancyByType_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.RoomOccupancyByType", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;
            dataGridView3.AutoGenerateColumns = false;
            // LoadAllRecords("RoomOccupancyByType");
            con.Close();
        }
        //Click to display Discharging today occupancy
        private void btnDischarging_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.DischargingPatientsToday", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            dataGridView4.AutoGenerateColumns = false;
            con.Close();
        }
        //Click to display Empty Room occupancy
        private void btnEmptyRoom_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand com = new SqlCommand("exec dbo.BedOccupancy", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            dataGridView5.AutoGenerateColumns = false;
            con.Close();
        }



        
    }
}
