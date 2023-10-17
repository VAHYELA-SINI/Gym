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
    public partial class updateDelete : Form
    {
        public updateDelete()
        {
            InitializeComponent();
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

        private void updateDelete_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select The Member To Be Deleted");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from MemberTb1 where MId=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (key == 0 || nameth.Text == "" || phoneth.Text == "" || ageth.Text == "" || amountth.Text == "" || gencb.Text == "" || timingcb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update MemberTb1 set MName = '" + nameth.Text + "', MPhone= '" + phoneth.Text + "',MGen='" + gencb.Text + "', MAge= " + ageth.Text + ", MAmount= " + amountth.Text + ", MTiming= '" + timingcb.Text + "' where MId=" + key + " ;";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Updated Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int key = 0;
        private void memberDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                key = Convert.ToInt32(memberDGV.SelectedRows[0].Cells[0].Value.ToString());

                nameth.Text = memberDGV.SelectedRows[0].Cells[1].Value?.ToString();
                phoneth.Text = memberDGV.SelectedRows[0].Cells[2].Value?.ToString();
                gencb.Text = memberDGV.SelectedRows[0].Cells[3].Value?.ToString();
                ageth.Text = memberDGV.SelectedRows[0].Cells[4].Value?.ToString();
                amountth.Text = memberDGV.SelectedRows[0].Cells[5].Value?.ToString();
                timingcb.Text = memberDGV.SelectedRows[0].Cells[6].Value?.ToString();
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            nameth.Text = "";
            ageth.Text = "";
            phoneth.Text = "";
            timingcb.Text = "";
            amountth.Text = "";
            gencb.Text = "";
        }

        private void BACKUPBTN_Click(object sender, EventArgs e)
        {
            MainFotm mainFotm = new MainFotm();
            mainFotm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
