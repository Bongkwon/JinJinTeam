﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Dao
{
    class SellerDAO
    {
        DBConnection con= new DBConnection();

        public bool ChkOverLap(string sellerID)
        {            
            bool result = false;
            string query = "ChkOverLap";
            SqlParameter[] sqlp = { new SqlParameter("sellerId", sellerID) };
            try
            {
                result = con.SendScalarReadQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public void InsertSeller(Vo.SellerVO seller)
        {
            List<Vo.SellerVO> lstSeller = new List<Vo.SellerVO>();
            string query = "insert_seller";
            SqlParameter[] sqlp = { new SqlParameter("seller_ID", seller.Seller_ID), new SqlParameter("seller_pwd", seller.Seller_pwd), new SqlParameter("seller_name", seller.Seller_name), new SqlParameter("seller_addr", seller.Seller_addr), new SqlParameter("seller_boss", seller.Seller_boss), new SqlParameter("seller_phone", seller.Seller_phone), new SqlParameter("seller_postal", seller.Seller_postal), new SqlParameter("seller_email", seller.Seller_email), new SqlParameter("seller_fax", seller.Seller_fax), new SqlParameter("return_addr", seller.Return_addr), new SqlParameter("corporate_registration_no", seller.Corporate_registration_no) };            
            try
            {
                con.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}