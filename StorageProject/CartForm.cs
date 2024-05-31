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
    public partial class CartForm : Form
    {
        Dictionary<int, int> id_amount = new Dictionary<int, int>();
        int total_price = 0;

        void fill_form()
        {
            dataGridView1.AllowUserToAddRows = true;

            SqlDataReader reader;
            foreach (var i in id_amount)
            {
                string query = $"""select product_name, unit_price from product where product_id='{i.Key}'""";

                reader = UserCredits.execute_queries(query);
                reader.Read();

                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = reader["product_name"].ToString();
                row.Cells[1].Value = reader["unit_price"].ToString();
                row.Cells[2].Value = i.Value.ToString();
                row.Cells[3].Value = (int.Parse(row.Cells[1].Value.ToString()) * int.Parse(row.Cells[2].Value.ToString())).ToString();

                dataGridView1.Rows.Add(row);

                total_price += int.Parse(row.Cells[3].Value.ToString());

                UserCredits.con.Close();
            }

            dataGridView1.AllowUserToAddRows = false;

            label4.Text = total_price.ToString() + " IRS";
        }


        public CartForm(Dictionary<int, int> id_amount_from_the_last_form)
        {
            InitializeComponent();

            id_amount = id_amount_from_the_last_form;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            fill_form();
        }

        private void CartForm_Activated(object sender, EventArgs e)
        {
            if (UserCredits.is_logged_in)
            {
                label2.Text = UserCredits.user_name;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!UserCredits.is_logged_in)
            {
                LoginForm login_form = new LoginForm();
                login_form.ShowDialog();
            }
            else
            {
                string query = $"""
                    insert into orders (customer_id, total_price, date)
                    values ({UserCredits.user_id}, {total_price}, '{DateTime.Now}')

                    select SCOPE_IDENTITY() as last_id
                    """;

                SqlDataReader reader = UserCredits.execute_queries(query);
                reader.Read();

                int order_id = int.Parse(reader["last_id"].ToString());

                UserCredits.con.Close();

                foreach(var i in id_amount)
                {
                    query = $"""
                        insert into ordered_items (order_id, product_id, amount)
                        values ({order_id}, {i.Key}, {i.Value})

                        update product
                        set stock = stock - {i.Value}
                        where product_id = {i.Key}
                        """;

                    UserCredits.execute_queries(query);
                    UserCredits.con.Close();
                }

                MessageBox.Show("خرید با موفقیت انجام شد.");
                this.Close();
            }
        }
    }
}
