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

        public string SelectSavedShipInfo(string cus_no)
        {
            string json = null;
            DBConnection con = new DBConnection();
            string sp = "select_saved_user_ship_info";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("cus_no", cus_no);

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

        public void InsertUserShipInfo(UserShipInfo_VO usi)
        {
            string query = "insert_user_ship_info";
            SqlParameter[] sqlp = { new SqlParameter("cus_no", usi.Cus_No), new SqlParameter("user_name", usi.User_name), new SqlParameter("user_addr", usi.User_addr), new SqlParameter("postal_code", usi.Postal_Code), new SqlParameter("ship_require", usi.Ship_Require) };
            try
            {
                con.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
        }


        public void DeleteUserShipInfo(int user_ship_Id)
        {
            string query = "Delete_User_Ship_Info";
            SqlParameter[] sqls =
            {
                new SqlParameter("user_ship_Id",user_ship_Id)
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