using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace StorageProject
{
    public partial class HomeForm : Form
    {

        Dictionary<int, int> id_amount = new Dictionary<int, int>();


        public void fill_datagridview()
        {
            dataGridView1.AllowUserToAddRows = true;

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
            dataGridView1.AllowUserToAddRows = false;
            UserCredits.con.Close();
        }


        public HomeForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown1.Maximum)
            {
                numericUpDown1.Value++;
                dataGridView1.CurrentRow.Cells[6].Value = numericUpDown1.Value.ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            fill_datagridview();
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

            int amount = int.Parse(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            numericUpDown1.Maximum = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            numericUpDown1.Value = amount;
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }


        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[6].Value = numericUpDown1.Value.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                numericUpDown1.Value--;
                dataGridView1.CurrentRow.Cells[6].Value = numericUpDown1.Value.ToString();
            }
        }


        private void HomeForm_Activated(object sender, EventArgs e)
        {
            if (UserCredits.is_logged_in)
            {
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;

                label2.Visible = true;
                linkLabel3.Visible = true;
                label2.Text = UserCredits.user_name;

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                fill_datagridview();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = true;
            linkLabel2.Visible = true;

            label2.Visible = false;
            linkLabel3.Visible = false;

            UserCredits.is_logged_in = false;
            UserCredits.user_name = "";
            UserCredits.user_id = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            id_amount.Clear();
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[6].Value.ToString() != "0")
                    id_amount.Add(int.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()), int.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString()));
            }

            if (id_amount.Count > 0)
            {
                CartForm cart_form = new CartForm(id_amount);
                cart_form.ShowDialog();
            }
            else
                MessageBox.Show("سبد خرید خالی است. لطفا ابتدا محصولات دلخواه را به سبد خرید اضافه کنید.");
        }
    }
}
