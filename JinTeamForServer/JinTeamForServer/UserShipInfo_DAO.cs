using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class UserShipInfo_DAO
    {
        List<UserShipInfo_VO> shipInfo_lst = new List<UserShipInfo_VO>();
        DBConnection con = new DBConnection();

        public UserShipInfo_DAO()
        {

        }

        public string ShipInfoReadTable(string order_ID)
        {
            string json = null;
            DBConnection con = new DBConnection();
            string sp = "select_user_ship_info";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("order_ID", order_ID);

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