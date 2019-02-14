using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class OrderList_DAO
    {
        List<OrderList_VO> ord_lst = new List<OrderList_VO>();
        DBConnection con = new DBConnection();

        public OrderList_DAO()
        {

        }

        public string OrderReadTable(string cus_No)
        {
            string json = null;
            DBConnection con = new DBConnection();
            string sp = "select_Order";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("cus_no", cus_No);

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