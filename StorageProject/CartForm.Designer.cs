namespace StorageProject
{
    partial class CartForm
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(38, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 102;
            dataGridView1.Size = new Size(853, 823);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "نام محصول";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "قیمت واحد";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.HeaderText = "تعداد";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.Width = 250;
            // 
            // button1
            // 
            button1.Location = new Point(703, 1059);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 1;
            button1.Text = "انصراف";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(786, 47);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(105, 41);
            label1.TabIndex = 2;
            label1.Text = "خریدار:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(621, 47);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(159, 41);
            label2.TabIndex = 3;
            label2.Text = "تعیین نشده";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(752, 979);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(139, 41);
            label3.TabIndex = 4;
            label3.Text = "قیمت کل:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 979);
            label4.Name = "label4";
            label4.Size = new Size(84, 41);
            label4.TabIndex = 5;
            label4.Text = "0 IRS";
            // 
            // button2
            // 
            button2.Location = new Point(38, 1059);
            button2.Name = "button2";
            button2.Size = new Size(227, 58);
            button2.TabIndex = 6;
            button2.Text = "ثبت سفارش";
            button2.UseVisualStyleBackColor = true;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 1147);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CartForm";
            Text = "سبد خرید";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
    }
}