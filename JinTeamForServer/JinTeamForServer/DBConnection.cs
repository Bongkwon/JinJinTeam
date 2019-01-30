using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;

namespace JinTeamForServer
{
    class DBConnection
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;


        public DBConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString);
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
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

        public List<Product_VO> SendReadQuery(string query, SqlParameter[] sqlp)
        {
            List<Product_VO> pro_lst = new List<Product_VO>();
            cmd.Connection = OpenConnection();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = query;
            if (sqlp != null)
            {
                cmd.Parameters.AddRange(sqlp);
            }
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Product_VO pv = new Product_VO();
                {
                    pv.Pro_ID = sdr["pro_Id"].ToString();
                    pv.Cat_ID = sdr["cat_id"].ToString();
                    pv.Seller_NO = Int32.Parse(sdr["seller_no"].ToString());
                    pv.Pro_Name = sdr["pro_name"].ToString();
                    pv.Pro_Price = Int32.Parse(sdr["pro_price"].ToString());
                    pv.Main_Comment = sdr["main_comment"].ToString();
                    pv.Sub_Comment = sdr["sub_comment"].ToString();
                    pv.Main_Image = sdr["main_image"].ToString();
                    pv.Pro_Hits = Int32.Parse(sdr["pro_hits"].ToString());
                    pv.Pro_Like = Int32.Parse(sdr["pro_like"].ToString());
                    pv.Pro_Discount = Int32.Parse(sdr["pro_discount"].ToString());
                    pv.Pro_Gender = sdr["pro_gender"].ToString();
                    pv.Pro_State = bool.Parse(sdr["pro_state"].ToString());
                    pro_lst.Add(pv);
                }                
            }
            conn.Close();
            return pro_lst;            
        }
    
        public bool ChkData(string query, SqlParameter[] sqlp)
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

        public DataTable ExcuteSelect(string sp, SqlParameter[] sqlParameters)
        {
            SqlCommand command = new SqlCommand();
            da.SelectCommand = command;
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = sp;
            
            if (sqlParameters != null)
            {
                da.SelectCommand.Parameters.AddRange(sqlParameters);
            }
            var set = new DataSet();
            try
            {
                da.Fill(set);
            }
            catch (SqlException)
            {
                throw;
            }

            return set.Tables[0];

        }
    }
}