namespace GYM
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            Uid.Text = "";
            passth.Text = "";
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || passth.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (Uid.Text == "Admin" && passth.Text == "Admin")
            {
                MainFotm mainform = new MainFotm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Id or Password");
            }
        }

        private void Uid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}