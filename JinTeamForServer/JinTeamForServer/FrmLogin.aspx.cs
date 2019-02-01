using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        string errCode;
        string cus_ID;
        string cus_pwd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_ID"] != null && Request.Params["cus_pwd"] != null)
            {
                cus_ID = Request.Params["cus_ID"];
                cus_pwd = Request.Params["cus_pwd"];
            }

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            con.Open();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "chkLogin";
            cmd.Parameters.AddWithValue("cus_ID", cus_ID);
            cmd.Parameters.AddWithValue("cus_pwd", cus_pwd);
            object result = cmd.ExecuteScalar();


            if (result != null)
            {
                errCode = "500";    //로그인 성공
                Response.Write(errCode);
            }
            else
            {
                errCode = "600";    // 로그인 실패
                Response.Write(errCode);
            }

            con.Close();
        }
    }
}