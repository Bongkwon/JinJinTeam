using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace JinTeamForServer
{
    public class Inquire_DAO
    {
        DBConnection con = new DBConnection();

        public void InsertInquire(Inquire_VO iv)
        {
            string query = "InsertInquire";
            SqlParameter[] sqls =
            {
                new SqlParameter("inquire_type",iv.Inquire_type),
                new SqlParameter("inquire_Id",iv.Inquire_Id),
                new SqlParameter("cus_or_sell",iv.Cus_or_sell),
                new SqlParameter("inquire_title",iv.Inquire_title),
                new SqlParameter("inquire_body",iv.Inquire_body)
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

        public string SelectInquire(int inquire_Id)
        {
            string json = null;
            DBConnection con = new DBConnection();
            string sp = "select_cus_inquire_to_ID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("inquire_Id", inquire_Id);

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