namespace StorageProject
{
    partial class AdminForm
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
            label2 = new Label();
            linkLabel3 = new LinkLabel();
            numericUpDown1 = new NumericUpDown();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(134, 36);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(425, 54);
            label2.TabIndex = 22;
            label2.Text = "پنل مدیریت";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Visible = false;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Segoe UI", 12F);
            linkLabel3.Location = new Point(29, 36);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(106, 54);
            linkLabel3.TabIndex = 21;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "خروج";
            linkLabel3.Visible = false;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(29, 846);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(171, 47);
            numericUpDown1.TabIndex = 20;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // button3
            // 
            button3.Location = new Point(29, 931);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(530, 117);
            button3.TabIndex = 19;
            button3.Text = "ذخیره";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(243, 839);
            button2.Name = "button2";
            button2.Size = new Size(155, 58);
            button2.TabIndex = 16;
            button2.Text = "حذف";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(404, 839);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(155, 58);
            button1.TabIndex = 15;
            button1.Text = "افزودن";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 234);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(144, 41);
            label1.TabIndex = 14;
            label1.Text = "توضیحات:";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ControlLight;
            richTextBox1.Location = new Point(29, 306);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.RightToLeft = RightToLeft.Yes;
            richTextBox1.Size = new Size(530, 498);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Column6
            // 
            Column6.HeaderText = "id";
            Column6.MinimumWidth = 12;
            Column6.Name = "Column6";
            Column6.Visible = false;
            Column6.Width = 250;
            // 
            // Column5
            // 
            Column5.HeaderText = "توضیحات";
            Column5.MinimumWidth = 12;
            Column5.Name = "Column5";
            Column5.Visible = false;
            Column5.Width = 250;
            // 
            // Column4
            // 
            Column4.HeaderText = "دسته بندی";
            Column4.MinimumWidth = 12;
            Column4.Name = "Column4";
            Column4.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "موجودی";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "قیمت";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column1
            // 
            Column1.HeaderText = "نام محصول";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column7
            // 
            Column7.HeaderText = "amount";
            Column7.MinimumWidth = 12;
            Column7.Name = "Column7";
            Column7.Visible = false;
            Column7.Width = 250;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(618, 36);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1104, 1012);
            dataGridView1.TabIndex = 12;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1764, 1097);
            Controls.Add(label2);
            Controls.Add(linkLabel3);
            Controls.Add(numericUpDown1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Name = "AdminForm";
            Text = "AdminForm";
            Activated += AdminForm_Activated;
            FormClosed += AdminForm_FormClosed;
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private LinkLabel linkLabel3;
        private NumericUpDown numericUpDown1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private RichTextBox richTextBox1;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridView dataGridView1;
    }
}