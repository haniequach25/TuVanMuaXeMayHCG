using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuVanMuaXeMayHCG.DAL
{
    class DataProvider
    {
        public SqlConnection GetDBConnection()
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=TuVanXeMay;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

            return conn;
        }

        private void setParameters(SqlCommand cmd, params dynamic[] parameters)
        {
            try
            {
                for (int i = 0; i < parameters.Length; i++)
                {
                    dynamic para = parameters[i];
                    string index = "@" + i;
                    cmd.Parameters.AddWithValue(index, para);
                }
            }
            catch (SqlException)
            {

            }
        }

        public DataTable Query(string sql, params dynamic[] parameters)
        {
            SqlConnection conn = GetDBConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                setParameters(cmd, parameters);
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
            catch (SqlException)
            {
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public bool ExecuteNonQuery(string sql, params dynamic[] parameters)
        {
            SqlConnection conn = GetDBConnection();
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                setParameters(cmd, parameters);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public DataTable GetTable(string sql)
        {
            try
            {
                SqlConnection conn = GetDBConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ExecuteQuery(String query, object[] parameters = null)
        {
            DataTable table = new DataTable();
            using (GetDBConnection())
            {
                GetDBConnection().Open();
                SqlCommand command = new SqlCommand(query, GetDBConnection());
                if (query != null)
                {
                    Int32 i = 0;
                    String[] queries = query.Split(' ');
                    foreach (String str in queries)
                    {
                        if (str.Contains('@'))
                        {
                            command.Parameters.AddWithValue(str, parameters[i]);
                            i++;
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                }
            }
            return table;
        }
        public bool ExecuteNonQueryWithImage(String sql, byte[] image)
        {
            try
            {
                SqlConnection connect = GetDBConnection();
                connect.Open();
                SqlCommand cmd = new SqlCommand(sql, connect);
                cmd.Parameters.Add(new SqlParameter("@image", image));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                return false;
            }
        }
    }
}
