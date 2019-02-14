using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        string cus_ID;
        string cus_pass;
        string json;
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(Request.Params["cus_ID"].ToString()) || String.IsNullOrEmpty(Request.Params["cus_pwd"].ToString())))
            {
                json = "200";   // 입력 없음 에러   (에러 날 일 없음 테스트용)
            }
            else
            {
                cus_ID = Request.Params["cus_ID"].ToString();
                cus_pass = Request.Params["cus_pwd"].ToString();
            }

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            //try
            //{
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "chkLogin";
            cmd.Parameters.AddWithValue("cus_ID", cus_ID);
            cmd.Parameters.AddWithValue("cus_pwd", cus_pass);
            object result = cmd.ExecuteScalar();


            if (result != null)
            {
                //로그인 성공

                DBConnection connection = new DBConnection();

                json = null;
                string sp = "select_cus_ID";
                SqlParameter[] sqlParameters = { new SqlParameter("cus_ID", cus_ID) };

                DataTable dt = connection.ExcuteSelect(sp, sqlParameters);
                
                if (dt.Rows.Count == 0)
                {
                    json = "<Categories><DataCount>" + dt.Rows.Count + "</DataCount></Categories>";
                }
                else
                {
                    json = JsonConvert.SerializeObject(dt);
                }
            }
            else
            {
                json = "600";
            }

            con.Close();
            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}