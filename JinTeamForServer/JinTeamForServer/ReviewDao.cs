﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class ReviewDao
    {
        DBConnection con = new DBConnection();
        //public List<ReviewVO> SelectReviewForSeller(int seller_No)
        //{
        //    List<object> lstobj = new List<object>();
        //    List<ReviewVO> lstReview = new List<ReviewVO>();
        //    string query = "SelectReviewForCustomer";
        //    SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
        //    lstobj = con.SendReadQuery(query, sqlp);
        //    foreach (var item in lstobj)
        //    {
        //        lstReview.Add((ReviewVO)item);
        //    }
        //    return lstReview;
        //}

        //internal bool UpdateReview(int re_ID, string re_Comment)
        //{
        //    string query = "UpdateReview";
        //    SqlParameter[] sqlp = { new SqlParameter("re_ID", re_ID), new SqlParameter("re_Comment", re_Comment) };
        //    try
        //    {
        //        con.SendExqueteQuery(query, sqlp);
        //        return true;
        //    }
        //    catch (Exception)
        //    {                
        //        throw;
        //    }
            
        //}

        internal void InsertWishList(ReviewVO review)
        {
            string query = "insert_review";
            SqlParameter[] sqls =
            {
                new SqlParameter("cus_no",review.Cus_no),
                new SqlParameter("stock_ID",review.Stock_ID),
                new SqlParameter("re_text",review.Re_txt)
            };
            try
            {
                con.SendExqueteQuery(query, sqls);
            }
            catch (Exception)
            {
                throw;
            }
        }
        internal string SelReviewByCusno(int v)
        {
            string query = "SelectReviewByCusno";
            SqlParameter[] sqls =
            {
                new SqlParameter("cus_no",v)
            };

            return con.ReadReview(query, sqls);
        }

        internal string SelReviewByStock(string v)
        {
            string query = "SelectReviewByStockID";
            SqlParameter[] sqls =
            {
                new SqlParameter("stock_ID",v)
            };

            return con.ReadReview(query, sqls);
        }
    }
}