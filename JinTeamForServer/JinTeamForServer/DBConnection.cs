﻿using System;
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
                cmd.Parameters.Clear();
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

        public List<object> SendReadQuery(string query, SqlParameter[] sqlp)
        {
            List<object> lstobj = new List<object>();
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
                if (query == "select_pro")
                {
                    while (dr.Read())
                    {
                        Product_VO pv = new Product_VO(
                            dr["pro_Id"].ToString(), dr["cat_id"].ToString(), Int32.Parse(dr["seller_no"].ToString()), dr["pro_name"].ToString(),
                            Int32.Parse(dr["pro_price"].ToString()), dr["main_comment"].ToString(), dr["sub_comment"].ToString(),
                            dr["main_image"].ToString(), Int32.Parse(dr["pro_hits"].ToString()), Int32.Parse(dr["pro_like"].ToString()),
                            Int32.Parse(dr["pro_discount"].ToString()), dr["pro_gender"].ToString(), bool.Parse(dr["pro_state"].ToString())
                    );
                        lstobj.Add(pv);
                    }
                }
                else if (query == "SelectReviewForCustomer")
                {
                    while (dr.Read())
                    {
                        lstobj.Add(new ReviewVO((int)dr["re_ID"], (int)dr["cus_no"], dr["stock_ID"].ToString(), (bool)dr["re_like"], dr["re_image"].ToString(), dr["re_txt"].ToString(), (DateTime)dr["re_date"], dr["re_comment"].ToString(), dr["re_comment_date"].ToString(), dr["cus_name"].ToString(), dr["main_image"].ToString()));
                    }
                    
                }
            }
            catch (Exception)
            {
                throw;
            }

            conn.Close();
            return lstobj;
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