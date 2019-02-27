using JinTeamForAdmin.Vo;
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
        List<object> ob_lst;
        public DBCon_admin()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["JinTeamDB"].ConnectionString);
            ob_lst = new List<object>();
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

  

        internal List<object> Select_ob(string sp, string type_p)
        {
            SqlConnection sqlCon = OpenCon();
            var cmd = GetCommand(sqlCon, sp, null, null);

            try
            {
                var sdr = cmd.ExecuteReader();

                if (type_p == "pro")
                {
                    while (sdr.Read())
                    {
                        Products_Vo pv = new Products_Vo();
                        {
                            pv.Pro_ID = sdr["pro_Id"].ToString();
                            pv.Cat_ID = sdr["cat_id"].ToString();
                            pv.Seller_NO = Int32.Parse(sdr["seller_no"].ToString());
                            pv.Pro_Name = sdr["pro_name"].ToString();
                            //pv.Pro_Price = Int32.Parse(sdr["pro_price"].ToString());
                            int Pro_Price = Int32.Parse(sdr["pro_price"].ToString());
                            pv.Pro_Price = Pro_Price.ToString("#,##0");
                            pv.Main_Comment = sdr["main_comment"].ToString();
                            pv.Sub_Comment = sdr["sub_comment"].ToString();
                            pv.Main_Image = sdr["main_image"].ToString();
                            pv.Pro_Hits = Int32.Parse(sdr["pro_hits"].ToString());
                            pv.Pro_Like = Int32.Parse(sdr["pro_like"].ToString());
                            pv.Pro_Discount = Int32.Parse(sdr["pro_discount"].ToString());
                            pv.Pro_Gender = sdr["pro_gender"].ToString();
                            pv.Pro_State = bool.Parse(sdr["pro_state"].ToString());
                            pv.Pro_Url = sdr["pro_Url"].ToString();
                        }

                        ob_lst.Add(pv);
                        //pro_lst.Add(pv);
                    }
                }
                else if (type_p == "cus")
                {
                    while (sdr.Read())
                    {
                        ob_lst.Add(new Customers_Vo()
                        {
                            Cus_no = Int32.Parse(sdr["cus_no"].ToString()),
                            Cus_ID = sdr["cus_id"].ToString(),
                            Cus_pwd = sdr["cus_pwd"].ToString(),
                            Cus_phone = sdr["cus_phone"].ToString(),
                            Cus_addr = sdr["cus_addr"].ToString(),
                            Cus_name = sdr["cus_name"].ToString(),
                            Cus_Nickname = sdr["cus_nickname"].ToString(),
                            Cus_gender = bool.Parse(sdr["cus_gender"].ToString()),
                            Cus_state = bool.Parse(sdr["cus_state"].ToString()),
                            Cus_count = Int32.Parse(sdr["cus_count"].ToString()),
                            Cus_age = Int32.Parse(sdr["cus_age"].ToString()),
                            Join_date = DateTime.Parse(sdr["join_date"].ToString()),
                            Withdrawal_date = sdr["Withdrawal_date"].ToString()
                            //(sdr["Withdrawal_date"].ToString() =="") ? "" :  DateTime.Parse(sdr["Withdrawal_date"].ToString())
                        });
                    }
                }
                else if (type_p == "sel")  // type-p = "sel"
                {
                    while (sdr.Read())
                    {
                        Seller_Vo sv = new Seller_Vo();
                        {
                            sv.Seller_NO = Int32.Parse(sdr["seller_no"].ToString());
                            sv.Seller_ID = sdr["seller_id"].ToString();
                            sv.Seller_pwd = sdr["seller_pwd"].ToString();
                            sv.Seller_name = sdr["seller_name"].ToString();
                            sv.Seller_addr = sdr["seller_addr"].ToString();
                            sv.Seller_boss = sdr["seller_boss"].ToString();
                            sv.Seller_phone = sdr["seller_phone"].ToString();
                            sv.Seller_postal = sdr["seller_postal"].ToString();
                            sv.Seller_email = sdr["seller_email"].ToString();
                            sv.Seller_fax = sdr["seller_fax"].ToString();
                            sv.Return_addr = sdr["return_addr"].ToString();
                            sv.Seller_state = bool.Parse(sdr["seller_state"].ToString());
                            sv.Corporate_registration_no = sdr["Corporate_registration_no"].ToString();
                            sv.Join_state = bool.Parse(sdr["join_state"].ToString());
                        }

                        ob_lst.Add(sv);
                    }
                }
                else if (type_p == "pay")
                {
                    while (sdr.Read())
                    {
                        ob_lst.Add(new TaxBill_Vo() {
                            Pay_ID = Int32.Parse(sdr["pay_id"].ToString()),
                            Corporate_registration_no = sdr["Corporate_registration_no"].ToString(),
                            Output_date_tax = sdr["Output_date_tax"].ToString(),
                            Pay_count = Int32.Parse(sdr["Pay_count"].ToString()),
                            Pay_date = sdr["Pay_date"].ToString(),
                            Pay_price = Int32.Parse(sdr["Pay_price"].ToString()).ToString("#,##0"),
                            Seller_boss = sdr["Seller_boss"].ToString(),
                            Seller_ID = sdr["Seller_ID"].ToString(),
                            Stock_ID = sdr["Stock_ID"].ToString(),
                            Seller_addr = sdr["seller_addr"].ToString()
                        });

                    }
                }
                else if (type_p == "inq")
                {
                    if (sp == "select_sel_inq")
                    {
                        while (sdr.Read())
                        {
                            ob_lst.Add(new Inquire_Admin_Vo()
                            {
                                Inquire_email = sdr["seller_email"].ToString(),
                                Inquire_name = sdr["seller_ID"].ToString(),
                                Cus_or_sell = sdr["cus_or_sell"].ToString(),
                                Inquire_body = sdr["inquire_body"].ToString(),
                                Inquire_date = sdr["inquire_date"].ToString(),
                                Inquire_id = Int32.Parse(sdr["inquire_id"].ToString()),
                                Inquire_image = sdr["inquire_image"].ToString(),
                                Inquire_no = Int32.Parse(sdr["inquire_no"].ToString()),
                                Inquire_title = sdr["inquire_title"].ToString(),
                                Inquire_type = sdr["inquire_type"].ToString(),
                                Re_body = sdr["re_body"].ToString(),
                                Re_date = sdr["re_date"].ToString()
                            });
                        }
                    }
                    else if(sp == "select_cus_inq")
                    {
                        while (sdr.Read())
                        {
                            ob_lst.Add(new Inquire_Admin_Vo()
                            {
                                Inquire_email = sdr["cus_id"].ToString(),
                                Inquire_name = sdr["cus_nickname"].ToString(),
                                Cus_or_sell = sdr["cus_or_sell"].ToString(),
                                Inquire_body = sdr["inquire_body"].ToString(),
                                Inquire_date = sdr["inquire_date"].ToString(),
                                Inquire_id = Int32.Parse(sdr["inquire_id"].ToString()),
                                Inquire_image = sdr["inquire_image"].ToString(),
                                Inquire_no = Int32.Parse(sdr["inquire_no"].ToString()),
                                Inquire_title = sdr["inquire_title"].ToString(),
                                Inquire_type = sdr["inquire_type"].ToString(),
                                Re_body = sdr["re_body"].ToString(),
                                Re_date = sdr["re_date"].ToString()
                            });
                        }
                    }                  
                }
                else if (type_p == "sal")
                {
                    while (sdr.Read())
                    {
                        ob_lst.Add(new Sales_manager_Vo()
                        {
                            Seller_ID = sdr["seller_id"].ToString(),
                            Pay_date = sdr["pay_date"].ToString(),
                            Pay_date_m = sdr["pay_date"].ToString().Substring(sdr["pay_date"].ToString().IndexOf("-") + 1, 2),
                            Pay_count = Int32.Parse(sdr["pay_count"].ToString()),
                            Pay_price = Int32.Parse(sdr["Pay_price"].ToString())
                        });
                    }
                }
                else if (type_p == "dashboard")
                {
                    while (sdr.Read())
                    {
                        ob_lst.Add(sdr["count"]);
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally { sqlCon.Close(); }

            return ob_lst;
        }

        internal bool ExecuteNonQuery_GV(string sp)
        {
            bool result = false;
            SqlConnection sqlCon = OpenCon();
            var cmd = GetCommand(sqlCon, sp, null, null);

            try
            {
                cmd.ExecuteNonQuery();
                result = true;
            }
            catch (SqlException)
            {
                throw;
            }

            finally { sqlCon.Close(); }
            return result;
        }

        internal bool Update_ob(string sp, SqlParameter[] sqlParameters)
        {
            bool result = false;
            SqlConnection sqlCon = OpenCon();

            SqlTransaction transaction = GetTransaction(sqlCon);

            using (transaction)
            {
                SqlCommand cmd = GetCommand(sqlCon, sp, transaction, sqlParameters);

                try
                {
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
                finally { sqlCon.Close(); }
                return result;
            }
            
        }

        private SqlTransaction GetTransaction(SqlConnection sqlCon)
        {
            return sqlCon.BeginTransaction();
        }
    }
}
