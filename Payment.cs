using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GYM
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DOBUY GADGETS\Documents\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void FillName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select MName from MemberTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Mname", typeof(string));
            dt.Load(rdr);
            namecb.ValueMember = "MName";
            namecb.DataSource = dt;
            Con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            //nameth.Text = "";
            amountth.Text = "0";
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainFotm mainFotm = new MainFotm();
            mainFotm.Show();
            this.Close();
        }
        private void filterByName()
        {
            Con.Open();
            string query = "select * from PaymentTb1 where PMember='" + searchname.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from PaymentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            paymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void paybtn_Click(object sender, EventArgs e)
        {
            if (namecb.Text == "" || amountth.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                string payperiode = periode.Value.Month.ToString() + periode.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from PaymentTb1 where PMember='" + namecb.SelectedValue.ToString() + "' and PMonth='" + payperiode + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Already Paid for this Month");
                }
                else
                {
                    string query = "insert into PaymentTb1 values('" + payperiode + "','" + namecb.SelectedValue.ToString() + "'," + amountth.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Amount Paid Successfully");
                }
                Con.Close();
                populate();
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            FillName();
            populate();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            filterByName();
            searchname.Text = "";

        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
