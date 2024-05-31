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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        public void fill_datagridview()
        {

            string query = """
                select * from product
                """;


            SqlDataReader reader = UserCredits.execute_queries(query);
            while (reader.Read())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = reader["product_name"].ToString();
                row.Cells[1].Value = reader["unit_price"].ToString();
                row.Cells[2].Value = reader["stock"].ToString();
                row.Cells[3].Value = reader["category"].ToString();
                row.Cells[4].Value = reader["description"].ToString();
                row.Cells[5].Value = reader["product_id"].ToString();
                row.Cells[6].Value = "0";
                dataGridView1.Rows.Add(row);
            }

            UserCredits.con.Close();
        }


        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            fill_datagridview();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown1.Maximum)
            {
                numericUpDown1.Value++;
                dataGridView1.CurrentRow.Cells[2].Value = numericUpDown1.Value.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value != null)
            {
                richTextBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

                numericUpDown1.Maximum = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                numericUpDown1.Value = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[2].Value = numericUpDown1.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                numericUpDown1.Value--;
                dataGridView1.CurrentRow.Cells[2].Value = numericUpDown1.Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string query = $"""
                update product
                set 
                    product_name = '{row.Cells[0].ToString()}',
                    unit_price = '{row.Cells[1].ToString()}',
                    stock = {row.Cells[2].ToString()},
                    category = '{row.Cells[3].ToString()}',
                    description = '{row.Cells[1].ToString()}'
                where product_id = {row.Cells[5].ToString()}
                """;

                UserCredits.execute_queries(query);
                UserCredits.con.Close();
            }

            MessageBox.Show("اطلاعات با موفقیت ذخیره شد.");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[4].Value = richTextBox1.Text;
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            fill_datagridview();
        }
    }
}
