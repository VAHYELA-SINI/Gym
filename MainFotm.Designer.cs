namespace GYM
{
    partial class MainFotm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            updatebtn = new Button();
            memberbtn = new Button();
            paymentbtn = new Button();
            panel1 = new Panel();
            viewmemberbtn = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.gym;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Blue;
            updatebtn.Location = new Point(475, 3);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(191, 53);
            updatebtn.TabIndex = 1;
            updatebtn.Text = "UPDATE/DELETE";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // memberbtn
            // 
            memberbtn.BackColor = Color.Blue;
            memberbtn.Location = new Point(219, 0);
            memberbtn.Name = "memberbtn";
            memberbtn.Size = new Size(118, 53);
            memberbtn.TabIndex = 2;
            memberbtn.Text = "ADD MEMBER";
            memberbtn.UseVisualStyleBackColor = false;
            memberbtn.Click += memberbtn_Click;
            // 
            // paymentbtn
            // 
            paymentbtn.BackColor = Color.Blue;
            paymentbtn.Location = new Point(672, 3);
            paymentbtn.Name = "paymentbtn";
            paymentbtn.Size = new Size(118, 53);
            paymentbtn.TabIndex = 4;
            paymentbtn.Text = "PAYMENT";
            paymentbtn.UseVisualStyleBackColor = false;
            paymentbtn.Click += paymentbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(viewmemberbtn);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(paymentbtn);
            panel1.Controls.Add(updatebtn);
            panel1.Controls.Add(memberbtn);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 65);
            panel1.TabIndex = 5;
            // 
            // viewmemberbtn
            // 
            viewmemberbtn.BackColor = Color.Blue;
            viewmemberbtn.Location = new Point(351, 3);
            viewmemberbtn.Name = "viewmemberbtn";
            viewmemberbtn.Size = new Size(118, 53);
            viewmemberbtn.TabIndex = 6;
            viewmemberbtn.Text = "VIEW MEMBER";
            viewmemberbtn.UseVisualStyleBackColor = false;
            viewmemberbtn.Click += viewmemberbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.working_out_silhouette;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // MainFotm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainFotm";
            Text = "MainFotm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button updatebtn;
        private Button memberbtn;
        private Button paymentbtn;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button viewmemberbtn;
    }
}