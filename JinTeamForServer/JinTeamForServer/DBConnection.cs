using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;

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

        internal string ReadReview(string query, SqlParameter[] sqls)
        {
            List<ReviewVO> reviews = new List<ReviewVO>();
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            cmd.Parameters.AddRange(sqls);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                int temp;
                if (sdr["re_like"].ToString().Equals("True"))
                {
                    temp = 1;
                }
                else
                {
                    temp = 0;
                }
                ReviewVO review = new ReviewVO()
                {
                    Re_image = sdr["re_image"].ToString(),
                    Re_txt = sdr["re_txt"].ToString(),
                    Re_date = sdr["re_date"].ToString(),
                    Re_like = temp,
                    Re_command = sdr["re_comment"].ToString(),
                    Re_comment_date = sdr["re_comment_date"].ToString(),
                    Cus_ID = sdr["cus_ID"].ToString(),
                    Pro_name = sdr["pro_name"].ToString()
                };

                reviews.Add(review);
            }

            return JsonConvert.SerializeObject(reviews);
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
                //else if (query == "SelectReviewForCustomer")
                //{
                //    while (dr.Read())
                //    {
                //        lstobj.Add(new ReviewVO((int)dr["re_ID"], (int)dr["cus_no"], dr["stock_ID"].ToString(), (bool)dr["re_like"], dr["re_image"].ToString(), dr["re_txt"].ToString(), (DateTime)dr["re_date"], dr["re_comment"].ToString(), dr["re_comment_date"].ToString(), dr["cus_name"].ToString(), dr["main_image"].ToString()));
                //    }
                    
                //}
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

        //internal bool UpdateQuery(string sp, SqlParameter[] sqls)
        //{
        //    bool result = false;

        //    cmd.Connection = OpenConnection();
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = sp;
        //    if (sqls != null)
        //    {
        //        cmd.Parameters.AddRange(sqls);
        //    }
        //    if (cmd.ExecuteNonQuery() == 1)
        //    {
        //        result = true;
        //    }
        //    conn.Close();

        //    return result;
        //}

        public bool UpdateQuery(string query, SqlParameter[] sqlp)
        {
            bool result = false;

            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;
            if (sqlp != null)
            {
                cmd.Parameters.AddRange(sqlp);
            }
            if (cmd.ExecuteNonQuery() == 1)
            {
                result = true;
            }
            conn.Close();

            return result;
        }
        internal List<Category> ReadCategory(string query, SqlParameter[] sqls)
        {
            List<Category> categories = new List<Category>();
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;

            if (sqls != null)
            {
                cmd.Parameters.AddRange(sqls);
            }
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Category category = new Category()
                {
                    Cat_ID = sdr["cat_ID"].ToString(),
                    Cat_kind = sdr["cat_kind"].ToString()
                };

                categories.Add(category);
            }

            conn.Close();
            return categories;
        }
        public List<Stock> ReadStocks(string query, SqlParameter[] sqlp)
        {
            List<Stock> stocks = new List<Stock>();
            cmd.Connection = OpenConnection();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = query;

            if (sqlp != null)
            {
                cmd.Parameters.AddRange(sqlp);
            }
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                Stock stock = new Stock()
                {
                    Stock_id = sdr["stock_id"].ToString(),
                    Pro_id = sdr["pro_id"].ToString(),
                    Seller_no = int.Parse(sdr["seller_no"].ToString()),
                    Stock_size = sdr["stock_size"].ToString(),
                    Stock_count = int.Parse(sdr["stock_count"].ToString())
                };

                stocks.Add(stock);
            }

            conn.Close();
            return stocks;
        }
    }
}