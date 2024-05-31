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
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();

                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }

            else
            {
                try
                {
                    string query = $"select password, customer_id, customer_name from customer where phone_number='{textBox1.Text}' or email='{textBox1.Text}'";

                    SqlDataReader reader = UserCredits.execute_queries(query);

                    if (!reader.HasRows)
                        MessageBox.Show("چنین کاربری وجود ندارد.");
                    else
                    {
                        reader.Read();

                        if (reader["password"].ToString() != textBox2.Text)
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");

                        else
                        {
                            UserCredits.user_id = int.Parse(reader["customer_id"].ToString());
                            UserCredits.user_name = reader["customer_name"].ToString();
                            UserCredits.is_logged_in = true;

                            this.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    UserCredits.con.Close();
                }
            }
        }
    }
}
