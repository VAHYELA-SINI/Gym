namespace GYM
{
    partial class Payment
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
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            amountth = new TextBox();
            label4 = new Label();
            periode = new DateTimePicker();
            label6 = new Label();
            resetbtn = new Button();
            paybtn = new Button();
            backbtn = new Button();
            pictureBox2 = new PictureBox();
            namecb = new ComboBox();
            paymentDGV = new DataGridView();
            label7 = new Label();
            searchname = new TextBox();
            searchbtn = new Button();
            refreshbtn = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(926, 9);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(26, 25);
            label3.TabIndex = 31;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(50, 64);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(114, 24);
            label1.TabIndex = 29;
            label1.Text = "PAYMENTS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(58, 358);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(93, 24);
            label5.TabIndex = 35;
            label5.Text = "Amount";
            // 
            // amountth
            // 
            amountth.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            amountth.ForeColor = Color.Blue;
            amountth.Location = new Point(58, 385);
            amountth.Name = "amountth";
            amountth.Size = new Size(225, 31);
            amountth.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(58, 277);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(169, 24);
            label4.TabIndex = 33;
            label4.Text = "Member Name";
            // 
            // periode
            // 
            periode.Location = new Point(58, 234);
            periode.Name = "periode";
            periode.Size = new Size(200, 23);
            periode.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(58, 207);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(136, 21);
            label6.TabIndex = 37;
            label6.Text = "Payment Month";
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.Blue;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            resetbtn.ForeColor = Color.White;
            resetbtn.Location = new Point(194, 496);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(80, 42);
            resetbtn.TabIndex = 42;
            resetbtn.Text = "RESET";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // paybtn
            // 
            paybtn.BackColor = Color.Blue;
            paybtn.FlatStyle = FlatStyle.Flat;
            paybtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            paybtn.ForeColor = Color.White;
            paybtn.Location = new Point(38, 496);
            paybtn.Name = "paybtn";
            paybtn.Size = new Size(84, 42);
            paybtn.TabIndex = 41;
            paybtn.Text = "PAY";
            paybtn.UseVisualStyleBackColor = false;
            paybtn.Click += paybtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = Color.Blue;
            backbtn.FlatStyle = FlatStyle.Flat;
            backbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            backbtn.ForeColor = Color.White;
            backbtn.Location = new Point(123, 554);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(84, 42);
            backbtn.TabIndex = 43;
            backbtn.Text = "BACK";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.dollar;
            pictureBox2.Location = new Point(63, 91);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 56);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 45;
            pictureBox2.TabStop = false;
            // 
            // namecb
            // 
            namecb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            namecb.FormattingEnabled = true;
            namecb.Items.AddRange(new object[] { "6AM-8AM", "8AM-10AM", "6PM-8PM", "8PM-10PM" });
            namecb.Location = new Point(58, 309);
            namecb.Name = "namecb";
            namecb.Size = new Size(121, 29);
            namecb.TabIndex = 46;
            // 
            // paymentDGV
            // 
            paymentDGV.BackgroundColor = Color.WhiteSmoke;
            paymentDGV.BorderStyle = BorderStyle.None;
            paymentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            paymentDGV.Location = new Point(332, 240);
            paymentDGV.Name = "paymentDGV";
            paymentDGV.RowTemplate.Height = 25;
            paymentDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            paymentDGV.Size = new Size(620, 368);
            paymentDGV.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(392, 137);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(114, 24);
            label7.TabIndex = 48;
            label7.Text = "PAYMENTS";
            // 
            // searchname
            // 
            searchname.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchname.ForeColor = Color.Blue;
            searchname.Location = new Point(332, 164);
            searchname.Name = "searchname";
            searchname.Size = new Size(225, 31);
            searchname.TabIndex = 49;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Blue;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(638, 164);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(108, 42);
            searchbtn.TabIndex = 50;
            searchbtn.Text = "SEARCH";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // refreshbtn
            // 
            refreshbtn.BackColor = Color.Blue;
            refreshbtn.FlatStyle = FlatStyle.Flat;
            refreshbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshbtn.ForeColor = Color.White;
            refreshbtn.Location = new Point(752, 164);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(108, 42);
            refreshbtn.TabIndex = 51;
            refreshbtn.Text = "REFRESH";
            refreshbtn.UseVisualStyleBackColor = false;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(407, 9);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(163, 33);
            label8.TabIndex = 52;
            label8.Text = "HACK GYM";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(973, 621);
            Controls.Add(label8);
            Controls.Add(refreshbtn);
            Controls.Add(searchbtn);
            Controls.Add(searchname);
            Controls.Add(label7);
            Controls.Add(paymentDGV);
            Controls.Add(namecb);
            Controls.Add(pictureBox2);
            Controls.Add(backbtn);
            Controls.Add(resetbtn);
            Controls.Add(paybtn);
            Controls.Add(label6);
            Controls.Add(periode);
            Controls.Add(label5);
            Controls.Add(amountth);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label5;
        private TextBox amountth;
        private Label label4;
        private DateTimePicker periode;
        private Label label6;
        private Button resetbtn;
        private Button paybtn;
        private Button backbtn;
        private PictureBox pictureBox2;
        private ComboBox namecb;
        private DataGridView paymentDGV;
        private Label label7;
        private TextBox searchname;
        private Button searchbtn;
        private Button refreshbtn;
        private Label label8;
    }
}