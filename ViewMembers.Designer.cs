namespace GYM
{
    partial class ViewMembers
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
            memberDGV = new DataGridView();
            searchbtn = new Button();
            searchth = new TextBox();
            refreshbtn = new Button();
            backviewbtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)memberDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(924, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(26, 25);
            label3.TabIndex = 28;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(379, 47);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(144, 24);
            label1.TabIndex = 26;
            label1.Text = "MEMBERS LIST";
            // 
            // memberDGV
            // 
            memberDGV.BackgroundColor = Color.WhiteSmoke;
            memberDGV.BorderStyle = BorderStyle.None;
            memberDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberDGV.Location = new Point(48, 148);
            memberDGV.Name = "memberDGV";
            memberDGV.RowTemplate.Height = 25;
            memberDGV.Size = new Size(869, 417);
            memberDGV.TabIndex = 43;
            memberDGV.CellContentClick += dataGridView1_CellContentClick;
            // 
            // searchbtn
            // 
            searchbtn.BackColor = Color.Blue;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(558, 100);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(105, 42);
            searchbtn.TabIndex = 44;
            searchbtn.Text = "SEARCH";
            searchbtn.UseVisualStyleBackColor = false;
            searchbtn.Click += searchbtn_Click;
            // 
            // searchth
            // 
            searchth.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchth.ForeColor = Color.Blue;
            searchth.Location = new Point(327, 108);
            searchth.Name = "searchth";
            searchth.Size = new Size(225, 31);
            searchth.TabIndex = 45;
            // 
            // refreshbtn
            // 
            refreshbtn.BackColor = Color.Blue;
            refreshbtn.FlatStyle = FlatStyle.Flat;
            refreshbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            refreshbtn.ForeColor = Color.White;
            refreshbtn.Location = new Point(669, 100);
            refreshbtn.Name = "refreshbtn";
            refreshbtn.Size = new Size(105, 42);
            refreshbtn.TabIndex = 46;
            refreshbtn.Text = "REFRESH";
            refreshbtn.UseVisualStyleBackColor = false;
            refreshbtn.Click += refreshbtn_Click;
            // 
            // backviewbtn
            // 
            backviewbtn.BackColor = Color.Blue;
            backviewbtn.FlatStyle = FlatStyle.Flat;
            backviewbtn.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            backviewbtn.ForeColor = Color.White;
            backviewbtn.Location = new Point(427, 571);
            backviewbtn.Name = "backviewbtn";
            backviewbtn.Size = new Size(105, 42);
            backviewbtn.TabIndex = 47;
            backviewbtn.Text = "BACK";
            backviewbtn.UseVisualStyleBackColor = false;
            backviewbtn.Click += backviewbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(369, 4);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(163, 33);
            label2.TabIndex = 48;
            label2.Text = "HACK GYM";
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(973, 621);
            Controls.Add(label2);
            Controls.Add(backviewbtn);
            Controls.Add(refreshbtn);
            Controls.Add(searchth);
            Controls.Add(searchbtn);
            Controls.Add(memberDGV);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewMembers";
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)memberDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private DataGridView memberDGV;
        private Button searchbtn;
        private TextBox searchth;
        private Button refreshbtn;
        private Button backviewbtn;
        private Label label2;
    }
}