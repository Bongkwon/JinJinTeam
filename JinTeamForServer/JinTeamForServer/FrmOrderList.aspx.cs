using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmOrderList : System.Web.UI.Page
    {
        OrderList_DAO ord = new OrderList_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            string cus_no = null;
            string json = null;

            if (String.IsNullOrEmpty(Request.Params["cus_no"]))
            {
                json = "700";    // cus_no 입력 없음
            }
            else
            {
                cus_no = Request.Params["cus_no"].ToString();
                json = ord.OrderReadTable(cus_no);
                if (json == "<Categories><DataCount>0</DataCount></Categories>")
                {
                    json = "701";   // 구매내역 없음
                }
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}