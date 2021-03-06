﻿using System;
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
            try
            {
                cmd.Connection = OpenConnection();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = query;
                cmd.Parameters.AddRange(sqlp);
                cmd.ExecuteNonQuery();
                conn.Close();
                result = true;
            }
            catch (Exception)
            {
                throw;
            }
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
                        lstObj.Add(new Product(dr["pro_Id"].ToString(), dr["cat_ID"].ToString(), (int)dr["seller_no"], dr["pro_name"].ToString(), (int)dr["pro_price"], dr["main_comment"].ToString(), dr["sub_comment"].ToString(), dr["main_image"].ToString(), (int)dr["pro_hits"], (int)dr["pro_like"], (int)dr["pro_discount"], dr["pro_gender"].ToString(), (bool)dr["pro_state"], dr["pro_url"].ToString()));
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
                else if(query == "SelectPayInfoForSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new Payment_InfoVO((int)dr["pay_ID"], dr["order_ID"].ToString(), dr["user_ship_ID"].ToString().ToString(), (int)dr["seller_no"], (int)dr["pay_count"], (int)dr["pay_price"], dr["waybill_ID"].ToString(), dr["cus_name"].ToString(), dr["user_addr"].ToString(), dr["stock_ID"].ToString(), dr["order_require"].ToString(), dr["ship_require"].ToString(), dr["transport_state"].ToString(), dr["user_name"].ToString()));
                    }
                }
                else if(query == "SearchSellerID")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new SellerVO(dr["seller_ID"].ToString()));
                    }
                }
                else if(query == "SelectReviewForSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new ReviewVO((int)dr["re_ID"], (int)dr["cus_no"], dr["stock_ID"].ToString(), (bool)dr["re_like"], dr["re_image"].ToString(), dr["re_txt"].ToString(), (DateTime)dr["re_date"], dr["re_comment"].ToString(), dr["re_comment_date"].ToString(), dr["cus_name"].ToString(), dr["main_image"].ToString()));
                    }
                }
                else if(query == "SelectInquireForSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new InquireVO((int)dr["Inquire_no"],dr["Inquire_type"].ToString(), (int)dr["cus_no"], dr["cus_name"].ToString(), dr["stock_ID"].ToString(), dr["Inquire_title"].ToString(), dr["Inquire_body"].ToString(),dr["Inquire_date"].ToString(),dr["Inquire_image"].ToString(), dr["re_date"].ToString(), dr["re_body"].ToString(), dr["main_image"].ToString()));
                    }
                }
                else if(query == "SelectInquireAdminForSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new InquireVO((int)dr["Inquire_no"], dr["Inquire_type"].ToString(), (int)dr["inquire_id"], dr["Inquire_title"].ToString(), dr["Inquire_body"].ToString(), dr["Inquire_date"].ToString(), dr["Inquire_image"].ToString(), dr["re_date"].ToString(), dr["re_body"].ToString()));
                    }
                }
                else if(query == "selectSalesManagementForSeller")
                {
                    while (dr.Read())
                    {
                        lstObj.Add(new SalesManagementVO(dr["pro_name"].ToString(), dr["stock_ID"].ToString(), (int)dr["pay_count"], (int)dr["pay_price"], DateTime.Parse(dr["pay_date"].ToString())));
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
