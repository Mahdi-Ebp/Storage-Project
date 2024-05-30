using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace StorageProject
{
    public partial class HomeForm : Form
    {

        Dictionary<int, int> id_amount = new Dictionary<int, int>();


        public SqlDataReader execute_queries(string query)
        {

            SqlCommand com = new SqlCommand(query, UserCredits.con);

            try
            {
                UserCredits.con.Open();
                com.ExecuteNonQuery();
                return com.ExecuteReader();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }


        public void fill_datagridview()
        {
            string query = """
                select * from product
                """;


            SqlDataReader reader = execute_queries(query);
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
    }
}
