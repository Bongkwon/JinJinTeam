using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    class ProductsDAO
    {
        List<Product_VO> pro_lst = new List<Product_VO>();
        DBConnection con = new DBConnection();

        public ProductsDAO()
        {
        }
        public List<Product_VO> ShoAllData(string sp)
        {
            pro_lst.Clear();
            pro_lst = con.SendReadQuery(sp, null);

            return pro_lst;
        }

        public string ProductsReadTable()
        {
            string json = null;
            string sp = "select_pro";
            SqlParameter[] sqlParameters = null;// new SqlParameter[1];

            DataTable dt = con.ExcuteSelect(sp, sqlParameters);

            json = JsonConvert.SerializeObject(dt);


            return json;
        }

        public string ProductsReadTable(string cat_ID)
        {
            string json = null;
            DBConnection con = new DBConnection();
            string sp = "SearchProducts";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("cat_ID", cat_ID);

            DataTable dt = con.ExcuteSelect(sp, sqlParameters);

            if (dt.Rows.Count == 0)
            {
                json = "<Categories><DataCount>" + dt.Rows.Count + "</DataCount></Categories>";
            }
            else
            {
                json = JsonConvert.SerializeObject(dt, Formatting.Indented);
            }

            return json;
        }
    }
}