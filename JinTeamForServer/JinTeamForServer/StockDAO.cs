using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class StockDAO
    {
        DBConnection con = new DBConnection();
        List<Stock> stocks = new List<Stock>();

        public List<Stock> ShowStock(string pro_id)
        {
            string query = "select_stock";
            SqlParameter[] sqls =
            {
                new SqlParameter("pro_id",pro_id)
            };

            try
            {
                stocks = con.ReadStocks(query, sqls);
            }
            catch (Exception)
            {
                throw;
            }
            return stocks;
        }
    }
}