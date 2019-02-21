using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmShowWishList : System.Web.UI.Page
    {
        WishListDAO wdao = new WishListDAO();
        int cus_No;
        string json;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_No"] != null)
            {
                cus_No = Int32.Parse(Request.Params["cus_No"]);

                json = wdao.SelectWishList(cus_No);
                if (json == "<Categories><DataCount>0</DataCount></Categories>")
                {
                    json = "1302"; // 장바구니 추가 기록이 없음
                }
            }
            else
            {
                json = "1301";   // cus_No 입력 없음 에러
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}