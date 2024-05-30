
namespace StorageProject
{
    partial class SignUpForm
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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(546, 82);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(61, 41);
            label1.TabIndex = 0;
            label1.Text = "نام:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 191);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(164, 41);
            label2.TabIndex = 1;
            label2.Text = "شماره تلفن:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(546, 301);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.Yes;
            label3.Size = new Size(212, 41);
            label3.TabIndex = 2;
            label3.Text = "پست الکترونیک:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 410);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(103, 41);
            label4.TabIndex = 3;
            label4.Text = "نشانی:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 509);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(130, 41);
            label5.TabIndex = 4;
            label5.Text = "رمز عبور:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 618);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(194, 41);
            label6.TabIndex = 5;
            label6.Text = "تکرار رمز عبور:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 79);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(413, 47);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 188);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(413, 47);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(75, 298);
            textBox3.MaxLength = 64;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(413, 47);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(75, 407);
            textBox4.MaxLength = 250;
            textBox4.Name = "textBox4";
            textBox4.RightToLeft = RightToLeft.Yes;
            textBox4.Size = new Size(413, 47);
            textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(75, 506);
            textBox5.MaxLength = 32;
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(413, 47);
            textBox5.TabIndex = 6;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(75, 615);
            textBox6.MaxLength = 32;
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(413, 47);
            textBox6.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(75, 704);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(413, 123);
            button1.TabIndex = 7;
            button1.Text = "ثبت نام";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 10F);
            linkLabel1.Location = new Point(567, 742);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.RightToLeft = RightToLeft.Yes;
            linkLabel1.Size = new Size(82, 46);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "ورود";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 865);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}