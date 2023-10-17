namespace GYM
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Uid = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            passth = new TextBox();
            resetbtn = new Button();
            loginbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.dumbbells_floor_gym_ai_generative;
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(370, 410);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(491, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(163, 33);
            label1.TabIndex = 1;
            label1.Text = "HACK GYM";
            // 
            // Uid
            // 
            Uid.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Uid.Location = new Point(412, 125);
            Uid.Name = "Uid";
            Uid.Size = new Size(231, 37);
            Uid.TabIndex = 2;
            Uid.TextChanged += Uid_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(642, 125);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(60, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.padlock;
            pictureBox3.Location = new Point(642, 186);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(60, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // passth
            // 
            passth.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passth.Location = new Point(412, 186);
            passth.Name = "passth";
            passth.PasswordChar = '*';
            passth.Size = new Size(231, 37);
            passth.TabIndex = 4;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Blue;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(412, 322);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(99, 42);
            resetbtn.TabIndex = 6;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Blue;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(563, 322);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(99, 42);
            loginbtn.TabIndex = 7;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(754, 414);
            Controls.Add(loginbtn);
            Controls.Add(resetbtn);
            Controls.Add(pictureBox3);
            Controls.Add(passth);
            Controls.Add(pictureBox2);
            Controls.Add(Uid);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox Uid;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox passth;
        private Button resetbtn;
        private Button loginbtn;
    }
}