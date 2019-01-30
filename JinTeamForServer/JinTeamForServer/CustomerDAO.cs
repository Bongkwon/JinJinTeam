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
            SqlParameter[] sqlp = { new SqlParameter("cus_ID", cus.Cus_ID), new SqlParameter("cus_pwd", cus.Cus_pwd), new SqlParameter("Cus_phone", cus.Cus_phone), new SqlParameter("Cus_addr", cus.Cus_addr), new SqlParameter("Cus_name", cus.Cus_name), new SqlParameter("Cus_Nickname", cus.Cus_Nickname), new SqlParameter("Cus_gender", cus.Cus_gender), new SqlParameter("Cus_age", cus.Cus_age) };
            try
            {
                con.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
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