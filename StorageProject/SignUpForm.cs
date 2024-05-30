using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageProject
{
    public partial class SignUpForm : Form
    {

        string error_message = "";

        const string connection_string = "Data Source=.;Initial Catalog=Storage;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection con = new SqlConnection(connection_string);


        public SqlDataReader execute_queries(string query)
        {
            SqlCommand com = new SqlCommand(query, con);

            try
            {
                con.Open();
                com.ExecuteNonQuery();
                return com.ExecuteReader();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }

        bool IsNameValid(string name)
        {
            Regex reg = new Regex("^[ا-ی]+$");
            if (reg.Match(name).Success)
                return true;
            else
            {
                error_message += "نام حاوی حروف غیرمجاز می باشد.\n";
                return false;
            }
        }


        bool IsEmailValid(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                error_message += "فرمت ایمیل صحیح نمی باشد.\n";
                return false;
            }

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                error_message += "فرمت ایمیل صحیح نمی باشد.\n";
                return false;
            }
        }


        bool IsNumberValid(string number)
        {
            Regex reg = new Regex("^[0-9]+$");
            if (reg.Match(number).Success)
                return true;
            else
            {
                error_message += "شماره فقط میتواند حاوی عدد باشد.\n";
                return false;
            }
        }

        bool IsPasswordvalid(string password1, string password2)
        {
            if (password1.Length < 8)
            {
                error_message += "رمز عبور باید حداقل شامل 8 حرف باشد.\n";
                return false;
            }
            if (password1 != password2)
            {
                error_message += "رمز عبور را به درستی تکرار کنید.\n";
                return false;
            }

            return true;
        }


        public SignUpForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        void InsertNewCustomer(string name, string address, string number, string email, string password)
        {
            string query = $"""
                insert into customer (customer_name, address, phone_number, email, password)
                values ('{name}', '{address}', '{number}', '{email}', '{password}')
                """;

            execute_queries(query);
            con.Close();
        }

        bool UserExists(string phone_number, string email) {

            string query = $"""select * from customer where phone_number='{phone_number}' or email='{email}'""";
            
            SqlDataReader reader = execute_queries(query);
            bool b = reader == null ? false : true;
            con.Close();
            return b;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            error_message = "";
            if (IsNameValid(textBox1.Text) && IsNumberValid(textBox2.Text) && IsEmailValid(textBox3.Text)
                && IsPasswordvalid(textBox5.Text, textBox6.Text))
            {
                
                InsertNewCustomer(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text, textBox5.Text);
            }
            else
                MessageBox.Show(error_message, "خطا", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }
    }
}

