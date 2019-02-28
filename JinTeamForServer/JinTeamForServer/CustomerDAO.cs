using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class CustomerDAO
    {
        DBConnection con = new DBConnection();

        public bool ChkOverLap(string sellerID)
        {
            bool result = false;
            string query = "ChkOverLap";
            SqlParameter[] sqlp = { new SqlParameter("sellerId", sellerID) };
            try
            {
                result = con.ChkData(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void InsertCustomer(Customer cus)
        {
            string query = "insert_cus";
            int cus_gender = 0;
            if (cus.Cus_gender)
            {
                cus_gender = 1;
            }
            else
            {
                cus_gender = 0;
            }
            SqlParameter[] sqlp = { new SqlParameter("cus_ID", cus.Cus_ID), new SqlParameter("cus_pwd", cus.Cus_pwd), new SqlParameter("cus_phone", cus.Cus_phone), new SqlParameter("cus_addr", cus.Cus_addr), new SqlParameter("cus_name", cus.Cus_name), new SqlParameter("cus_Nickname", cus.Cus_Nickname), new SqlParameter("cus_gender", cus_gender), new SqlParameter("cus_age", cus.Cus_age) };
            try
            {
                con.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Customer ReadTable(int cus_no)
        {
            string query = "select_cus_no";
            SqlParameter[] sqls = { new SqlParameter("cus_no", cus_no) };
            Customer[] cus;
            try
            {
                var dt = con.ExcuteSelect(query, sqls);
                var json = JsonConvert.SerializeObject(dt);
                cus = JsonConvert.DeserializeObject<Customer[]>(json);
            }
            catch (Exception)
            {
                throw;
            }

            return cus[0];
        }

        public bool chkID(string cus_ID)
        {
            bool result = false;
            string query = "chkID";
            SqlParameter[] sqlp = { new SqlParameter("cus_ID", cus_ID) };
            try
            {
                result = con.ChkData(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }


        public bool ChkPhone(string cus_phone)
        {
            bool result = false;
            string query = "chkPhone";
            SqlParameter[] sqlp = { new SqlParameter("cus_phone", cus_phone) };
            try
            {
                result = con.ChkData(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}