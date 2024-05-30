using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageProject
{
    static class UserCredits
    {
        static public int user_id;
        static public bool is_logged_in = false;

        static readonly string connection_string = "Data Source=.;Initial Catalog=Storage;Integrated Security=True;Trust Server Certificate=True";
        static public SqlConnection con = new SqlConnection(connection_string);


        static public SqlDataReader execute_queries(string query)
        {
            SqlCommand com = new SqlCommand(query, con);

            try
            {
                con.Open();
                return com.ExecuteReader();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
