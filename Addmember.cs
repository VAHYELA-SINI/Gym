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
    public partial class Addmember : Form
    {
        public Addmember()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\DOBUY GADGETS\Documents\GymDb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void Addmember_Load(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (NameTh.Text == "" || PhoneTh.Text == "" || AmountTh.Text == "" || AgeTh.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into MemberTb1 values('" + NameTh.Text + "','" + PhoneTh.Text + "','" + GenderCh.SelectedItem.ToString() + "'," + AgeTh.Text + "," + AmountTh.Text + ",'" + TimingCh.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added");
                    Con.Close();
                    AmountTh.Text = "";
                    AgeTh.Text = "";
                    NameTh.Text = "";
                    PhoneTh.Text = "";
                    GenderCh.Text = "";
                    TimingCh.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            AmountTh.Text = "";
            AgeTh.Text = "";
            NameTh.Text = "";
            PhoneTh.Text = "";
            GenderCh.Text = "";
            TimingCh.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back1btn_Click(object sender, EventArgs e)
        {
            MainFotm mainFotm = new MainFotm();
            mainFotm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainFotm mainFotm = new MainFotm();
            mainFotm.Show();
            this.Close();
        }

        private void NameTh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

