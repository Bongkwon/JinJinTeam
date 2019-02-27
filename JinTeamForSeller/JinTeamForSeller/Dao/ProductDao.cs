using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JinTeamForSeller.Dao
{
    class ProductDAO
    {
        DBConnection con = new DBConnection();

        public List<Product> select_proEachSeller(int seller_No)
        {
            List<object> lstobj = new List<object>();
            List<Product> lstPro = new List<Product>();

            string query = "select_proEachSeller";
            SqlParameter[] sqlp = { new SqlParameter("seller_no", seller_No) };
            try
            {
                lstobj = con.SendReadQuery(query, sqlp);                
            }
            catch
            {
                throw;
            }
            foreach (var item in lstobj)
            {
                lstPro.Add((Product)item);
            }
            return lstPro;
        }

        public bool Insert_Product(Product pro)
        {
            bool result = false;
            string query = "insert_product";
            SqlParameter[] sqlp = {
                new SqlParameter("pro_ID", pro.Pro_ID), new SqlParameter("cat_ID", pro.Cat_ID),
                new SqlParameter("seller_no", pro.Seller_NO), new SqlParameter("pro_name", pro.Pro_Name),
                new SqlParameter("pro_price", pro.Pro_Price), new SqlParameter("main_comment", pro.Main_Comment),
                new SqlParameter("sub_comment", pro.Sub_Comment), new SqlParameter("main_image", pro.Main_Image),
                new SqlParameter("pro_gender", pro.Pro_Gender) };

            result = con.SendExqueteQuery(query, sqlp);

            return result;
        }

        public bool Insert_Product2(Product pro)
        {
            bool result = false;
            string query = "insert_product2";
            SqlParameter[] sqlp = 
                {
                new SqlParameter("pro_ID", pro.Pro_ID), new SqlParameter("cat_ID", pro.Cat_ID),
                new SqlParameter("seller_no", pro.Seller_NO), new SqlParameter("pro_name", pro.Pro_Name),
                new SqlParameter("pro_price", pro.Pro_Price), new SqlParameter("main_comment", pro.Main_Comment),
                new SqlParameter("sub_comment", pro.Sub_Comment), new SqlParameter("main_image", pro.Main_Image),
                new SqlParameter("pro_gender", pro.Pro_Gender),
                new SqlParameter("pro_Uri", pro.ProUri)
            };

            result = con.SendExqueteQuery(query, sqlp);

            return result;
        }

        public bool UpdateProduct(Product pro)
        {
            string query = "UpdateProduct";
            SqlParameter[] sqlp = { new SqlParameter("pro_ID", pro.Pro_ID), new SqlParameter("cat_ID", pro.Cat_ID), new SqlParameter("pro_name", pro.Pro_Name), new SqlParameter("pro_price", pro.Pro_Price), new SqlParameter("main_comment", pro.Main_Comment), new SqlParameter("sub_comment", pro.Sub_Comment), new SqlParameter("main_image", pro.Main_Image), new SqlParameter("pro_discount", pro.Pro_Discount), new SqlParameter("pro_gender", pro.Pro_Gender) };
            return con.SendExqueteQuery(query, sqlp);
        }

        internal bool DeleteProduct(string pro_ID)
        {
            string query = "DeleteProduct";
            SqlParameter[] sqlp = { new SqlParameter("pro_ID", pro_ID) };

            return con.SendExqueteQuery(query, sqlp);
        }

        public int SumOfProLike(int seller_No)
        {
            string qurey = "SumOfProLike";
            SqlParameter[] sqlp = { new SqlParameter("seller_No", seller_No) };
            int rowCount = con.SendScalarReadQuery(qurey, sqlp);
            return rowCount;
        }
    }
}
