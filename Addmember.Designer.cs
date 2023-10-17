namespace GYM
{
    partial class Addmember
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NameTh = new TextBox();
            label4 = new Label();
            label5 = new Label();
            PhoneTh = new TextBox();
            label6 = new Label();
            AgeTh = new TextBox();
            label7 = new Label();
            GenderCh = new ComboBox();
            label8 = new Label();
            AmountTh = new TextBox();
            label9 = new Label();
            TimingCh = new ComboBox();
            resetbtn = new Button();
            addbtn = new Button();
            button3 = new Button();
            back1btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(330, 43);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(200, 24);
            label1.TabIndex = 2;
            label1.Text = "ADD NEW MEMBER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(330, 9);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(161, 25);
            label2.TabIndex = 3;
            label2.Text = "FITNESSCENTER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(794, -1);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(26, 25);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // NameTh
            // 
            NameTh.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            NameTh.ForeColor = Color.Blue;
            NameTh.Location = new Point(34, 137);
            NameTh.Name = "NameTh";
            NameTh.Size = new Size(225, 31);
            NameTh.TabIndex = 5;
            NameTh.TextChanged += NameTh_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(34, 98);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(169, 24);
            label4.TabIndex = 6;
            label4.Text = "Member Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(305, 98);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(166, 24);
            label5.TabIndex = 8;
            label5.Text = "Phone Number";
            label5.Click += label5_Click;
            // 
            // PhoneTh
            // 
            PhoneTh.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTh.ForeColor = Color.Blue;
            PhoneTh.Location = new Point(305, 137);
            PhoneTh.Name = "PhoneTh";
            PhoneTh.Size = new Size(225, 31);
            PhoneTh.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(595, 98);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(53, 24);
            label6.TabIndex = 10;
            label6.Text = "Age";
            // 
            // AgeTh
            // 
            AgeTh.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTh.ForeColor = Color.Blue;
            AgeTh.Location = new Point(595, 137);
            AgeTh.Name = "AgeTh";
            AgeTh.Size = new Size(225, 31);
            AgeTh.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(34, 208);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(89, 24);
            label7.TabIndex = 12;
            label7.Text = "Gender";
            // 
            // GenderCh
            // 
            GenderCh.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCh.FormattingEnabled = true;
            GenderCh.Items.AddRange(new object[] { "Male", "Female" });
            GenderCh.Location = new Point(34, 261);
            GenderCh.Name = "GenderCh";
            GenderCh.Size = new Size(121, 29);
            GenderCh.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(305, 208);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(181, 24);
            label8.TabIndex = 15;
            label8.Text = "Monthly Amount";
            // 
            // AmountTh
            // 
            AmountTh.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTh.ForeColor = Color.Blue;
            AmountTh.Location = new Point(305, 247);
            AmountTh.Name = "AmountTh";
            AmountTh.Size = new Size(225, 31);
            AmountTh.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(595, 206);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.Yes;
            label9.Size = new Size(72, 24);
            label9.TabIndex = 17;
            label9.Text = "Timing";
            // 
            // TimingCh
            // 
            TimingCh.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TimingCh.FormattingEnabled = true;
            TimingCh.Items.AddRange(new object[] { "6AM-8AM", "8AM-10AM", "6PM-8PM", "8PM-10PM" });
            TimingCh.Location = new Point(595, 248);
            TimingCh.Name = "TimingCh";
            TimingCh.Size = new Size(121, 29);
            TimingCh.TabIndex = 18;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Blue;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(392, 433);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(99, 42);
            resetbtn.TabIndex = 19;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // addbtn
            // 
            addbtn.BackColor = Color.Blue;
            addbtn.FlatStyle = FlatStyle.Flat;
            addbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addbtn.ForeColor = Color.White;
            addbtn.Location = new Point(253, 433);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(99, 42);
            addbtn.TabIndex = 20;
            addbtn.Text = "ADD";
            addbtn.UseVisualStyleBackColor = false;
            addbtn.Click += addbtn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(524, 433);
            button3.Name = "button3";
            button3.Size = new Size(99, 42);
            button3.TabIndex = 21;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // back1btn
            // 
            back1btn.BackColor = Color.Blue;
            back1btn.FlatStyle = FlatStyle.Flat;
            back1btn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            back1btn.ForeColor = Color.White;
            back1btn.Location = new Point(392, 493);
            back1btn.Name = "back1btn";
            back1btn.Size = new Size(94, 30);
            back1btn.TabIndex = 22;
            back1btn.Text = "BACK";
            back1btn.UseVisualStyleBackColor = false;
            back1btn.Click += back1btn_Click;
            // 
            // Addmember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 558);
            Controls.Add(back1btn);
            Controls.Add(button3);
            Controls.Add(addbtn);
            Controls.Add(resetbtn);
            Controls.Add(TimingCh);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AmountTh);
            Controls.Add(GenderCh);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AgeTh);
            Controls.Add(label5);
            Controls.Add(PhoneTh);
            Controls.Add(label4);
            Controls.Add(NameTh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Addmember";
            Text = "Addmember";
            Load += Addmember_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NameTh;
        private Label label4;
        private Label label5;
        private TextBox PhoneTh;
        private Label label6;
        private TextBox AgeTh;
        private Label label7;
        private ComboBox GenderCh;
        private Label label8;
        private TextBox AmountTh;
        private Label label9;
        private ComboBox TimingCh;
        private Button resetbtn;
        private Button addbtn;
        private Button button3;
        private Button back1btn;
    }
}