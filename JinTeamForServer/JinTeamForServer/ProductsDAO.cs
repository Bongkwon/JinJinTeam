using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    class ProductsDAO
    {
        List<Product_VO> pro_lst = new List<Product_VO>();
        DBConnection conn = new DBConnection();

        public ProductsDAO()
        {
        }
        public List<Product_VO> ShoAllData(string sp)
        {
            pro_lst.Clear();
            pro_lst = conn.SendReadQuery(sp, null);

            return pro_lst;
        }
    }
}