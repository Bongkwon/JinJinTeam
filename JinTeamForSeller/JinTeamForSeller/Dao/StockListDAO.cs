using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;
namespace JinTeamForSeller.Dao
{
    class StockListDAO
    {
        DBConnection conn = new DBConnection();        
        public bool InsertStock(StockVO stock)
        {
            string query = "insert_stock";
            SqlParameter[] sqlp = { new SqlParameter("stock_ID", stock.Stock_ID), new SqlParameter("pro_ID", stock.Pro_Id),
                new SqlParameter("seller_no", stock.Seller_no), new SqlParameter("stock_size", stock.Stock_Size),
                new SqlParameter("stock_count", stock.Stock_Count) };

            return conn.SendExqueteQuery(query, sqlp);
        }
        public List<StockVO> Select_Stocks(string pro_ID)
        {
            List<StockVO> lstStock = new List<StockVO>();
            List<object> lstobj = new List<object>();
            string query = "SelectStock";
            SqlParameter[] sqlp = { new SqlParameter("Pro_ID", pro_ID) };
            lstobj = conn.SendReadQuery(query, sqlp);
            foreach (var item in lstobj)
            {
                lstStock.Add((StockVO)item);
            }            
            return lstStock;
        }
        public bool UpdateStock(StockVO stock)
        {
            string query = "UpdateStock";
            SqlParameter[] sqlp = { new SqlParameter("stock_ID", stock.Stock_ID), new SqlParameter("stock_count", stock.Stock_Count) };
            return conn.SendExqueteQuery(query, sqlp);
        }        
    }
}
