namespace StorageProject
{
    partial class HomeForm
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            button3 = new Button();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(629, 32);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1104, 1012);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "نام محصول";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "قیمت";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "موجودی";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "دسته بندی";
            Column4.MinimumWidth = 12;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "توضیحات";
            Column5.MinimumWidth = 12;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Visible = false;
            Column5.Width = 250;
            // 
            // Column6
            // 
            Column6.HeaderText = "id";
            Column6.MinimumWidth = 12;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            Column6.Width = 250;
            // 
            // Column7
            // 
            Column7.HeaderText = "amount";
            Column7.MinimumWidth = 12;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Visible = false;
            Column7.Width = 250;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLight;
            richTextBox1.Location = new Point(40, 302);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(530, 498);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 230);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(144, 41);
            label1.TabIndex = 2;
            label1.Text = "توضیحات:";
            // 
            // button1
            // 
            button1.Location = new Point(415, 835);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(155, 58);
            button1.TabIndex = 3;
            button1.Text = "افزودن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 835);
            button2.Name = "button2";
            button2.Size = new Size(155, 58);
            button2.TabIndex = 4;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 12F);
            linkLabel1.Location = new Point(473, 32);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.Yes;
            linkLabel1.Size = new Size(97, 54);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ورود";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 12F);
            linkLabel2.Location = new Point(324, 32);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.RightToLeft = RightToLeft.Yes;
            linkLabel2.Size = new Size(143, 54);
            linkLabel2.TabIndex = 6;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "ثبت نام";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // button3
            // 
            button3.Location = new Point(40, 927);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(530, 117);
            button3.TabIndex = 8;
            button3.Text = "تکمیل سفارش";
            button3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(40, 842);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 47);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1789, 1080);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HomeForm";
            Text = "صفحه اصلی";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private DataGridViewTextBoxColumn Column5;
        private Button button3;
        private NumericUpDown numericUpDown1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
