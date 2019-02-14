using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class WishListDAO
    {
        DBConnection con = new DBConnection();

        public void InsertWishList(WishList_VO wl)
        {
            string query = "InsertWishList";
            SqlParameter[] sqls =
            {
                new SqlParameter("wish_ID",wl.Wish_ID),
                new SqlParameter("cus_ID",wl.Cus_ID),
                new SqlParameter("stock_ID",wl.StockID),
                new SqlParameter("wish_count",wl.Wish_count),
                new SqlParameter("wish_price",wl.Wish_price)
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
    }
}