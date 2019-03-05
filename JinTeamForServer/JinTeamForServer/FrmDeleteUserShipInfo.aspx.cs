using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JinTeamForServer
{
    public partial class FrmDeleteUserShipInfo : System.Web.UI.Page
    {
        UserShipInfo_DAO usid = new UserShipInfo_DAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            int user_ship_Id;
            string json = null;

            if (String.IsNullOrEmpty(Request.Params["user_ship_Id"]))
            {
                json = "2204";    // user_ship_Id 입력 없음
            }
            else
            {
                user_ship_Id = Int32.Parse(Request.Params["user_ship_Id"].ToString());
                usid.DeleteUserShipInfo(user_ship_Id);
                json = "2203";  // 배송지 정보 삭제 완료
            }

            Response.Clear();
            Response.ContentType = "application/json, charset=utf-8";
            Response.Write(json);
            Response.Flush();
            Response.End();
        }
    }
}