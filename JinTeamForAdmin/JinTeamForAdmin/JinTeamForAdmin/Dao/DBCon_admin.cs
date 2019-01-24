using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForAdmin
{
    class DBCon_admin
    {
        SqlConnection con;
        public DBCon_admin()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["JinTeamDB"].ConnectionString);
        }

        private SqlConnection OpenCon()
        {
            if (con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    throw; 
                }
            }
            return con;
        }


        internal SqlDataReader Select_GV(string sp)
        {
            SqlConnection sqlCon = OpenCon();
            var cmd = GetCommand(sqlCon, sp, null, null);

            try
            {
                return cmd.ExecuteReader();
            }
            catch (SqlException)
            {
                throw;
            }
        }

        internal bool Delete_GV(string sp)
        {
            SqlConnection sqlCon = OpenCon();
            var cmd = GetCommand(sqlCon, sp, null, null);

            try
            {
                cmd.ExecuteReader();
                return true;
            }
            catch (SqlException)
            {
                throw;
            }
        }

        private SqlCommand GetCommand(SqlConnection sqlCon, string sp, SqlTransaction transaction, SqlParameter[] sqlParameters)
        {
            var cmd = new SqlCommand();

            cmd.Connection = sqlCon;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = sp;
            cmd.Transaction = transaction;

            if (sqlParameters != null)
            {
                cmd.Parameters.AddRange(sqlParameters);
            }
            return cmd;
        }

    }
}
