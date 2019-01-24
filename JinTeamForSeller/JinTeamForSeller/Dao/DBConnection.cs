using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Dao
{
    class DBConnection
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DBConnection()
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Jin\JinTeamForSeller\JinTeamForSeller\JinTeamDB.mdf;Integrated Security=True");
            cmd = new SqlCommand();
        }

        private SqlConnection OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public void SendExqueteQuery(string query, SqlParameter[] sqlp)
        {            
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlp);
                cmd.ExecuteNonQuery();
                conn.Close();                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlDataReader SendReadQuery(string query, SqlParameter[] sqlp)
        {
            try
            {                
                cmd.Connection = OpenConnection();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = query;
                if (sqlp != null)
                {
                    cmd.Parameters.AddRange(sqlp);
                }
                SqlDataReader dr = cmd.ExecuteReader();
                conn.Close();
                return dr;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool SendScalarReadQuery(string query, SqlParameter[] sqlp)
        {
            int a = 0;
            bool result = false;
            
            cmd.Connection = OpenConnection();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = query;
            if (sqlp != null)
            {
                cmd.Parameters.AddRange(sqlp);
            }
            if (cmd.ExecuteScalar() != null)
            {
                a = (int)cmd.ExecuteScalar();
            }
            conn.Close();
            if (a == 1)
            {
                result = true;
            }
            return result;

        }
    }
}
