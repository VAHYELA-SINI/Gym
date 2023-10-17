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
    public partial class MainFotm : Form
    {
        public MainFotm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void memberbtn_Click(object sender, EventArgs e)
        {
            Addmember addmember = new Addmember();
            addmember.Show();
            this.Hide();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            updateDelete Update = new updateDelete();
            Update.Show();
            this.Hide();
        }

        private void paymentbtn_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {

        }

        private void viewmemberbtn_Click(object sender, EventArgs e)
        {
            ViewMembers viewmember = new ViewMembers();
            viewmember.Show();
            this.Hide();
        }
    }
}
