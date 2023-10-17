using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GYM
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DOBUY GADGETS\Documents\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void populate()
        {
            Con.Open();
            string query = "select * from MemberTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            memberDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void backviewbtn_Click(object sender, EventArgs e)
        {
            MainFotm mainFotm = new MainFotm();
            mainFotm.Show();
            this.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from MemberTb1 where PName='" + searchth.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            memberDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void searchbtn_Click(object sender, EventArgs e)
        {
            filterByName();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
