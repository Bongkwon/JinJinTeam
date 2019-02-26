using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmDeleteWishList : System.Web.UI.Page
    {
        WishListDAO wdao = new WishListDAO();
        int cus_No;
        string wish_ID;
        string json;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["cus_No"] != null)
            {
                cus_No = Int32.Parse(Request.Params["cus_No"]);

                wdao.DeleteAllWishList(cus_No);
                json = "2100"; // 모두삭제완료
            }
            else if (Request.Params["wish_ID"] != null)
            {
                wish_ID = Request.Params["wish_ID"];

                wdao.DeleteWishList(wish_ID);
                json = "2101"; // 하나 삭제
            }
            else
            {
                json = "2102";  // 입력 없음
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}