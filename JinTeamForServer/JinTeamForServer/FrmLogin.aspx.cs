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
        string cus_ID;
        string cus_pass;
        protected void Page_Load(object sender, EventArgs e)
        {

            //if ((string.IsNullOrEmpty(Request.Params["cus_ID"].ToString()) || string.IsNullOrEmpty(Request.Params["cus_pwd"].ToString())) == null)
            //{
            //    cus_ID = Request.Params["cus_ID"].ToString();
            //    cus_pass = Request.Params["cus_pwd"].ToString();
            //}
            cus_ID = "kyk1234";
            cus_pass = "qwer1234"; 
            //else
            //{
               // Label1.Text = "안돼 돌아가";
            //}

            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

            try
            {
                con.Open();
                Label1.Text = "헤헹";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "chkLogin";
                cmd.Parameters.AddWithValue("cus_ID", cus_ID);
                cmd.Parameters.AddWithValue("cus_pwd", cus_pass);
                string result = cmd.ExecuteScalar().ToString();
                //if (result == "1")
                //{

                //}
                //else
                //{

                //}
                Label1.Text = result;
            }
            catch (Exception)
            {

                throw;
            }

            con.Close();
            
        }
    }
}