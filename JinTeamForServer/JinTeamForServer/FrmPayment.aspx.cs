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
    public partial class FrmPayment : System.Web.UI.Page
    {
        string order_ID;
        int cus_no;
        string stock_ID;
        int order_count;
        int order_price;
        string order_require;
        
        string user_ship_ID;
        string wish_ID;


        string json;
        OrderList_DAO old = new OrderList_DAO();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["order_ID"] != null && Request.Params["cus_no"] != null && Request.Params["stock_ID"] != null && Request.Params["order_count"] != null && Request.Params["order_price"] != null && Request.Params["user_ship_ID"] != null && Request.Params["wish_ID"] != null)
            {
                order_ID = Request.Params["order_ID"];
                cus_no = Int32.Parse(Request.Params["cus_no"]);
                stock_ID = Request.Params["stock_ID"];
                order_count = Int32.Parse(Request.Params["order_count"]);
                order_price = Int32.Parse(Request.Params["order_price"]);
                
                if (String.IsNullOrEmpty(Request.Params["ship_require"]))
                {
                    order_require = "없음";
                }
                else
                {
                    order_require = Request.Params["ship_require"];
                }
                user_ship_ID = Request.Params["user_ship_ID"];
                wish_ID = Request.Params["wish_ID"];

                SqlConnection con = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                con.ConnectionString = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
                
                con.Open();
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "Final_Purchase";
                cmd.Parameters.AddWithValue("@order_ID", order_ID);
                cmd.Parameters.AddWithValue("@cus_no", cus_no);
                cmd.Parameters.AddWithValue("@stock_ID", stock_ID);
                cmd.Parameters.AddWithValue("@order_count", order_count);
                cmd.Parameters.AddWithValue("@order_price", order_price);
                cmd.Parameters.AddWithValue("@order_require", order_require);
                cmd.Parameters.AddWithValue("@user_ship_ID", user_ship_ID);
                cmd.Parameters.AddWithValue("@wish_ID", wish_ID);
                cmd.ExecuteNonQuery();

                json = "3000";  // 성공
            }
            else
            {
                json = "3001";  // 에러
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}