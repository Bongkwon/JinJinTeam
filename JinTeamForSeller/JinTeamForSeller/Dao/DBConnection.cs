using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller.Dao
{
    class DBConnection
    {
        SqlConnection conn;
        SqlCommand cmd;
        public DBConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["azureCon"].ConnectionString);
            
        }

        private SqlConnection OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed || conn.State == System.Data.ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public bool SendExqueteQuery(string query, SqlParameter[] sqlp)
        {
            bool result = false;
            SqlCommand cmd = new SqlCommand();
            //try
            //{
                cmd.Connection = OpenConnection();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlp);
                cmd.ExecuteNonQuery();
                conn.Close();
                result = true;
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            return result;
        }

        public List<object> SendReadQuery(string query, SqlParameter[] sqlp)
        {
            List<object> lstObj = new List<object>();
            SqlCommand cmd = new SqlCommand();
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
                if (query == "select_proEachSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new Product(dr["pro_Id"].ToString(), dr["cat_ID"].ToString(), (int)dr["seller_no"], dr["pro_name"].ToString(), (int)dr["pro_price"], dr["main_comment"].ToString(), dr["sub_comment"].ToString(), dr["main_image"].ToString(), (int)dr["pro_hits"], (int)dr["pro_like"], (int)dr["pro_discount"], dr["pro_gender"].ToString(), (bool)dr["pro_state"]));
                    }
                }
                else if(query == "SelectCategory")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new CatVO(dr["cat_ID"].ToString(), dr["cat_kind"].ToString()));
                    }
                }
                else if(query == "SelectStock")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new StockVO(dr["stock_ID"].ToString(), dr["pro_ID"].ToString(), int.Parse(dr["seller_no"].ToString()), dr["stock_size"].ToString(), int.Parse(dr["stock_count"].ToString())));
                    }
                }
                else if(query == "SelectPayInfo")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new Payment_InfoVO((int)dr["pay_ID"], dr["order_ID"].ToString(), dr["user_ship_ID"].ToString().ToString(), (int)dr["seller_no"], (int)dr["pay_count"], (int)dr["pay_price"], dr["waybill_ID"].ToString()));
                    }
                }
                conn.Close();
                return lstObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int SendScalarReadQuery(string query, SqlParameter[] sqlp)
        {
            SqlCommand cmd = new SqlCommand();
            int a = 0;            
            
            cmd.Connection = OpenConnection();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = query;
            if (sqlp != null)
            {
                cmd.Parameters.AddRange(sqlp);
            }
            try
            {
                a = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception)
            {

                throw;
            }
            
            conn.Close();
            
            return a;

        }
    }
}
