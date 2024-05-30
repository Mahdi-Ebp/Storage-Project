using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"select password, customer_id from customer" +
                $"where phone_number='{textBox1.Text}' or email='{textBox1.Text}'";

            SqlDataReader reader = UserCredits.execute_queries(query);

            if (reader.HasRows == false)
                MessageBox.Show("چنین کاربری وجود ندارد.");
            else if (reader["password"].ToString() != textBox2.Text)
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
            else
            {
                UserCredits.user_id = int.Parse(reader["customer_id"].ToString());
                UserCredits.is_logged_in = true;
            }

            this.Close();
        }
    }
}
